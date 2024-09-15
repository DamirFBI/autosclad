namespace AutoSclad.MasterSclad
{
    partial class ScladForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameScladAdd = new System.Windows.Forms.TextBox();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoScladDataSet = new AutoSclad.AutoScladDataSet();
            this.ArdessScladAdd = new System.Windows.Forms.TextBox();
            this.TelefonScladAdd = new System.Windows.Forms.TextBox();
            this.RazmerScladaAdd = new System.Windows.Forms.TextBox();
            this.ZonaExpiditionAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.skladTableAdapter = new AutoSclad.AutoScladDataSetTableAdapters.skladTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScladDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(215, 195);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Закрыт";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наиминование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер склада";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Размер зоны экспедиции ";
            // 
            // NameScladAdd
            // 
            this.NameScladAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "name", true));
            this.NameScladAdd.Location = new System.Drawing.Point(169, 14);
            this.NameScladAdd.Name = "NameScladAdd";
            this.NameScladAdd.Size = new System.Drawing.Size(100, 20);
            this.NameScladAdd.TabIndex = 5;
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
            // ArdessScladAdd
            // 
            this.ArdessScladAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "adress", true));
            this.ArdessScladAdd.Location = new System.Drawing.Point(169, 48);
            this.ArdessScladAdd.Name = "ArdessScladAdd";
            this.ArdessScladAdd.Size = new System.Drawing.Size(100, 20);
            this.ArdessScladAdd.TabIndex = 6;
            // 
            // TelefonScladAdd
            // 
            this.TelefonScladAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "phone", true));
            this.TelefonScladAdd.Location = new System.Drawing.Point(169, 80);
            this.TelefonScladAdd.Name = "TelefonScladAdd";
            this.TelefonScladAdd.Size = new System.Drawing.Size(100, 20);
            this.TelefonScladAdd.TabIndex = 7;
            // 
            // RazmerScladaAdd
            // 
            this.RazmerScladaAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "sizeSklad", true));
            this.RazmerScladaAdd.Location = new System.Drawing.Point(169, 118);
            this.RazmerScladaAdd.Name = "RazmerScladaAdd";
            this.RazmerScladaAdd.Size = new System.Drawing.Size(100, 20);
            this.RazmerScladaAdd.TabIndex = 8;
            // 
            // ZonaExpiditionAdd
            // 
            this.ZonaExpiditionAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "sizeExpedit", true));
            this.ZonaExpiditionAdd.Location = new System.Drawing.Point(169, 159);
            this.ZonaExpiditionAdd.Name = "ZonaExpiditionAdd";
            this.ZonaExpiditionAdd.Size = new System.Drawing.Size(100, 20);
            this.ZonaExpiditionAdd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "м2";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(134, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // ScladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ZonaExpiditionAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RazmerScladaAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelefonScladAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArdessScladAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameScladAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScladForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование склада";
            this.Load += new System.EventHandler(this.Sclad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScladDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameScladAdd;
        private System.Windows.Forms.TextBox ArdessScladAdd;
        private System.Windows.Forms.TextBox TelefonScladAdd;
        private System.Windows.Forms.TextBox RazmerScladaAdd;
        private System.Windows.Forms.TextBox ZonaExpiditionAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private AutoScladDataSet autoScladDataSet;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private AutoScladDataSetTableAdapters.skladTableAdapter skladTableAdapter;
    }
}