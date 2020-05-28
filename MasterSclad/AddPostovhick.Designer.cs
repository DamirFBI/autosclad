namespace AutoSclad.MasterSclad
{
    partial class AddPostovhick
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Postavhik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdressPostavhik = new System.Windows.Forms.TextBox();
            this.TelefonPostavhik = new System.Windows.Forms.TextBox();
            this.EmailPostavhik = new System.Windows.Forms.TextBox();
            this.AddPostavhik = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // Postavhik
            // 
            this.Postavhik.Location = new System.Drawing.Point(16, 30);
            this.Postavhik.Name = "Postavhik";
            this.Postavhik.Size = new System.Drawing.Size(278, 22);
            this.Postavhik.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Электронный сайт";
            // 
            // AdressPostavhik
            // 
            this.AdressPostavhik.Location = new System.Drawing.Point(16, 82);
            this.AdressPostavhik.Name = "AdressPostavhik";
            this.AdressPostavhik.Size = new System.Drawing.Size(278, 22);
            this.AdressPostavhik.TabIndex = 5;
            // 
            // TelefonPostavhik
            // 
            this.TelefonPostavhik.Location = new System.Drawing.Point(16, 135);
            this.TelefonPostavhik.Name = "TelefonPostavhik";
            this.TelefonPostavhik.Size = new System.Drawing.Size(278, 22);
            this.TelefonPostavhik.TabIndex = 6;
            // 
            // EmailPostavhik
            // 
            this.EmailPostavhik.Location = new System.Drawing.Point(16, 193);
            this.EmailPostavhik.Name = "EmailPostavhik";
            this.EmailPostavhik.Size = new System.Drawing.Size(278, 22);
            this.EmailPostavhik.TabIndex = 7;
            // 
            // AddPostavhik
            // 
            this.AddPostavhik.Location = new System.Drawing.Point(27, 254);
            this.AddPostavhik.Name = "AddPostavhik";
            this.AddPostavhik.Size = new System.Drawing.Size(75, 23);
            this.AddPostavhik.TabIndex = 8;
            this.AddPostavhik.Text = "Добавить";
            this.AddPostavhik.UseVisualStyleBackColor = true;
            this.AddPostavhik.Click += new System.EventHandler(this.AddPostavhik_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPostovhick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 290);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddPostavhik);
            this.Controls.Add(this.EmailPostavhik);
            this.Controls.Add(this.TelefonPostavhik);
            this.Controls.Add(this.AdressPostavhik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Postavhik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(305, 290);
            this.MinimumSize = new System.Drawing.Size(305, 290);
            this.Name = "AddPostovhick";
            this.Text = "AddPostovhick";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddPostovhick_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPostovhick_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Postavhik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdressPostavhik;
        private System.Windows.Forms.TextBox TelefonPostavhik;
        private System.Windows.Forms.TextBox EmailPostavhik;
        private System.Windows.Forms.Button AddPostavhik;
        private System.Windows.Forms.Button button2;
    }
}