﻿
namespace Centr
{
    partial class Главная
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Главная));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Далее_button = new System.Windows.Forms.Button();
            this.Выборка_пользователя_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Выборка_центра_combobox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 451);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Далее_button);
            this.tabPage1.Controls.Add(this.Выборка_пользователя_combobox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Выборка_центра_combobox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная страница";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Далее_button
            // 
            this.Далее_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Далее_button.Location = new System.Drawing.Point(339, 346);
            this.Далее_button.Name = "Далее_button";
            this.Далее_button.Size = new System.Drawing.Size(111, 41);
            this.Далее_button.TabIndex = 13;
            this.Далее_button.Text = "Далее";
            this.Далее_button.UseVisualStyleBackColor = true;
            this.Далее_button.Click += new System.EventHandler(this.Далее_button_Click);
            // 
            // Выборка_пользователя_combobox
            // 
            this.Выборка_пользователя_combobox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выборка_пользователя_combobox.FormattingEnabled = true;
            this.Выборка_пользователя_combobox.Items.AddRange(new object[] {
            "Админ",
            "Руководитель",
            "Сотрудник",
            "Учащийся"});
            this.Выборка_пользователя_combobox.Location = new System.Drawing.Point(405, 269);
            this.Выборка_пользователя_combobox.Name = "Выборка_пользователя_combobox";
            this.Выборка_пользователя_combobox.Size = new System.Drawing.Size(359, 30);
            this.Выборка_пользователя_combobox.TabIndex = 12;
            this.Выборка_пользователя_combobox.Text = "Админ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 132);
            this.label3.TabIndex = 11;
            this.label3.Text = "Добро пожаловать\r\n в программу для образовательных учереждений!\r\n\r\nПрежде чем поп" +
    "асть на главную страницу,\r\n выберите из списка, подходящие варианты для вас\r\n и " +
    "нажмите кнопку \"Далее\".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите из списка кем вы являетесь:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите из списка ваше учереждение \r\nдля дальнейшей работы с программой:";
            // 
            // Выборка_центра_combobox
            // 
            this.Выборка_центра_combobox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выборка_центра_combobox.FormattingEnabled = true;
            this.Выборка_центра_combobox.Items.AddRange(new object[] {
            "Детский образовательный центр",
            "Курсы повышения квалификации"});
            this.Выборка_центра_combobox.Location = new System.Drawing.Point(405, 189);
            this.Выборка_центра_combobox.Name = "Выборка_центра_combobox";
            this.Выборка_центра_combobox.Size = new System.Drawing.Size(359, 30);
            this.Выборка_центра_combobox.TabIndex = 7;
            this.Выборка_центра_combobox.Text = "Детский образовательный центр ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Главная
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Главная";
            this.Text = "Главная";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Далее_button;
        private System.Windows.Forms.ComboBox Выборка_пользователя_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Выборка_центра_combobox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}