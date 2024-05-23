
namespace Centr
{
    partial class Личный_кабинет
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Личный_кабинет));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Телефон_родителей_textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Квартира_comboBox2 = new System.Windows.Forms.ComboBox();
            this.Дом_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Улица_comboBox4 = new System.Windows.Forms.ComboBox();
            this.Город_comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Дата_рождения_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Курсы_textBox6 = new System.Windows.Forms.TextBox();
            this.Пароль_textBox5 = new System.Windows.Forms.TextBox();
            this.Логин_textBox4 = new System.Windows.Forms.TextBox();
            this.Номер_телефона_textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ФИОtextBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Завершить_настоящий_курс_button6 = new System.Windows.Forms.Button();
            this.Записаться_button5 = new System.Windows.Forms.Button();
            this.Изменить_данные_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Выход_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 702);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Телефон_родителей_textBox1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Квартира_comboBox2);
            this.tabPage1.Controls.Add(this.Дом_comboBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.Улица_comboBox4);
            this.tabPage1.Controls.Add(this.Город_comboBox3);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Дата_рождения_dateTimePicker1);
            this.tabPage1.Controls.Add(this.Курсы_textBox6);
            this.tabPage1.Controls.Add(this.Пароль_textBox5);
            this.tabPage1.Controls.Add(this.Логин_textBox4);
            this.tabPage1.Controls.Add(this.Номер_телефона_textBox3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ФИОtextBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Завершить_настоящий_курс_button6);
            this.tabPage1.Controls.Add(this.Записаться_button5);
            this.tabPage1.Controls.Add(this.Изменить_данные_button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личный кабинет";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(648, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 58);
            this.checkBox1.TabIndex = 130;
            this.checkBox1.Text = "Моей улицы нет \r\nв списке";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 129;
            this.label6.Text = "Логин:";
            // 
            // Телефон_родителей_textBox1
            // 
            this.Телефон_родителей_textBox1.Location = new System.Drawing.Point(197, 224);
            this.Телефон_родителей_textBox1.Name = "Телефон_родителей_textBox1";
            this.Телефон_родителей_textBox1.Size = new System.Drawing.Size(153, 34);
            this.Телефон_родителей_textBox1.TabIndex = 128;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 54);
            this.label10.TabIndex = 127;
            this.label10.Text = "Телефон \r\nродителей:";
            // 
            // Квартира_comboBox2
            // 
            this.Квартира_comboBox2.FormattingEnabled = true;
            this.Квартира_comboBox2.Location = new System.Drawing.Point(481, 185);
            this.Квартира_comboBox2.Name = "Квартира_comboBox2";
            this.Квартира_comboBox2.Size = new System.Drawing.Size(159, 34);
            this.Квартира_comboBox2.TabIndex = 126;
            // 
            // Дом_comboBox1
            // 
            this.Дом_comboBox1.FormattingEnabled = true;
            this.Дом_comboBox1.Location = new System.Drawing.Point(197, 185);
            this.Дом_comboBox1.Name = "Дом_comboBox1";
            this.Дом_comboBox1.Size = new System.Drawing.Size(153, 34);
            this.Дом_comboBox1.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 27);
            this.label9.TabIndex = 124;
            this.label9.Text = "Квартира:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 27);
            this.label11.TabIndex = 123;
            this.label11.Text = "Дом:";
            // 
            // Улица_comboBox4
            // 
            this.Улица_comboBox4.FormattingEnabled = true;
            this.Улица_comboBox4.Location = new System.Drawing.Point(481, 149);
            this.Улица_comboBox4.Name = "Улица_comboBox4";
            this.Улица_comboBox4.Size = new System.Drawing.Size(159, 34);
            this.Улица_comboBox4.TabIndex = 121;
            // 
            // Город_comboBox3
            // 
            this.Город_comboBox3.FormattingEnabled = true;
            this.Город_comboBox3.Location = new System.Drawing.Point(197, 149);
            this.Город_comboBox3.Name = "Город_comboBox3";
            this.Город_comboBox3.Size = new System.Drawing.Size(153, 34);
            this.Город_comboBox3.TabIndex = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 27);
            this.label13.TabIndex = 118;
            this.label13.Text = "Улица:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 27);
            this.label14.TabIndex = 117;
            this.label14.Text = "Город:";
            // 
            // Дата_рождения_dateTimePicker1
            // 
            this.Дата_рождения_dateTimePicker1.Location = new System.Drawing.Point(197, 110);
            this.Дата_рождения_dateTimePicker1.Name = "Дата_рождения_dateTimePicker1";
            this.Дата_рождения_dateTimePicker1.Size = new System.Drawing.Size(153, 34);
            this.Дата_рождения_dateTimePicker1.TabIndex = 108;
            // 
            // Курсы_textBox6
            // 
            this.Курсы_textBox6.Enabled = false;
            this.Курсы_textBox6.Location = new System.Drawing.Point(195, 354);
            this.Курсы_textBox6.Name = "Курсы_textBox6";
            this.Курсы_textBox6.Size = new System.Drawing.Size(445, 34);
            this.Курсы_textBox6.TabIndex = 107;
            // 
            // Пароль_textBox5
            // 
            this.Пароль_textBox5.Location = new System.Drawing.Point(481, 264);
            this.Пароль_textBox5.Name = "Пароль_textBox5";
            this.Пароль_textBox5.Size = new System.Drawing.Size(159, 34);
            this.Пароль_textBox5.TabIndex = 106;
            // 
            // Логин_textBox4
            // 
            this.Логин_textBox4.Location = new System.Drawing.Point(197, 264);
            this.Логин_textBox4.Name = "Логин_textBox4";
            this.Логин_textBox4.Size = new System.Drawing.Size(153, 34);
            this.Логин_textBox4.TabIndex = 105;
            // 
            // Номер_телефона_textBox3
            // 
            this.Номер_телефона_textBox3.Location = new System.Drawing.Point(481, 110);
            this.Номер_телефона_textBox3.Name = "Номер_телефона_textBox3";
            this.Номер_телефона_textBox3.Size = new System.Drawing.Size(159, 34);
            this.Номер_телефона_textBox3.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 27);
            this.label8.TabIndex = 102;
            this.label8.Text = "Курсы:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 27);
            this.label7.TabIndex = 101;
            this.label7.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 27);
            this.label5.TabIndex = 99;
            this.label5.Text = "Номер телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 27);
            this.label4.TabIndex = 98;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 97;
            this.label3.Text = "ФИО:";
            // 
            // ФИОtextBox1
            // 
            this.ФИОtextBox1.Location = new System.Drawing.Point(197, 73);
            this.ФИОtextBox1.Name = "ФИОtextBox1";
            this.ФИОtextBox1.Size = new System.Drawing.Size(443, 34);
            this.ФИОtextBox1.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // Завершить_настоящий_курс_button6
            // 
            this.Завершить_настоящий_курс_button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Завершить_настоящий_курс_button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Завершить_настоящий_курс_button6.Location = new System.Drawing.Point(416, 384);
            this.Завершить_настоящий_курс_button6.Name = "Завершить_настоящий_курс_button6";
            this.Завершить_настоящий_курс_button6.Size = new System.Drawing.Size(224, 31);
            this.Завершить_настоящий_курс_button6.TabIndex = 46;
            this.Завершить_настоящий_курс_button6.Text = "Завершить настоящий курс";
            this.Завершить_настоящий_курс_button6.UseVisualStyleBackColor = false;
            this.Завершить_настоящий_курс_button6.Click += new System.EventHandler(this.Завершить_настоящий_курс_button6_Click);
            // 
            // Записаться_button5
            // 
            this.Записаться_button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Записаться_button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Записаться_button5.Location = new System.Drawing.Point(195, 384);
            this.Записаться_button5.Name = "Записаться_button5";
            this.Записаться_button5.Size = new System.Drawing.Size(153, 31);
            this.Записаться_button5.TabIndex = 45;
            this.Записаться_button5.Text = "Записаться";
            this.Записаться_button5.UseVisualStyleBackColor = false;
            this.Записаться_button5.Click += new System.EventHandler(this.Записаться_button5_Click);
            // 
            // Изменить_данные_button1
            // 
            this.Изменить_данные_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Изменить_данные_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Изменить_данные_button1.Location = new System.Drawing.Point(197, 305);
            this.Изменить_данные_button1.Name = "Изменить_данные_button1";
            this.Изменить_данные_button1.Size = new System.Drawing.Size(443, 31);
            this.Изменить_данные_button1.TabIndex = 41;
            this.Изменить_данные_button1.Text = "Изменить данные";
            this.Изменить_данные_button1.UseVisualStyleBackColor = false;
            this.Изменить_данные_button1.Click += new System.EventHandler(this.Изменить_данные_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Информация обо мне:";
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход_button.Location = new System.Drawing.Point(9, 9);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(200, 45);
            this.Выход_button.TabIndex = 131;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            // 
            // Личный_кабинет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "Личный_кабинет";
            this.Text = "Личный_кабинет";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Завершить_настоящий_курс_button6;
        private System.Windows.Forms.Button Записаться_button5;
        private System.Windows.Forms.Button Изменить_данные_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker Дата_рождения_dateTimePicker1;
        private System.Windows.Forms.TextBox Курсы_textBox6;
        private System.Windows.Forms.TextBox Пароль_textBox5;
        private System.Windows.Forms.TextBox Логин_textBox4;
        private System.Windows.Forms.TextBox Номер_телефона_textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ФИОtextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Телефон_родителей_textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Квартира_comboBox2;
        private System.Windows.Forms.ComboBox Дом_comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Улица_comboBox4;
        private System.Windows.Forms.ComboBox Город_comboBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Выход_button;
    }
}