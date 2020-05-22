using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSclad.ServiceDialog
{
    public partial class ExitGoLogin : Form
    {
        public ExitGoLogin()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void ExitGoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void ExitGoLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void YesExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            loginform loginform = new loginform();
            loginform.ShowDialog();
        }

        private void NoExit_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void ExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
