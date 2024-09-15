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
    public partial class UsersForm : Form
    {
        public int id = 0;
        public bool edit = false;

        public UsersForm(int id, bool edit)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.autoScladDataSet.users);
            if (this.edit)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.users". При необходимости она может быть перемещена или удалена.
                usersTableAdapter.Fill(autoScladDataSet.users);
                usersBindingSource.Position = this.id;
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
                AutoScladDataSet.usersRow usersRow = ((AutoScladDataSet.usersRow)(autoScladDataSet.users.NewRow()));
                foreach (Control c in this.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        usersRow.SetField(b.BindingMemberInfo.BindingField, c.Text);
                    }
                }
                autoScladDataSet.users.AddusersRow(usersRow);
            }
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(autoScladDataSet);
            autoScladDataSet.AcceptChanges();
            this.Close();
        }
    }
}
