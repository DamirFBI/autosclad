namespace AutoSclad
{
    partial class RegisterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.TypeUser = new System.Windows.Forms.GroupBox();
            this.Master = new System.Windows.Forms.RadioButton();
            this.WorkMan = new System.Windows.Forms.RadioButton();
            this.TypeUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(59, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вид пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(406, 171);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 13);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выйти";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Location = new System.Drawing.Point(179, 148);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 23);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(25, 30);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(109, 22);
            this.userNameField.TabIndex = 8;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(25, 85);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(109, 22);
            this.LoginText.TabIndex = 9;
            this.LoginText.Enter += new System.EventHandler(this.LoginText_Enter);
            this.LoginText.Leave += new System.EventHandler(this.LoginText_Leave);
            // 
            // userSurnameField
            // 
            this.userSurnameField.Location = new System.Drawing.Point(317, 30);
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(109, 22);
            this.userSurnameField.TabIndex = 11;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(317, 85);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(109, 22);
            this.PassText.TabIndex = 12;
            this.PassText.Enter += new System.EventHandler(this.PassText_Enter);
            this.PassText.Leave += new System.EventHandler(this.PassText_Leave);
            // 
            // TypeUser
            // 
            this.TypeUser.Controls.Add(this.WorkMan);
            this.TypeUser.Controls.Add(this.Master);
            this.TypeUser.Location = new System.Drawing.Point(179, 84);
            this.TypeUser.Name = "TypeUser";
            this.TypeUser.Size = new System.Drawing.Size(100, 58);
            this.TypeUser.TabIndex = 13;
            this.TypeUser.TabStop = false;
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Master.Location = new System.Drawing.Point(0, 5);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(85, 17);
            this.Master.TabIndex = 0;
            this.Master.Text = "Кладовщик";
            this.Master.UseVisualStyleBackColor = true;
            this.Master.CheckedChanged += new System.EventHandler(this.Master_CheckedChanged);
            // 
            // WorkMan
            // 
            this.WorkMan.AutoSize = true;
            this.WorkMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkMan.Location = new System.Drawing.Point(0, 28);
            this.WorkMan.Name = "WorkMan";
            this.WorkMan.Size = new System.Drawing.Size(76, 17);
            this.WorkMan.TabIndex = 1;
            this.WorkMan.Text = "Работник";
            this.WorkMan.UseVisualStyleBackColor = true;
            this.WorkMan.CheckedChanged += new System.EventHandler(this.WorkMan_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 196);
            this.Controls.Add(this.TypeUser);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.userSurnameField);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.TypeUser.ResumeLayout(false);
            this.TypeUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.GroupBox TypeUser;
        private System.Windows.Forms.RadioButton WorkMan;
        private System.Windows.Forms.RadioButton Master;
    }
}