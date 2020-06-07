using AutoSclad.ServiceDialog;
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
using MaterialSkin.Controls;

namespace AutoSclad.MasterSclad
{
    public partial class ScladForm : MaterialForm
    {
        public ScladForm()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void Sclad_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Sclad_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close(); //Закрывает программу.
        }

        private void DeleteStelagButton_Click(object sender, EventArgs e)
        {
            DeleteYesNo deleteYesNoStelagOpenDialog = new DeleteYesNo();
            deleteYesNoStelagOpenDialog.ShowDialog();
        }

        public void DeleteScladButton_Click(object sender, EventArgs e)
        {
            DeleteYesNo deleteYesNoScladOpenDialog = new DeleteYesNo();
            deleteYesNoScladOpenDialog.ShowDialog();

        }

        private void Sclad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.autoScladDataSet.sklad);

        }

        private void CreatedScladButton_Click(object sender, EventArgs e)
        {
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            skladBindingSource.EndEdit();
            /*Dibi db = new Dibi();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Sclad` ( `NameSclad`, `Adress`, `Telefon`, `RazmerSclada`, `RazmerExpidition`) VALUES (@NameSclad, @Adress, @Telefon, @RazmerSclada, @RazmerExpidition)", db.getconnection());
            command.Parameters.Add("@NameSclad", MySqlDbType.VarChar).Value = NameScladAdd.Text;
            command.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = ArdessScladAdd.Text;
            command.Parameters.Add("@Telefon", MySqlDbType.VarChar).Value = TelefonScladAdd.Text;
            command.Parameters.Add("@RazmerSclada", MySqlDbType.VarChar).Value = RazmerScladaAdd.Text;
            command.Parameters.Add("@RazmerExpidition", MySqlDbType.VarChar).Value = ZonaExpiditionAdd.Text;

            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Склад был создан");
            }
            else
                MessageBox.Show("Склад не был создан");

            db.closeconnection();*/
        }

        private void SelectTab_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
