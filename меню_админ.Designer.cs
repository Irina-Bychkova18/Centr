
namespace Centr
{
    partial class меню_админ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(меню_админ));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Выход_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.курсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыеЛекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видеороликиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.домашнее_задание_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНаКурсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьУченикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посещаемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.учащиесяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 702);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Меню";
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход_button.Location = new System.Drawing.Point(21, 551);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(200, 45);
            this.Выход_button.TabIndex = 98;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсыToolStripMenuItem,
            this.лекцииToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.записьНаКурсToolStripMenuItem,
            this.успеваемостьToolStripMenuItem,
            this.учащиесяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // курсыToolStripMenuItem
            // 
            this.курсыToolStripMenuItem.Name = "курсыToolStripMenuItem";
            this.курсыToolStripMenuItem.Size = new System.Drawing.Size(91, 31);
            this.курсыToolStripMenuItem.Text = "Курсы";
            this.курсыToolStripMenuItem.Click += new System.EventHandler(this.курсыToolStripMenuItem_Click);
            // 
            // лекцииToolStripMenuItem
            // 
            this.лекцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыеЛекцииToolStripMenuItem,
            this.видеороликиToolStripMenuItem,
            this.домашнее_задание_ToolStripMenuItem});
            this.лекцииToolStripMenuItem.Name = "лекцииToolStripMenuItem";
            this.лекцииToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.лекцииToolStripMenuItem.Text = "Лекции";
            this.лекцииToolStripMenuItem.Click += new System.EventHandler(this.лекцииToolStripMenuItem_Click);
            // 
            // текстовыеЛекцииToolStripMenuItem
            // 
            this.текстовыеЛекцииToolStripMenuItem.Name = "текстовыеЛекцииToolStripMenuItem";
            this.текстовыеЛекцииToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.текстовыеЛекцииToolStripMenuItem.Text = "Текстовые лекции";
            this.текстовыеЛекцииToolStripMenuItem.Click += new System.EventHandler(this.текстовыеЛекцииToolStripMenuItem_Click);
            // 
            // видеороликиToolStripMenuItem
            // 
            this.видеороликиToolStripMenuItem.Name = "видеороликиToolStripMenuItem";
            this.видеороликиToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.видеороликиToolStripMenuItem.Text = "Видеоролики";
            this.видеороликиToolStripMenuItem.Click += new System.EventHandler(this.видеороликиToolStripMenuItem_Click);
            // 
            // домашнее_задание_ToolStripMenuItem
            // 
            this.домашнее_задание_ToolStripMenuItem.Name = "домашнее_задание_ToolStripMenuItem";
            this.домашнее_задание_ToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.домашнее_задание_ToolStripMenuItem.Text = "Домашнее задание";
            this.домашнее_задание_ToolStripMenuItem.Click += new System.EventHandler(this.домашнее_задание_ToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(149, 31);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеЗанятийToolStripMenuItem});
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(147, 31);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // расписаниеЗанятийToolStripMenuItem
            // 
            this.расписаниеЗанятийToolStripMenuItem.Name = "расписаниеЗанятийToolStripMenuItem";
            this.расписаниеЗанятийToolStripMenuItem.Size = new System.Drawing.Size(305, 32);
            this.расписаниеЗанятийToolStripMenuItem.Text = "Расписание занятий";
            this.расписаниеЗанятийToolStripMenuItem.Click += new System.EventHandler(this.расписаниеЗанятийToolStripMenuItem_Click);
            // 
            // записьНаКурсToolStripMenuItem
            // 
            this.записьНаКурсToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записиToolStripMenuItem,
            this.записатьУченикаToolStripMenuItem});
            this.записьНаКурсToolStripMenuItem.Name = "записьНаКурсToolStripMenuItem";
            this.записьНаКурсToolStripMenuItem.Size = new System.Drawing.Size(182, 31);
            this.записьНаКурсToolStripMenuItem.Text = "Записи на курс";
            this.записьНаКурсToolStripMenuItem.Click += new System.EventHandler(this.записьНаКурсToolStripMenuItem_Click);
            // 
            // записиToolStripMenuItem
            // 
            this.записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            this.записиToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.записиToolStripMenuItem.Text = "Записи ";
            this.записиToolStripMenuItem.Click += new System.EventHandler(this.записиToolStripMenuItem_Click);
            // 
            // записатьУченикаToolStripMenuItem
            // 
            this.записатьУченикаToolStripMenuItem.Name = "записатьУченикаToolStripMenuItem";
            this.записатьУченикаToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.записатьУченикаToolStripMenuItem.Text = "Записать ученика";
            this.записатьУченикаToolStripMenuItem.Click += new System.EventHandler(this.записатьУченикаToolStripMenuItem_Click);
            // 
            // успеваемостьToolStripMenuItem
            // 
            this.успеваемостьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посещаемостьToolStripMenuItem,
            this.успеваемостьToolStripMenuItem1});
            this.успеваемостьToolStripMenuItem.Name = "успеваемостьToolStripMenuItem";
            this.успеваемостьToolStripMenuItem.Size = new System.Drawing.Size(168, 31);
            this.успеваемостьToolStripMenuItem.Text = "Успеваемость";
            // 
            // посещаемостьToolStripMenuItem
            // 
            this.посещаемостьToolStripMenuItem.Name = "посещаемостьToolStripMenuItem";
            this.посещаемостьToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.посещаемостьToolStripMenuItem.Text = "Посещаемость";
            this.посещаемостьToolStripMenuItem.Click += new System.EventHandler(this.посещаемостьToolStripMenuItem_Click);
            // 
            // успеваемостьToolStripMenuItem1
            // 
            this.успеваемостьToolStripMenuItem1.Name = "успеваемостьToolStripMenuItem1";
            this.успеваемостьToolStripMenuItem1.Size = new System.Drawing.Size(250, 32);
            this.успеваемостьToolStripMenuItem1.Text = "Успеваемость";
            this.успеваемостьToolStripMenuItem1.Click += new System.EventHandler(this.успеваемостьToolStripMenuItem1_Click);
            // 
            // учащиесяToolStripMenuItem
            // 
            this.учащиесяToolStripMenuItem.Name = "учащиесяToolStripMenuItem";
            this.учащиесяToolStripMenuItem.Size = new System.Drawing.Size(131, 31);
            this.учащиесяToolStripMenuItem.Text = "Учащиеся";
            this.учащиесяToolStripMenuItem.Click += new System.EventHandler(this.учащиесяToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // меню_админ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "меню_админ";
            this.Text = "меню";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem курсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лекцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыеЛекцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видеороликиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem домашнее_задание_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеЗанятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьНаКурсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посещаемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem учащиесяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатьУченикаToolStripMenuItem;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}