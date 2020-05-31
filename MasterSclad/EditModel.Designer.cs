namespace AutoSclad.MasterSclad
{
    partial class EditModel
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
            this.ExitForm = new System.Windows.Forms.Label();
            this.EditModelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditModelToMarkaTextBox = new System.Windows.Forms.TextBox();
            this.EditOpisanie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OkEditModelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitForm
            // 
            this.ExitForm.AutoSize = true;
            this.ExitForm.Location = new System.Drawing.Point(317, 268);
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(51, 13);
            this.ExitForm.TabIndex = 0;
            this.ExitForm.Text = "Закрыть";
            this.ExitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // EditModelTextBox
            // 
            this.EditModelTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditModelTextBox.Location = new System.Drawing.Point(12, 29);
            this.EditModelTextBox.Name = "EditModelTextBox";
            this.EditModelTextBox.Size = new System.Drawing.Size(167, 22);
            this.EditModelTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Марка";
            // 
            // EditModelToMarkaTextBox
            // 
            this.EditModelToMarkaTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditModelToMarkaTextBox.Location = new System.Drawing.Point(185, 29);
            this.EditModelToMarkaTextBox.Name = "EditModelToMarkaTextBox";
            this.EditModelToMarkaTextBox.Size = new System.Drawing.Size(183, 22);
            this.EditModelToMarkaTextBox.TabIndex = 4;
            // 
            // EditOpisanie
            // 
            this.EditOpisanie.Location = new System.Drawing.Point(12, 74);
            this.EditOpisanie.Multiline = true;
            this.EditOpisanie.Name = "EditOpisanie";
            this.EditOpisanie.Size = new System.Drawing.Size(356, 183);
            this.EditOpisanie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Подробности";
            // 
            // OkEditModelButton
            // 
            this.OkEditModelButton.Location = new System.Drawing.Point(12, 263);
            this.OkEditModelButton.Name = "OkEditModelButton";
            this.OkEditModelButton.Size = new System.Drawing.Size(75, 23);
            this.OkEditModelButton.TabIndex = 7;
            this.OkEditModelButton.Text = "Изменить";
            this.OkEditModelButton.UseVisualStyleBackColor = true;
            this.OkEditModelButton.Click += new System.EventHandler(this.OkEditModelButton_Click);
            // 
            // EditModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.OkEditModelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditOpisanie);
            this.Controls.Add(this.EditModelToMarkaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditModelTextBox);
            this.Controls.Add(this.ExitForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(380, 290);
            this.MinimumSize = new System.Drawing.Size(380, 290);
            this.Name = "EditModel";
            this.Text = "EditModel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitForm;
        private System.Windows.Forms.TextBox EditModelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditModelToMarkaTextBox;
        private System.Windows.Forms.TextBox EditOpisanie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OkEditModelButton;
    }
}