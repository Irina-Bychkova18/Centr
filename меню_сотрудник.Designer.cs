﻿
namespace Centr
{
    partial class меню_сотрудник
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(меню_сотрудник));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Выход_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.курсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыеЛекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видеороликиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыИЭкзаменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посещаемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 466);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Меню";
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выход_button.Location = new System.Drawing.Point(7, 373);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(121, 38);
            this.Выход_button.TabIndex = 46;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсыToolStripMenuItem,
            this.лекцииToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.успеваемостьToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // курсыToolStripMenuItem
            // 
            this.курсыToolStripMenuItem.Name = "курсыToolStripMenuItem";
            this.курсыToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.курсыToolStripMenuItem.Text = "Курсы";
            this.курсыToolStripMenuItem.Click += new System.EventHandler(this.курсыToolStripMenuItem_Click);
            // 
            // лекцииToolStripMenuItem
            // 
            this.лекцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыеЛекцииToolStripMenuItem,
            this.видеороликиToolStripMenuItem,
            this.тестыИЭкзаменыToolStripMenuItem});
            this.лекцииToolStripMenuItem.Name = "лекцииToolStripMenuItem";
            this.лекцииToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.лекцииToolStripMenuItem.Text = "Лекции";
            // 
            // текстовыеЛекцииToolStripMenuItem
            // 
            this.текстовыеЛекцииToolStripMenuItem.Name = "текстовыеЛекцииToolStripMenuItem";
            this.текстовыеЛекцииToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.текстовыеЛекцииToolStripMenuItem.Text = "Текстовые лекции";
            this.текстовыеЛекцииToolStripMenuItem.Click += new System.EventHandler(this.текстовыеЛекцииToolStripMenuItem_Click);
            // 
            // видеороликиToolStripMenuItem
            // 
            this.видеороликиToolStripMenuItem.Name = "видеороликиToolStripMenuItem";
            this.видеороликиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.видеороликиToolStripMenuItem.Text = "Видеоролики";
            // 
            // тестыИЭкзаменыToolStripMenuItem
            // 
            this.тестыИЭкзаменыToolStripMenuItem.Name = "тестыИЭкзаменыToolStripMenuItem";
            this.тестыИЭкзаменыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.тестыИЭкзаменыToolStripMenuItem.Text = "Тесты и экзамены";
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеЗанятийToolStripMenuItem});
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            // 
            // расписаниеЗанятийToolStripMenuItem
            // 
            this.расписаниеЗанятийToolStripMenuItem.Name = "расписаниеЗанятийToolStripMenuItem";
            this.расписаниеЗанятийToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.расписаниеЗанятийToolStripMenuItem.Text = "Расписание занятий";
            this.расписаниеЗанятийToolStripMenuItem.Click += new System.EventHandler(this.расписаниеЗанятийToolStripMenuItem_Click);
            // 
            // успеваемостьToolStripMenuItem
            // 
            this.успеваемостьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посещаемостьToolStripMenuItem,
            this.успеваемостьToolStripMenuItem1});
            this.успеваемостьToolStripMenuItem.Name = "успеваемостьToolStripMenuItem";
            this.успеваемостьToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.успеваемостьToolStripMenuItem.Text = "Успеваемость";
            // 
            // посещаемостьToolStripMenuItem
            // 
            this.посещаемостьToolStripMenuItem.Name = "посещаемостьToolStripMenuItem";
            this.посещаемостьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.посещаемостьToolStripMenuItem.Text = "Посещаемость";
            // 
            // успеваемостьToolStripMenuItem1
            // 
            this.успеваемостьToolStripMenuItem1.Name = "успеваемостьToolStripMenuItem1";
            this.успеваемостьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.успеваемостьToolStripMenuItem1.Text = "Успеваемость";
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            // 
            // меню_сотрудник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "меню_сотрудник";
            this.Text = "меню_сотрудник";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem курсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лекцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыеЛекцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видеороликиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестыИЭкзаменыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеЗанятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посещаемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
    }
}