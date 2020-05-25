namespace AutoSclad.Workman
{
    partial class CallToSclad
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
            this.CallFormMarka = new System.Windows.Forms.ComboBox();
            this.CallFormTip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CallFormModel = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CloseCallToSclad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SformirovatZapros = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CallFormMarka
            // 
            this.CallFormMarka.FormattingEnabled = true;
            this.CallFormMarka.Location = new System.Drawing.Point(218, 37);
            this.CallFormMarka.Name = "CallFormMarka";
            this.CallFormMarka.Size = new System.Drawing.Size(121, 21);
            this.CallFormMarka.TabIndex = 1;
            // 
            // CallFormTip
            // 
            this.CallFormTip.FormattingEnabled = true;
            this.CallFormTip.Location = new System.Drawing.Point(345, 37);
            this.CallFormTip.Name = "CallFormTip";
            this.CallFormTip.Size = new System.Drawing.Size(121, 21);
            this.CallFormTip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Модель";
            // 
            // CallFormModel
            // 
            this.CallFormModel.FormattingEnabled = true;
            this.CallFormModel.Location = new System.Drawing.Point(218, 81);
            this.CallFormModel.Name = "CallFormModel";
            this.CallFormModel.Size = new System.Drawing.Size(121, 21);
            this.CallFormModel.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 264);
            this.listBox1.TabIndex = 9;
            // 
            // CloseCallToSclad
            // 
            this.CloseCallToSclad.AutoSize = true;
            this.CloseCallToSclad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseCallToSclad.Location = new System.Drawing.Point(564, 298);
            this.CloseCallToSclad.Name = "CloseCallToSclad";
            this.CloseCallToSclad.Size = new System.Drawing.Size(41, 13);
            this.CloseCallToSclad.TabIndex = 10;
            this.CloseCallToSclad.Text = "Выход";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 11;
            // 
            // SformirovatZapros
            // 
            this.SformirovatZapros.Location = new System.Drawing.Point(248, 168);
            this.SformirovatZapros.Name = "SformirovatZapros";
            this.SformirovatZapros.Size = new System.Drawing.Size(243, 23);
            this.SformirovatZapros.TabIndex = 12;
            this.SformirovatZapros.Text = "Сформировать запрос";
            this.SformirovatZapros.UseVisualStyleBackColor = true;
            this.SformirovatZapros.Click += new System.EventHandler(this.SformirovatZapros_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Список товара";
            // 
            // CallToSclad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 320);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SformirovatZapros);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CallFormModel);
            this.Controls.Add(this.CloseCallToSclad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CallFormTip);
            this.Controls.Add(this.CallFormMarka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(620, 320);
            this.MinimumSize = new System.Drawing.Size(620, 320);
            this.Name = "CallToSclad";
            this.Text = "CallToSclad";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CallToSclad_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CallToSclad_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CallFormMarka;
        private System.Windows.Forms.ComboBox CallFormTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CallFormModel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label CloseCallToSclad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SformirovatZapros;
        private System.Windows.Forms.Label label6;
    }
}