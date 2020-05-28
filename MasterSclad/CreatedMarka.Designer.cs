namespace AutoSclad.MasterSclad
{
    partial class CreatedMarka
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
            this.treeViewMarka = new System.Windows.Forms.TreeView();
            this.AddMarkaToAddMarka = new System.Windows.Forms.Button();
            this.DeleteMarkaToAddMarka = new System.Windows.Forms.Button();
            this.EditMarkaToAddMarka = new System.Windows.Forms.Button();
            this.SelectMarkaToAddMarka = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchAddMarkaForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewMarka
            // 
            this.treeViewMarka.Location = new System.Drawing.Point(12, 54);
            this.treeViewMarka.Name = "treeViewMarka";
            this.treeViewMarka.Size = new System.Drawing.Size(306, 264);
            this.treeViewMarka.TabIndex = 0;
            // 
            // AddMarkaToAddMarka
            // 
            this.AddMarkaToAddMarka.Location = new System.Drawing.Point(324, 83);
            this.AddMarkaToAddMarka.Name = "AddMarkaToAddMarka";
            this.AddMarkaToAddMarka.Size = new System.Drawing.Size(75, 23);
            this.AddMarkaToAddMarka.TabIndex = 1;
            this.AddMarkaToAddMarka.Text = "Добавить";
            this.AddMarkaToAddMarka.UseVisualStyleBackColor = true;
            this.AddMarkaToAddMarka.Click += new System.EventHandler(this.AddMarkaToAddMarka_Click);
            // 
            // DeleteMarkaToAddMarka
            // 
            this.DeleteMarkaToAddMarka.Location = new System.Drawing.Point(324, 141);
            this.DeleteMarkaToAddMarka.Name = "DeleteMarkaToAddMarka";
            this.DeleteMarkaToAddMarka.Size = new System.Drawing.Size(75, 23);
            this.DeleteMarkaToAddMarka.TabIndex = 2;
            this.DeleteMarkaToAddMarka.Text = "Удалить";
            this.DeleteMarkaToAddMarka.UseVisualStyleBackColor = true;
            this.DeleteMarkaToAddMarka.Click += new System.EventHandler(this.DeleteMarkaToAddMarka_Click);
            // 
            // EditMarkaToAddMarka
            // 
            this.EditMarkaToAddMarka.Location = new System.Drawing.Point(324, 112);
            this.EditMarkaToAddMarka.Name = "EditMarkaToAddMarka";
            this.EditMarkaToAddMarka.Size = new System.Drawing.Size(75, 23);
            this.EditMarkaToAddMarka.TabIndex = 3;
            this.EditMarkaToAddMarka.Text = "Изменить";
            this.EditMarkaToAddMarka.UseVisualStyleBackColor = true;
            this.EditMarkaToAddMarka.Click += new System.EventHandler(this.EditMarkaToAddMarka_Click);
            // 
            // SelectMarkaToAddMarka
            // 
            this.SelectMarkaToAddMarka.Location = new System.Drawing.Point(57, 324);
            this.SelectMarkaToAddMarka.Name = "SelectMarkaToAddMarka";
            this.SelectMarkaToAddMarka.Size = new System.Drawing.Size(207, 44);
            this.SelectMarkaToAddMarka.TabIndex = 4;
            this.SelectMarkaToAddMarka.Text = "Выбрать";
            this.SelectMarkaToAddMarka.UseVisualStyleBackColor = true;
            this.SelectMarkaToAddMarka.Click += new System.EventHandler(this.SelectMarkaToAddMarka_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(352, 354);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(75, 23);
            this.CloseForm.TabIndex = 5;
            this.CloseForm.Text = "Закрыть";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Настройка марки товара";
            // 
            // SearchAddMarkaForm
            // 
            this.SearchAddMarkaForm.Location = new System.Drawing.Point(325, 54);
            this.SearchAddMarkaForm.Name = "SearchAddMarkaForm";
            this.SearchAddMarkaForm.Size = new System.Drawing.Size(75, 23);
            this.SearchAddMarkaForm.TabIndex = 7;
            this.SearchAddMarkaForm.Text = "Найти";
            this.SearchAddMarkaForm.UseVisualStyleBackColor = true;
            this.SearchAddMarkaForm.Click += new System.EventHandler(this.button6_Click);
            // 
            // CreatedMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 389);
            this.Controls.Add(this.SearchAddMarkaForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.SelectMarkaToAddMarka);
            this.Controls.Add(this.EditMarkaToAddMarka);
            this.Controls.Add(this.DeleteMarkaToAddMarka);
            this.Controls.Add(this.AddMarkaToAddMarka);
            this.Controls.Add(this.treeViewMarka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatedMarka";
            this.Text = "CreatedMarkaAndModel";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreatedMarka_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreatedMarka_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMarka;
        private System.Windows.Forms.Button AddMarkaToAddMarka;
        private System.Windows.Forms.Button DeleteMarkaToAddMarka;
        private System.Windows.Forms.Button EditMarkaToAddMarka;
        private System.Windows.Forms.Button SelectMarkaToAddMarka;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchAddMarkaForm;
    }
}