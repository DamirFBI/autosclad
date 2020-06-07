namespace AutoSclad.MasterSclad
{
    partial class CellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Exit = new System.Windows.Forms.Button();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoScladDataSet = new AutoSclad.AutoScladDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.skladTableAdapter = new AutoSclad.AutoScladDataSetTableAdapters.skladTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.staskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staskTableAdapter = new AutoSclad.AutoScladDataSetTableAdapters.staskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(226, 219);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Закрыт";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "sklad";
            this.skladBindingSource.DataSource = this.autoScladDataSet;
            // 
            // autoScladDataSet
            // 
            this.autoScladDataSet.DataSetName = "AutoScladDataSet";
            this.autoScladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(145, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.staskBindingSource, "id", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staskBindingSource, "id", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staskBindingSource, "nameZ", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.staskBindingSource, "nameZ", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(158, 188);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(143, 20);
            this.textBox8.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(158, 158);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(143, 20);
            this.textBox7.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(158, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(143, 20);
            this.textBox6.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Глубина";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ширина";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Высота";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Размер ячейки м";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Стеллаж";
            // 
            // staskBindingSource
            // 
            this.staskBindingSource.DataMember = "stask";
            this.staskBindingSource.DataSource = this.autoScladDataSet;
            // 
            // staskTableAdapter
            // 
            this.staskTableAdapter.ClearBeforeFill = true;
            // 
            // CellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 254);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование ячейки";
            this.Load += new System.EventHandler(this.CellForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
        private AutoScladDataSet autoScladDataSet;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private AutoScladDataSetTableAdapters.skladTableAdapter skladTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource staskBindingSource;
        private AutoScladDataSetTableAdapters.staskTableAdapter staskTableAdapter;
    }
}