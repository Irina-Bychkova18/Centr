﻿
namespace Centr
{
    partial class Добавить_расписание
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавить_расписание));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Выход_button = new System.Windows.Forms.Button();
            this.Отменить_добавление_button1 = new System.Windows.Forms.Button();
            this.Время_comboBox3 = new System.Windows.Forms.ComboBox();
            this.Дни_comboBox2 = new System.Windows.Forms.ComboBox();
            this.Курс_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Добавить_button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Отменить_добавление_button1);
            this.tabPage1.Controls.Add(this.Время_comboBox3);
            this.tabPage1.Controls.Add(this.Дни_comboBox2);
            this.tabPage1.Controls.Add(this.Курс_comboBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Добавить_button2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить запись для расписания";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(675, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выход_button.Location = new System.Drawing.Point(11, 13);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(121, 38);
            this.Выход_button.TabIndex = 92;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click);
            // 
            // Отменить_добавление_button1
            // 
            this.Отменить_добавление_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Отменить_добавление_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Отменить_добавление_button1.Location = new System.Drawing.Point(152, 333);
            this.Отменить_добавление_button1.Name = "Отменить_добавление_button1";
            this.Отменить_добавление_button1.Size = new System.Drawing.Size(203, 30);
            this.Отменить_добавление_button1.TabIndex = 126;
            this.Отменить_добавление_button1.Text = "Отменить добавление";
            this.Отменить_добавление_button1.UseVisualStyleBackColor = false;
            this.Отменить_добавление_button1.Click += new System.EventHandler(this.Отменить_добавление_button1_Click);
            // 
            // Время_comboBox3
            // 
            this.Время_comboBox3.FormattingEnabled = true;
            this.Время_comboBox3.Location = new System.Drawing.Point(468, 177);
            this.Время_comboBox3.Name = "Время_comboBox3";
            this.Время_comboBox3.Size = new System.Drawing.Size(181, 24);
            this.Время_comboBox3.TabIndex = 124;
            // 
            // Дни_comboBox2
            // 
            this.Дни_comboBox2.FormattingEnabled = true;
            this.Дни_comboBox2.Location = new System.Drawing.Point(214, 177);
            this.Дни_comboBox2.Name = "Дни_comboBox2";
            this.Дни_comboBox2.Size = new System.Drawing.Size(167, 24);
            this.Дни_comboBox2.TabIndex = 123;
            // 
            // Курс_comboBox1
            // 
            this.Курс_comboBox1.FormattingEnabled = true;
            this.Курс_comboBox1.Location = new System.Drawing.Point(214, 134);
            this.Курс_comboBox1.Name = "Курс_comboBox1";
            this.Курс_comboBox1.Size = new System.Drawing.Size(435, 24);
            this.Курс_comboBox1.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "Время:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "Дни:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 111;
            this.label1.Text = "Название курса:";
            // 
            // Добавить_button2
            // 
            this.Добавить_button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Добавить_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Добавить_button2.Location = new System.Drawing.Point(411, 333);
            this.Добавить_button2.Name = "Добавить_button2";
            this.Добавить_button2.Size = new System.Drawing.Size(219, 30);
            this.Добавить_button2.TabIndex = 109;
            this.Добавить_button2.Text = "Добавить ";
            this.Добавить_button2.UseVisualStyleBackColor = false;
            this.Добавить_button2.Click += new System.EventHandler(this.Добавить_button2_Click);
            // 
            // Добавить_расписание
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Добавить_расписание";
            this.Text = "Добавить_расписание";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.Button Отменить_добавление_button1;
        private System.Windows.Forms.ComboBox Время_comboBox3;
        private System.Windows.Forms.ComboBox Дни_comboBox2;
        private System.Windows.Forms.ComboBox Курс_comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Добавить_button2;
    }
}