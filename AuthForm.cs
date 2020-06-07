using System;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using AutoSclad.MasterSclad;
using MaterialSkin;

namespace AutoSclad
{
    public partial class AuthForm : MaterialForm
    {
        public AuthForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);

        }

        private void RegForm_Load(object sender, EventArgs e)
        {
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Dibi db = new Dibi();     //Создания переменной и выделение памяти

            DataTable table = new DataTable();   //Создания переменной и выделение памяти

            MySqlDataAdapter adapter = new MySqlDataAdapter();   //Создания переменной и выделение памяти

            MySqlCommand command = new MySqlCommand(" SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getconnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = maskedTextBox1.Text;  //Присвоения значений из БД
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textBox13.Text;  //Присвоения значений из БД

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                CurrentUser user = CurrentUser.getInstance();
                user.id = Convert.ToInt32(table.Rows[0].ItemArray[0].ToString());
                user.type = Convert.ToInt32(table.Rows[0].ItemArray[5].ToString());

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин");   //Выводит сообщение что "Неверный пароль или логин"
            }
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
