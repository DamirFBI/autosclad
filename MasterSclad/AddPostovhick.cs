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
    public partial class AddPostovhick : Form
    {
        public AddPostovhick()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPostavhik_Click(object sender, EventArgs e)
        {
            Dibi db = new Dibi();
            MySqlCommand command = new MySqlCommand("INSERT INTO `postabhiki` ( `Postabhik`, `Adress`, `Telefon`, `Email`) VALUES (@Postabhik, @Adress, @Telefon, @Email)", db.getconnection());
            command.Parameters.Add("@Postabhik", MySqlDbType.VarChar).Value = Postavhik.Text;
            command.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = AdressPostavhik.Text;
            command.Parameters.Add("@Telefon", MySqlDbType.VarChar).Value = TelefonPostavhik.Text;
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailPostavhik.Text;
           
            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Поставщик добавлен");
            }
            else
                MessageBox.Show("Поставщик не добавлен");
            db.closeconnection();
        }
        public Boolean isUserExists()
        {

            Dibi db = new Dibi();     //Создания переменной и выделение памяти

            DataTable table = new DataTable();   //Создания переменной и выделение памяти

            MySqlDataAdapter adapter = new MySqlDataAdapter();   //Создания переменной и выделение памяти

            MySqlCommand command = new MySqlCommand(" SELECT * FROM `postabhiki` WHERE `Postabhik` = @Postabhik", db.getconnection());
            command.Parameters.Add("@Postabhik", MySqlDbType.VarChar).Value = Postavhik.Text;  //Присвоения значений из БД

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)      //Если есть данные в БД
            {
                MessageBox.Show("Такой поставщик есть введите другого поставщика");    //Выводит сообщение что вы "Авторизованы"
                return true;
            }
            else                                    //Иначе
                return false;

        }
        Point lastPoint;

        private void AddPostovhick_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddPostovhick_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }
    }
}
