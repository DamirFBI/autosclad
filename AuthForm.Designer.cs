namespace AutoSclad
{
    partial class AuthForm
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel8 = new System.Windows.Forms.Label();
            this.materialLabel13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.enterButton = new MaterialSkin.Controls.MaterialButton();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 98);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(254, 29);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(9, 78);
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(47, 17);
            this.materialLabel8.TabIndex = 19;
            this.materialLabel8.Text = "Логин";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(9, 134);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(36, 0, 3, 0);
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(57, 17);
            this.materialLabel13.TabIndex = 20;
            this.materialLabel13.Text = "Пароль";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(12, 154);
            this.textBox13.Margin = new System.Windows.Forms.Padding(36, 3, 3, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.PasswordChar = '•';
            this.textBox13.Size = new System.Drawing.Size(254, 29);
            this.textBox13.TabIndex = 21;
            // 
            // enterButton
            // 
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enterButton.Depth = 0;
            this.enterButton.DrawShadows = true;
            this.enterButton.HighEmphasis = true;
            this.enterButton.Icon = null;
            this.enterButton.Location = new System.Drawing.Point(12, 189);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(69, 36);
            this.enterButton.TabIndex = 22;
            this.enterButton.Text = "Войти";
            this.enterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.enterButton.UseAccentColor = false;
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // kZTSHDataSet
            // 
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.CurrentChanged += new System.EventHandler(this.userBindingSource_CurrentChanged);
            // 
            // userTableAdapter
            // 
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 241);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.textBox13);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.RegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label materialLabel13;
        private System.Windows.Forms.TextBox textBox13;
        private MaterialSkin.Controls.MaterialButton enterButton;
        private System.Windows.Forms.Label materialLabel8;
    }
}