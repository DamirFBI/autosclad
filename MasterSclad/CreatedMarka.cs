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
    public partial class CreatedMarka : Form
    {
        public CreatedMarka()
        {
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;

        private void CreatedMarka_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CreatedMarka_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMarkaToAddMarka_Click(object sender, EventArgs e)
        {

        }

        private void EditMarkaToAddMarka_Click(object sender, EventArgs e)
        {

        }

        private void AddMarkaToAddMarka_Click(object sender, EventArgs e)
        {
            AddMarka addMarkaOpenForm = new AddMarka();
            addMarkaOpenForm.ShowDialog();
        }

        public void SelectMarkaToAddMarka_Click(object sender, EventArgs e)
        {

        }
    }
}
