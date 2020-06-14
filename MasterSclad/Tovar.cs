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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void open_Form(bool edit = false)
        {
            int id = productBindingSource.Position;
            var form = new TovarForm(id, edit);
            form.ShowDialog();
            this.productTableAdapter.Fill(this.autoScladDataSet.product);
            productBindingSource.Position = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
            productTableAdapter.Update(autoScladDataSet);
            productBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.autoScladDataSet.product);

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
            productBindingSource.RemoveCurrent();
            productTableAdapter.Update(autoScladDataSet);
            productBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }
    }
}
