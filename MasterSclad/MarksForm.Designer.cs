namespace AutoSclad.MasterSclad
{
    partial class MarksForm
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
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoScladDataSet = new AutoSclad.AutoScladDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.marksTableAdapter = new AutoSclad.AutoScladDataSetTableAdapters.marksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScladDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(215, 44);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Закрыт";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "marks";
            this.marksBindingSource.DataSource = this.autoScladDataSet;
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
            this.button1.Location = new System.Drawing.Point(134, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Наименование";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 27;
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // MarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 75);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Марка";
            this.Load += new System.EventHandler(this.Sclad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScladDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
        private AutoScladDataSet autoScladDataSet;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private AutoScladDataSetTableAdapters.marksTableAdapter marksTableAdapter;
    }
}