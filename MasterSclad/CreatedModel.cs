﻿using System;
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
    public partial class CreatedModel : Form
    {
        public CreatedModel()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void CreatedModel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если пользователь зажал левой кнопкой по окну, то он может передвигать окно.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CreatedModel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    //Закрепляет позицию после перемещения
        }

        private void AddModel_Click(object sender, EventArgs e)
        {

        }

        private void EditModel_Click(object sender, EventArgs e)
        {
            EditModel EditModelOpenForm = new EditModel();
            EditModelOpenForm.ShowDialog();
        }
    }
}
