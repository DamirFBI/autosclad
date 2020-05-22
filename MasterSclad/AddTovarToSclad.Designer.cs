namespace AutoSclad.MasterSclad
{
    partial class AddTovarToSclad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddTovarToScladTapContorl = new System.Windows.Forms.TabPage();
            this.DeleteTovarToScladTapControl = new System.Windows.Forms.TabPage();
            this.CallGoScladTapControl = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Закрыть";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddTovarToScladTapContorl);
            this.tabControl1.Controls.Add(this.DeleteTovarToScladTapControl);
            this.tabControl1.Controls.Add(this.CallGoScladTapControl);
            this.tabControl1.Location = new System.Drawing.Point(13, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 439);
            this.tabControl1.TabIndex = 1;
            // 
            // AddTovarToScladTapContorl
            // 
            this.AddTovarToScladTapContorl.Location = new System.Drawing.Point(4, 22);
            this.AddTovarToScladTapContorl.Name = "AddTovarToScladTapContorl";
            this.AddTovarToScladTapContorl.Padding = new System.Windows.Forms.Padding(3);
            this.AddTovarToScladTapContorl.Size = new System.Drawing.Size(556, 413);
            this.AddTovarToScladTapContorl.TabIndex = 0;
            this.AddTovarToScladTapContorl.Text = "Добавление на склад товара";
            this.AddTovarToScladTapContorl.UseVisualStyleBackColor = true;
            // 
            // DeleteTovarToScladTapControl
            // 
            this.DeleteTovarToScladTapControl.Location = new System.Drawing.Point(4, 22);
            this.DeleteTovarToScladTapControl.Name = "DeleteTovarToScladTapControl";
            this.DeleteTovarToScladTapControl.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteTovarToScladTapControl.Size = new System.Drawing.Size(556, 413);
            this.DeleteTovarToScladTapControl.TabIndex = 1;
            this.DeleteTovarToScladTapControl.Text = "Списание товара";
            this.DeleteTovarToScladTapControl.UseVisualStyleBackColor = true;
            // 
            // CallGoScladTapControl
            // 
            this.CallGoScladTapControl.Location = new System.Drawing.Point(4, 22);
            this.CallGoScladTapControl.Name = "CallGoScladTapControl";
            this.CallGoScladTapControl.Size = new System.Drawing.Size(556, 413);
            this.CallGoScladTapControl.TabIndex = 2;
            this.CallGoScladTapControl.Text = "Запросы работника";
            this.CallGoScladTapControl.UseVisualStyleBackColor = true;
            // 
            // AddTovarToSclad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTovarToSclad";
            this.Text = "AddTovarToSclad";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddTovarToScladTapContorl;
        private System.Windows.Forms.TabPage DeleteTovarToScladTapControl;
        private System.Windows.Forms.TabPage CallGoScladTapControl;
    }
}