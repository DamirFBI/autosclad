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

namespace AutoSclad.MasterSclad
{
    public partial class MasterWork : Form
    {
        public MasterWork()
        {
            InitializeComponent();
        }
        Point lastPoint;
        public void MasterWork_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        public void MasterWork_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ExitGoLogin exitGoLogin = new ExitGoLogin();
            exitGoLogin.ShowDialog(); //Закрывает программу.
        }

        private void Sclad_Click(object sender, EventArgs e)
        {
            Sclad Sclad = new Sclad();
            Sclad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallWorkmanToMaster callWorkmanToMasterOpenForm = new CallWorkmanToMaster();
            callWorkmanToMasterOpenForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddTovarToSclad addTovarToScladOpenForm = new AddTovarToSclad();
            addTovarToScladOpenForm.Show();

        }
    }
}
