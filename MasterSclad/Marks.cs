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
    public partial class Marks : Form
    {
        public Marks()
        {
            InitializeComponent();
        }

        private void open_Form(bool edit = false)
        {
            int id = marksBindingSource.Position;
            var form = new MarksForm(id, edit);
            form.ShowDialog();
            this.marksTableAdapter.Fill(this.autoScladDataSet.marks);
            marksBindingSource.Position = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marksBindingSource.RemoveCurrent();
            marksTableAdapter.Update(autoScladDataSet);
            marksBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.marks". При необходимости она может быть перемещена или удалена.
            this.marksTableAdapter.Fill(this.autoScladDataSet.marks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.marks". При необходимости она может быть перемещена или удалена.
            this.marksTableAdapter.Fill(this.autoScladDataSet.marks);

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
            marksBindingSource.RemoveCurrent();
            marksTableAdapter.Update(autoScladDataSet);
            marksBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }
    }
}
