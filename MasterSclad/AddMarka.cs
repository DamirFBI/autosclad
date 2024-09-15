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
    public partial class AddMarka : Form
    {
        public AddMarka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MarkaAdd.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }



            if (isUserExists())
                return;
            Dibi db = new Dibi();
            MySqlCommand command = new MySqlCommand("INSERT INTO `marka` ( `Marka`) VALUES (@Marka)", db.getconnection());
            command.Parameters.Add("@Marka", MySqlDbType.VarChar).Value = MarkaAdd.Text;

            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Марка была создана");
            }
            else
                MessageBox.Show("Марка не была создана");
            db.closeconnection();

        }
        public Boolean isUserExists()
        {

            Dibi db = new Dibi();     //Создания переменной и выделение памяти

            DataTable table = new DataTable();   //Создания переменной и выделение памяти

            MySqlDataAdapter adapter = new MySqlDataAdapter();   //Создания переменной и выделение памяти

            MySqlCommand command = new MySqlCommand(" SELECT * FROM `marka` WHERE `Marka` = @uL", db.getconnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = MarkaAdd.Text;  //Присвоения значений из БД

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)      //Если есть данные в БД
            {
                MessageBox.Show("Такая марка уже существует");    //Выводит сообщение что вы "Авторизованы"
                return true;
            }
            else                                    //Иначе
                return false;

        }
        Point lastPoint;

        private void AddMarka_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddMarka_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
