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
    public partial class Sclad : Form
    {
        public Sclad()
        {
            InitializeComponent();

           /*this.IsMdiContainer = true;*/
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            Form2 FormDrives = new Form2();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            Form3 FormDrives = new Form3();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void conductorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form4 FormDrives = new Form4();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form5 FormDrives = new Form5();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void отработанноеВремяВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Form6 FormDrives = new Form6();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void пробегАвтобусовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form7 FormDrives = new Form7();
            FormDrives.MdiParent = this;
            FormDrives.Show();
*/
        }

        private void выручкаКондукторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form8 FormDrives = new Form8();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void путивыеЛистыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*Form9 FormDrives = new Form9();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void путивыеЛистыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form10 FormDrives = new Form10();
            FormDrives.MdiParent = this;
            FormDrives.Show();*/

        }

        private void реестрПутёвокВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form11 FormDriversPrint = new Form11();
            FormDriversPrint.Show();*/
        }

        private void шаблонДоговораНаПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"doc\dogovor_na_postavku.doc");
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Справка.pdf");
        }

        private void оПрограмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            /*AboutBox1 FormAbout = new AboutBox1();
            
            FormAbout.ShowDialog();*/
        }

        private void materialPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainTabSelector_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.autoScladDataSet.sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.stask". При необходимости она может быть перемещена или удалена.
            this.staskTableAdapter.FillBy(this.autoScladDataSet.stask);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void open_ScladForm(bool edit = false)
        {
            int id = skladBindingSource.Position;
            var form = new ScladForm(id, edit);
            form.ShowDialog();
            this.skladTableAdapter.Fill(this.autoScladDataSet.sklad);
            skladBindingSource.Position = id;
        }

        private void open_StackForm(bool edit = false)
        {
            int id = staskBindingSource.Position;
            var form = new StackForm(id, edit);
            form.ShowDialog();
            this.staskTableAdapter.Fill(this.autoScladDataSet.stask);
            staskBindingSource.Position = id;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            open_ScladForm(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open_ScladForm(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            open_StackForm(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            open_StackForm(true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var form = new CellForm();
            form.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skladBindingSource.RemoveCurrent();
            skladTableAdapter.Update(autoScladDataSet);
            skladBindingSource.EndEdit();
            autoScladDataSet.AcceptChanges();
        }

        private void skladBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skladBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
