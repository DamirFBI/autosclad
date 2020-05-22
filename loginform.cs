using AutoSclad.Workman;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AutoSclad
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Закрывает программу.
        }
        Point lastPoint;
        private void loginform_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
              this.Left += e.X - lastPoint.X;
              this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loginform_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string loginuser = LoginBox.Text;       //Создание переменной loginuser и присвоения к логинБоксу
            string passuser = PasswordBox.Text;     //Создание переменной passuser и присвоения к парольБоксу


            Dibi db = new Dibi();     //Создания переменной и выделение памяти

            DataTable table = new DataTable();   //Создания переменной и выделение памяти

            MySqlDataAdapter adapter = new MySqlDataAdapter();   //Создания переменной и выделение памяти
            string TypeUserBD = "Работник";

            MySqlCommand command = new MySqlCommand(" SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP AND `typeuser` = @uT ", db.getconnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginuser;  //Присвоения значений из БД
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passuser;  //Присвоения значений из БД
            command.Parameters.Add("@uT", MySqlDbType.VarChar).Value = TypeUserBD;  //Присвоения значений из БД

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {      //Если есть данные в БД
                MessageBox.Show("Авторизованы");    //Выводит сообщение что вы "Авторизованы"
                if (TypeUserBD == "Работник")
                {
                    this.Hide();
                    Workpanelman workpanelOpenman = new Workpanelman();
                    workpanelOpenman.Show(); //Закрывает программу.

                }
            }
            else                                    //Иначе
                MessageBox.Show("Неверный пароль или логин");   //Выводит сообщение что "Неверный пароль или логин"
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
