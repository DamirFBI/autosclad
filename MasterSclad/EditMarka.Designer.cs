namespace AutoSclad.MasterSclad
{
    partial class EditMarka
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
            this.CloseEditMarakForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditMarkaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseEditMarakForm
            // 
            this.CloseEditMarakForm.AutoSize = true;
            this.CloseEditMarakForm.Location = new System.Drawing.Point(208, 55);
            this.CloseEditMarakForm.Name = "CloseEditMarakForm";
            this.CloseEditMarakForm.Size = new System.Drawing.Size(51, 13);
            this.CloseEditMarakForm.TabIndex = 0;
            this.CloseEditMarakForm.Text = "Закрыть";
            this.CloseEditMarakForm.Click += new System.EventHandler(this.CloseEditMarakForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 2;
            // 
            // EditMarkaButton
            // 
            this.EditMarkaButton.Location = new System.Drawing.Point(12, 50);
            this.EditMarkaButton.Name = "EditMarkaButton";
            this.EditMarkaButton.Size = new System.Drawing.Size(86, 23);
            this.EditMarkaButton.TabIndex = 3;
            this.EditMarkaButton.Text = "Применить";
            this.EditMarkaButton.UseVisualStyleBackColor = true;
            // 
            // EditMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 80);
            this.Controls.Add(this.EditMarkaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseEditMarakForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(270, 80);
            this.MinimumSize = new System.Drawing.Size(270, 80);
            this.Name = "EditMarka";
            this.Text = "EditMarka";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditMarka_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditMarka_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseEditMarakForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EditMarkaButton;
    }
}