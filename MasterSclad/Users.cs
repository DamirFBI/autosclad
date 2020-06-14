using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace AutoSclad.MasterSclad
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void open_Form(bool edit = false)
        {
            int id = usersBindingSource.Position;
            var form = new UsersForm(id, edit);
            form.ShowDialog();
            this.usersTableAdapter.Fill(this.autoScladDataSet.users);
            usersBindingSource.Position = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usersBindingSource.RemoveCurrent();
            usersTableAdapter.Update(autoScladDataSet);
            usersBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.autoScladDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.autoScladDataSet.users);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            open_Form(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open_Form(false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            usersBindingSource.RemoveCurrent();
            usersTableAdapter.Update(autoScladDataSet);
            usersBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }
    }
}
