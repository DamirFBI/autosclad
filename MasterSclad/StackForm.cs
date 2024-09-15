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
using AutoSclad.AutoScladDataSetTableAdapters;

namespace AutoSclad.MasterSclad
{
    public partial class StackForm : MaterialForm
    {
        public int id = 0;
        public bool edit = false;

        public StackForm(int id, bool edit)
        {
            InitializeComponent();
            this.id = id;
            this.edit = edit;
        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void StackForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.stask". При необходимости она может быть перемещена или удалена.
            this.staskTableAdapter.Fill(this.autoScladDataSet.stask);
            if (this.edit)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.stask". При необходимости она может быть перемещена или удалена.
                staskTableAdapter.Fill(autoScladDataSet.stask);
                staskBindingSource.Position = this.id;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
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
            }
            else
            {
                AutoScladDataSet.staskRow staskRow = ((AutoScladDataSet.staskRow)(autoScladDataSet.stask.NewRow()));
                foreach (Control c in this.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        staskRow.SetField(b.BindingMemberInfo.BindingField, c.Text);
                    }
                }
                autoScladDataSet.stask.AddstaskRow(staskRow);
            }
            staskBindingSource.EndEdit();
            staskTableAdapter.Update(autoScladDataSet);
            autoScladDataSet.AcceptChanges();
            this.Close();
        }
    }
}
