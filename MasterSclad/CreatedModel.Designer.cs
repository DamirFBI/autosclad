namespace AutoSclad.MasterSclad
{
    partial class CreatedModel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddModel = new System.Windows.Forms.Button();
            this.EditModel = new System.Windows.Forms.Button();
            this.DeleteModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(380, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Закрыть";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 250);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddModel
            // 
            this.AddModel.Location = new System.Drawing.Point(356, 43);
            this.AddModel.Name = "AddModel";
            this.AddModel.Size = new System.Drawing.Size(75, 23);
            this.AddModel.TabIndex = 3;
            this.AddModel.Text = "Добавить";
            this.AddModel.UseVisualStyleBackColor = true;
            this.AddModel.Click += new System.EventHandler(this.AddModel_Click);
            // 
            // EditModel
            // 
            this.EditModel.Location = new System.Drawing.Point(356, 73);
            this.EditModel.Name = "EditModel";
            this.EditModel.Size = new System.Drawing.Size(75, 23);
            this.EditModel.TabIndex = 4;
            this.EditModel.Text = "Изменить";
            this.EditModel.UseVisualStyleBackColor = true;
            // 
            // DeleteModel
            // 
            this.DeleteModel.Location = new System.Drawing.Point(356, 103);
            this.DeleteModel.Name = "DeleteModel";
            this.DeleteModel.Size = new System.Drawing.Size(75, 23);
            this.DeleteModel.TabIndex = 5;
            this.DeleteModel.Text = "Удалить";
            this.DeleteModel.UseVisualStyleBackColor = true;
            // 
            // CreatedModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 280);
            this.Controls.Add(this.DeleteModel);
            this.Controls.Add(this.EditModel);
            this.Controls.Add(this.AddModel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(445, 280);
            this.MinimumSize = new System.Drawing.Size(445, 280);
            this.Name = "CreatedModel";
            this.Text = "CreatedModel";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreatedModel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreatedModel_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddModel;
        private System.Windows.Forms.Button EditModel;
        private System.Windows.Forms.Button DeleteModel;
    }
}