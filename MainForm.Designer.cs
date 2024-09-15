namespace AutoSclad
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникПоставщиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникКатегорийТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникЕденицИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.визуализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наличиеТовараНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемТовараНаСкадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отгрузкаТовараСоСкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвентаризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отборToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отгрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.визуализацияToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникТоваровToolStripMenuItem,
            this.справочникПоставщиковToolStripMenuItem,
            this.справочникКатегорийТоваровToolStripMenuItem,
            this.справочникЕденицИзмеренияToolStripMenuItem,
            this.справочникПользователейToolStripMenuItem,
            this.справочникСкладToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.базаДанныхToolStripMenuItem.Text = "Справочники";
            // 
            // справочникТоваровToolStripMenuItem
            // 
            this.справочникТоваровToolStripMenuItem.Name = "справочникТоваровToolStripMenuItem";
            this.справочникТоваровToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.справочникТоваровToolStripMenuItem.Text = "Справочник товаров";
            this.справочникТоваровToolStripMenuItem.Click += new System.EventHandler(this.справочникТоваровToolStripMenuItem_Click);
            // 
            // справочникПоставщиковToolStripMenuItem
            // 
            this.справочникПоставщиковToolStripMenuItem.Name = "справочникПоставщиковToolStripMenuItem";
            this.справочникПоставщиковToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.справочникПоставщиковToolStripMenuItem.Text = "Справочник поставщиков";
            this.справочникПоставщиковToolStripMenuItem.Click += new System.EventHandler(this.справочникПоставщиковToolStripMenuItem_Click);
            // 
            // справочникКатегорийТоваровToolStripMenuItem
            // 
            this.справочникКатегорийТоваровToolStripMenuItem.Name = "справочникКатегорийТоваровToolStripMenuItem";
            this.справочникКатегорийТоваровToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.справочникКатегорийТоваровToolStripMenuItem.Text = "Справочник марок товаров";
            this.справочникКатегорийТоваровToolStripMenuItem.Click += new System.EventHandler(this.справочникКатегорийТоваровToolStripMenuItem_Click);
            // 
            // справочникПользователейToolStripMenuItem
            // 
            this.справочникПользователейToolStripMenuItem.Name = "справочникПользователейToolStripMenuItem";
            this.справочникПользователейToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.справочникПользователейToolStripMenuItem.Text = "Справочник пользователей";
            this.справочникПользователейToolStripMenuItem.Click += new System.EventHandler(this.справочникПользователейToolStripMenuItem_Click);
            // 
            // справочникЕденицИзмеренияToolStripMenuItem
            // 
            this.справочникЕденицИзмеренияToolStripMenuItem.Name = "справочникЕденицИзмеренияToolStripMenuItem";
            this.справочникЕденицИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.справочникЕденицИзмеренияToolStripMenuItem.Text = "Справочник моделей товаров";
            this.справочникЕденицИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.справочникЕденицИзмеренияToolStripMenuItem_Click);
            // 
            // справочникСкладToolStripMenuItem
            // 
            this.справочникСкладToolStripMenuItem.Name = "справочникСкладToolStripMenuItem";
            this.справочникСкладToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.справочникСкладToolStripMenuItem.Text = "Справочник Склад";
            this.справочникСкладToolStripMenuItem.Click += new System.EventHandler(this.справочникСкладToolStripMenuItem_Click);
            // 
            // визуализацияToolStripMenuItem
            // 
            this.визуализацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наличиеТовараНаСкладеToolStripMenuItem,
            this.приемТовараНаСкадToolStripMenuItem,
            this.отгрузкаТовараСоСкладаToolStripMenuItem});
            this.визуализацияToolStripMenuItem.Name = "визуализацияToolStripMenuItem";
            this.визуализацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.визуализацияToolStripMenuItem.Text = "Отчеты";
            // 
            // наличиеТовараНаСкладеToolStripMenuItem
            // 
            this.наличиеТовараНаСкладеToolStripMenuItem.Name = "наличиеТовараНаСкладеToolStripMenuItem";
            this.наличиеТовараНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.наличиеТовараНаСкладеToolStripMenuItem.Text = "Наличие товара на складе";
            // 
            // приемТовараНаСкадToolStripMenuItem
            // 
            this.приемТовараНаСкадToolStripMenuItem.Name = "приемТовараНаСкадToolStripMenuItem";
            this.приемТовараНаСкадToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.приемТовараНаСкадToolStripMenuItem.Text = "Прием товара на склад";
            // 
            // отгрузкаТовараСоСкладаToolStripMenuItem
            // 
            this.отгрузкаТовараСоСкладаToolStripMenuItem.Name = "отгрузкаТовараСоСкладаToolStripMenuItem";
            this.отгрузкаТовараСоСкладаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.отгрузкаТовараСоСкладаToolStripMenuItem.Text = "Отгрузка товара со склада";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приемToolStripMenuItem,
            this.инвентаризацияToolStripMenuItem,
            this.размещениеToolStripMenuItem,
            this.отборToolStripMenuItem,
            this.отгрузкаToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // приемToolStripMenuItem
            // 
            this.приемToolStripMenuItem.Name = "приемToolStripMenuItem";
            this.приемToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.приемToolStripMenuItem.Text = "Прием";
            // 
            // инвентаризацияToolStripMenuItem
            // 
            this.инвентаризацияToolStripMenuItem.Name = "инвентаризацияToolStripMenuItem";
            this.инвентаризацияToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.инвентаризацияToolStripMenuItem.Text = "Инвентаризация";
            // 
            // размещениеToolStripMenuItem
            // 
            this.размещениеToolStripMenuItem.Name = "размещениеToolStripMenuItem";
            this.размещениеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.размещениеToolStripMenuItem.Text = "Размещение";
            // 
            // отборToolStripMenuItem
            // 
            this.отборToolStripMenuItem.Name = "отборToolStripMenuItem";
            this.отборToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.отборToolStripMenuItem.Text = "Отбор";
            // 
            // отгрузкаToolStripMenuItem
            // 
            this.отгрузкаToolStripMenuItem.Name = "отгрузкаToolStripMenuItem";
            this.отгрузкаToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.отгрузкаToolStripMenuItem.Text = "Отгрузка";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникПоставщиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникКатегорийТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникЕденицИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникСкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem визуализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наличиеТовараНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемТовараНаСкадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отгрузкаТовараСоСкладаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инвентаризацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отборToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отгрузкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
    }
}