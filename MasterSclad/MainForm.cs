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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet1.cell". При необходимости она может быть перемещена или удалена.
            this.cellTableAdapter.Fill(this.autoScladDataSet1.cell);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.stask". При необходимости она может быть перемещена или удалена.
            this.staskTableAdapter.Fill(this.autoScladDataSet.stask);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.autoScladDataSet.sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoScladDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.autoScladDataSet.users);

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

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ScladForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new ScladForm();
            form.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new StackForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new StackForm();
            form.ShowDialog();
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
    }
}
