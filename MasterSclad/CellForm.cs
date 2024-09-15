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
    public partial class CellForm : MaterialForm
    {
        public CellForm()
        {
            InitializeComponent();
        }

        private void CellForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.stask". При необходимости она может быть перемещена или удалена.
            this.staskTableAdapter.Fill(this.autoScladDataSet.stask);

        }
    }
}
