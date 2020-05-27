using AutoSclad.MasterSclad;
using AutoSclad.ServiceDialog;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSclad
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;   //Изминяет цвет на серый
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;  //Изминяет цвет на серый
            LoginText.Text = "Введите логин";
            LoginText.ForeColor = Color.Gray;  //Изминяет цвет на серый
            PassText.Text = "Введите пароль";
            PassText.ForeColor = Color.Gray;  //Изминяет цвет на серый

        }
        Point lastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")  // Если в поле имя введене "Введите имя"
            {
                userNameField.Text = ""; // То поле пустует
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "") // Если поле имя пустое
            {
                userNameField.Text = "Введите имя"; //То он заполняется "Введите имя"
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "") // Если поле фамилия пустое
            {
                userSurnameField.Text = "Введите фамилию"; //То он заполняется "Введите фамилию"
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")  // Если в поле имя введено "Введите фамилию"
            {
                userSurnameField.Text = ""; // То поле пустует
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
            if (LoginText.Text == "") // Если поле логин пустое
            {
                LoginText.Text = "Введите логин"; //То он заполняется "Введите логин"
                LoginText.ForeColor = Color.Gray;
            }
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
            if (LoginText.Text == "Введите логин")  // Если в поле имя введено "Введите логин"
            {
                LoginText.Text = ""; // То поле пустует
                LoginText.ForeColor = Color.Black;
            }
        }

        private void PassText_Leave(object sender, EventArgs e)
        {
            if (PassText.Text == "") // Если поле пароль пустое
            {
                PassText.Text = "Введите пароль"; //То он заполняется "Введите пароль"
                PassText.ForeColor = Color.Gray;
            }
        }

        private void PassText_Enter(object sender, EventArgs e)
        {
            if (PassText.Text == "Введите пароль")  // Если в поле имя введено "Введите пароль"
            {
                PassText.Text = ""; // То поле пустует
                PassText.ForeColor = Color.Black;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (PassText.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (LoginText.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (isUserExists())
                return;
            string TUser = TypeUser.Text;
            Dibi db = new Dibi();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `surname`, `typeuser`) VALUES (@login, @pass, @name, @surname, @typeuser)", db.getconnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginText.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassText.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            if (Master.Checked == true)
            {
                command.Parameters.Add("@typeuser", MySqlDbType.VarChar).Value = Master.Text;
            }
            if (WorkMan.Checked == true)
            {
                command.Parameters.Add("@typeuser", MySqlDbType.VarChar).Value = WorkMan.Text;
            }
            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else
                MessageBox.Show("Аккаунт не был создан");
            db.closeconnection();

        }
        public Boolean isUserExists()
        {

            Dibi db = new Dibi();     //Создания переменной и выделение памяти

            DataTable table = new DataTable();   //Создания переменной и выделение памяти

            MySqlDataAdapter adapter = new MySqlDataAdapter();   //Создания переменной и выделение памяти

            MySqlCommand command = new MySqlCommand(" SELECT * FROM `users` WHERE `login` = @uL", db.getconnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginText.Text;  //Присвоения значений из БД

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)      //Если есть данные в БД
            {
                MessageBox.Show("Такой логин пользователя есть введите другой логин");    //Выводит сообщение что вы "Авторизованы"
                return true;
            }
            else                                    //Иначе
                return false;

        }

        private void TypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ExitGoLogin exitGoLogin = new ExitGoLogin();
            exitGoLogin.ShowDialog(); //Закрывает программу.
        }

        private void WorkMan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Master_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
