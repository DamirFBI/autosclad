namespace AutoSclad.ServiceDialog
{
    partial class DeleteYesNo
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
            this.YesDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NoDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YesDeleteButton
            // 
            this.YesDeleteButton.Location = new System.Drawing.Point(29, 43);
            this.YesDeleteButton.Name = "YesDeleteButton";
            this.YesDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.YesDeleteButton.TabIndex = 0;
            this.YesDeleteButton.Text = "Да";
            this.YesDeleteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы действительно хотите удалить?";
            // 
            // NoDeleteButton
            // 
            this.NoDeleteButton.Location = new System.Drawing.Point(143, 43);
            this.NoDeleteButton.Name = "NoDeleteButton";
            this.NoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.NoDeleteButton.TabIndex = 2;
            this.NoDeleteButton.Text = "Нет";
            this.NoDeleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 80);
            this.Controls.Add(this.NoDeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YesDeleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(250, 80);
            this.MinimumSize = new System.Drawing.Size(250, 80);
            this.Name = "DeleteYesNo";
            this.Text = "DeleteYesNo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteYesNo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteYesNo_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesDeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NoDeleteButton;
    }
}