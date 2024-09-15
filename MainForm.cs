using AutoSclad.MasterSclad;
using MaterialSkin.Controls;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void справочникСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sclad form = new Sclad();
            form.MdiParent = this;
            form.ShowDialog();
        }

        private void справочникТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tovar form = new Tovar();
            form.MdiParent = this;
            form.Show();
        }

        private void справочникКатегорийТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marks form = new Marks();
            form.MdiParent = this;
            form.ShowDialog();
        }

        private void справочникПоставщиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider form = new Provider();
            form.MdiParent = this;
            form.ShowDialog();
        }

        private void справочникЕденицИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Models form = new Models();
            form.MdiParent = this;
            form.ShowDialog();
        }

        private void справочникПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.MdiParent = this;
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
