namespace AutoSclad.ServiceDialog
{
    partial class ExitGoLogin
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
            this.YesExit = new System.Windows.Forms.Label();
            this.NoExit = new System.Windows.Forms.Label();
            this.ExitProgramm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите выйти из учётнои записи?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // YesExit
            // 
            this.YesExit.AutoSize = true;
            this.YesExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesExit.Location = new System.Drawing.Point(51, 39);
            this.YesExit.Name = "YesExit";
            this.YesExit.Size = new System.Drawing.Size(21, 13);
            this.YesExit.TabIndex = 1;
            this.YesExit.Text = "Да";
            this.YesExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.YesExit_MouseClick);
            // 
            // NoExit
            // 
            this.NoExit.AutoSize = true;
            this.NoExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoExit.Location = new System.Drawing.Point(234, 39);
            this.NoExit.Name = "NoExit";
            this.NoExit.Size = new System.Drawing.Size(26, 13);
            this.NoExit.TabIndex = 2;
            this.NoExit.Text = "Нет";
            this.NoExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoExit_MouseClick);
            // 
            // ExitProgramm
            // 
            this.ExitProgramm.AutoSize = true;
            this.ExitProgramm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitProgramm.Location = new System.Drawing.Point(96, 39);
            this.ExitProgramm.Name = "ExitProgramm";
            this.ExitProgramm.Size = new System.Drawing.Size(121, 13);
            this.ExitProgramm.TabIndex = 3;
            this.ExitProgramm.Text = "Выйти из программы";
            this.ExitProgramm.Click += new System.EventHandler(this.ExitProgramm_Click);
            // 
            // ExitGoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 61);
            this.Controls.Add(this.ExitProgramm);
            this.Controls.Add(this.NoExit);
            this.Controls.Add(this.YesExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitGoLogin";
            this.Text = "Запрос на решения действия";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitGoLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitGoLogin_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YesExit;
        private System.Windows.Forms.Label NoExit;
        private System.Windows.Forms.Label ExitProgramm;
    }
}