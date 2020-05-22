namespace AutoSclad.Workman
{
    partial class Workpanelman
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
            this.Work = new System.Windows.Forms.Label();
            this.WorkManName = new System.Windows.Forms.Label();
            this.ExitLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NameWorkName = new System.Windows.Forms.Label();
            this.NameWorkmanLoging = new System.Windows.Forms.Label();
            this.TableCallToSclad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Work
            // 
            this.Work.AutoSize = true;
            this.Work.Location = new System.Drawing.Point(12, 9);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(56, 13);
            this.Work.TabIndex = 1;
            this.Work.Text = "Рабочий:";
            // 
            // WorkManName
            // 
            this.WorkManName.AutoSize = true;
            this.WorkManName.Location = new System.Drawing.Point(72, 9);
            this.WorkManName.Name = "WorkManName";
            this.WorkManName.Size = new System.Drawing.Size(0, 13);
            this.WorkManName.TabIndex = 2;
            // 
            // ExitLogin
            // 
            this.ExitLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLogin.ForeColor = System.Drawing.Color.Red;
            this.ExitLogin.Location = new System.Drawing.Point(180, 215);
            this.ExitLogin.Name = "ExitLogin";
            this.ExitLogin.Size = new System.Drawing.Size(75, 23);
            this.ExitLogin.TabIndex = 3;
            this.ExitLogin.Text = "Выйти";
            this.ExitLogin.UseVisualStyleBackColor = true;
            this.ExitLogin.Click += new System.EventHandler(this.ExitLogin_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Запросить со склада";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameWorkName
            // 
            this.NameWorkName.AutoSize = true;
            this.NameWorkName.Location = new System.Drawing.Point(75, 9);
            this.NameWorkName.Name = "NameWorkName";
            this.NameWorkName.Size = new System.Drawing.Size(0, 13);
            this.NameWorkName.TabIndex = 5;
            // 
            // NameWorkmanLoging
            // 
            this.NameWorkmanLoging.AutoSize = true;
            this.NameWorkmanLoging.Location = new System.Drawing.Point(75, 8);
            this.NameWorkmanLoging.Name = "NameWorkmanLoging";
            this.NameWorkmanLoging.Size = new System.Drawing.Size(0, 13);
            this.NameWorkmanLoging.TabIndex = 6;
            // 
            // TableCallToSclad
            // 
            this.TableCallToSclad.FormattingEnabled = true;
            this.TableCallToSclad.Items.AddRange(new object[] {
            "Jndtn"});
            this.TableCallToSclad.Location = new System.Drawing.Point(13, 55);
            this.TableCallToSclad.Name = "TableCallToSclad";
            this.TableCallToSclad.Size = new System.Drawing.Size(161, 173);
            this.TableCallToSclad.TabIndex = 7;
            // 
            // Workpanelman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 250);
            this.Controls.Add(this.TableCallToSclad);
            this.Controls.Add(this.NameWorkmanLoging);
            this.Controls.Add(this.NameWorkName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitLogin);
            this.Controls.Add(this.WorkManName);
            this.Controls.Add(this.Work);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(265, 250);
            this.MinimumSize = new System.Drawing.Size(265, 250);
            this.Name = "Workpanelman";
            this.Text = "Рабочий";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Workpanelman_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Workpanelman_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Work;
        private System.Windows.Forms.Label WorkManName;
        private System.Windows.Forms.Button ExitLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameWorkName;
        private System.Windows.Forms.Label NameWorkmanLoging;
        private System.Windows.Forms.ListBox TableCallToSclad;
    }
}