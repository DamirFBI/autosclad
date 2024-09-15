using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoSclad.MasterSclad
{
    public partial class AddModel : Form
    {
        public AddModel()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void AddModel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddModel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (textBox1.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }


            if (isUserExists())
                return;
            Dibi db = new Dibi();
            MySqlCommand command = new MySqlCommand("INSERT INTO `model` ( `Model`, `Opisanie`) VALUES (@Model, @Opisanie)", db.getconnection());
            command.Parameters.Add("@Model", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@Opisanie", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Opisanie", MySqlDbType.VarChar).Value = MarkaToFiormAddModel.Text;

            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Модель был создан");
            }
            else
                MessageBox.Show("Модель не была создана");
            db.closeconnection();

        }
        public Boolean isUserExists()
        {

            Dibi db = new Dibi();     //Создания переменной и выделение памяти

            DataTable table = new DataTable();   //Создания переменной и выделение памяти

            MySqlDataAdapter adapter = new MySqlDataAdapter();   //Создания переменной и выделение памяти

            MySqlCommand command = new MySqlCommand(" SELECT * FROM `model` WHERE `Model` = @uL", db.getconnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox2.Text;  //Присвоения значений из БД

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)      //Если есть данные в БД
            {
                MessageBox.Show("Такая модель уже существует");    //Выводит сообщение что вы "Авторизованы"
                return true;
            }
            else                                    //Иначе
                return false;

        }

        private void MarkaToFiormAddModel_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
