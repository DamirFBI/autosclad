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
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
        }

        private void open_Form(bool edit = false)
        {
            int id = providerBindingSource.Position;
            var form = new ProviderForm(id, edit);
            form.ShowDialog();
            this.providerTableAdapter.Fill(this.autoScladDataSet.provider);
            providerBindingSource.Position = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            providerBindingSource.RemoveCurrent();
            providerTableAdapter.Update(autoScladDataSet);
            providerBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.autoScladDataSet.provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.autoScladDataSet.provider);

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
            providerBindingSource.RemoveCurrent();
            providerTableAdapter.Update(autoScladDataSet);
            providerBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }
    }
}
