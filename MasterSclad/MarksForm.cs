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
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;

namespace AutoSclad.MasterSclad
{
    public partial class MarksForm : Form
    {
        public int id = 0;
        public bool edit = false;

        public MarksForm(int id, bool edit)
        {
            InitializeComponent();
            this.id = id;
            this.edit = edit;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sclad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.marks". При необходимости она может быть перемещена или удалена.
            this.marksTableAdapter.Fill(this.autoScladDataSet.marks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.marks". При необходимости она может быть перемещена или удалена.
            this.marksTableAdapter.Fill(this.autoScladDataSet.marks);
            if (this.edit)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.marks". При необходимости она может быть перемещена или удалена.
                marksTableAdapter.Fill(autoScladDataSet.marks);
                marksBindingSource.Position = this.id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.edit)
            {
                foreach (Control c in this.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        b.WriteValue();
                    }
                }
            } else {
                AutoScladDataSet.marksRow marksRow = ((AutoScladDataSet.marksRow)(autoScladDataSet.marks.NewRow()));
                foreach (Control c in this.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        marksRow.SetField(b.BindingMemberInfo.BindingField, c.Text);
                    }
                }
                autoScladDataSet.marks.AddmarksRow(marksRow);
            }
            marksBindingSource.EndEdit();
            marksTableAdapter.Update(autoScladDataSet);
            autoScladDataSet.AcceptChanges();
            this.Close();
        }
    }
}
