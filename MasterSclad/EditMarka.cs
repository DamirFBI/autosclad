using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSclad.MasterSclad
{
    public partial class EditMarka : Form
    {
        public EditMarka()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void EditMarka_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void EditMarka_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void CloseEditMarakForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
