namespace AutoSclad.MasterSclad
{
    partial class CallWorkmanToMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CallWorkmanTypeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.CallWorkmanStatusUseButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запросы";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 314);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Установка статуса запроса";
            // 
            // CallWorkmanTypeStatusComboBox
            // 
            this.CallWorkmanTypeStatusComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидаите, товар отправлен",
            "Ожидаите, товар отсуствует",
            "Отказоно "});
            this.CallWorkmanTypeStatusComboBox.FormattingEnabled = true;
            this.CallWorkmanTypeStatusComboBox.Items.AddRange(new object[] {
            "Выполняется, товар отправлен",
            "Ожидаите, отправка товара",
            "Ожидаите, товар отсуствует",
            "Отказоно в запросе"});
            this.CallWorkmanTypeStatusComboBox.Location = new System.Drawing.Point(286, 30);
            this.CallWorkmanTypeStatusComboBox.Name = "CallWorkmanTypeStatusComboBox";
            this.CallWorkmanTypeStatusComboBox.Size = new System.Drawing.Size(202, 21);
            this.CallWorkmanTypeStatusComboBox.TabIndex = 5;
            // 
            // CallWorkmanStatusUseButton
            // 
            this.CallWorkmanStatusUseButton.Location = new System.Drawing.Point(351, 57);
            this.CallWorkmanStatusUseButton.Name = "CallWorkmanStatusUseButton";
            this.CallWorkmanStatusUseButton.Size = new System.Drawing.Size(75, 23);
            this.CallWorkmanStatusUseButton.TabIndex = 6;
            this.CallWorkmanStatusUseButton.Text = "Установить";
            this.CallWorkmanStatusUseButton.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Валера",
            "Серый"});
            this.checkedListBox1.Location = new System.Drawing.Point(286, 99);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(141, 242);
            this.checkedListBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Работники";
            // 
            // CallWorkmanToMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.CallWorkmanStatusUseButton);
            this.Controls.Add(this.CallWorkmanTypeStatusComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CallWorkmanToMaster";
            this.Text = "CallWorkmanToMaster";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CallWorkmanToMaster_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CallWorkmanToMaster_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CallWorkmanTypeStatusComboBox;
        private System.Windows.Forms.Button CallWorkmanStatusUseButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}