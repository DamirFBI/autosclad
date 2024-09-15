using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSclad.Workman
{
    public partial class Workpanelman : Form
    {
        public Workpanelman()
        {
            InitializeComponent();

        }

        private void ExitLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
/*            loginform loginform = new loginform();
            loginform.ShowDialog(); //Закрывает программу.*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallToSclad callToSclad = new CallToSclad();
            callToSclad.Show();
        }
        Point lastPoint;
        private void Workpanelman_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Workpanelman_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }
        private void NameWorkmanLogingText()
        {



        }
    }
}
