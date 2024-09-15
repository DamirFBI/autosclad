namespace AutoSclad.MasterSclad
{
    partial class MasterWork
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
            this.Sclad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sclad
            // 
            this.Sclad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sclad.Location = new System.Drawing.Point(12, 42);
            this.Sclad.Name = "Sclad";
            this.Sclad.Size = new System.Drawing.Size(75, 23);
            this.Sclad.TabIndex = 0;
            this.Sclad.Text = "Склады";
            this.Sclad.UseVisualStyleBackColor = true;
            this.Sclad.Click += new System.EventHandler(this.Sclad_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(144, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Запросы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(306, 13);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 13);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выйти";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(12, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Разместить товар";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MasterWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 79);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sclad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterWork";
            this.Text = "Кладовщик";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MasterWork_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MasterWork_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sclad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button button5;
    }
}