﻿
namespace Centr
{
    partial class все_текстовые_лекции_админ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(все_текстовые_лекции_админ));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Выход_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Всего_лекций_textBox1 = new System.Windows.Forms.TextBox();
            this.Удалить_лекцию_button5 = new System.Windows.Forms.Button();
            this.Сохранить_button3 = new System.Windows.Forms.Button();
            this.Добавить_лекцию_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-6, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 455);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Всего_лекций_textBox1);
            this.tabPage1.Controls.Add(this.Удалить_лекцию_button5);
            this.tabPage1.Controls.Add(this.Сохранить_button3);
            this.tabPage1.Controls.Add(this.Добавить_лекцию_button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все текстовые лекции и их добавление";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(681, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выход_button.Location = new System.Drawing.Point(14, 12);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(121, 38);
            this.Выход_button.TabIndex = 52;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Всего лекций:";
            // 
            // Всего_лекций_textBox1
            // 
            this.Всего_лекций_textBox1.Location = new System.Drawing.Point(681, 91);
            this.Всего_лекций_textBox1.Name = "Всего_лекций_textBox1";
            this.Всего_лекций_textBox1.Size = new System.Drawing.Size(107, 22);
            this.Всего_лекций_textBox1.TabIndex = 43;
            this.Всего_лекций_textBox1.TextChanged += new System.EventHandler(this.Всего_лекций_textBox1_TextChanged_1);
            // 
            // Удалить_лекцию_button5
            // 
            this.Удалить_лекцию_button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Удалить_лекцию_button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Удалить_лекцию_button5.Location = new System.Drawing.Point(559, 186);
            this.Удалить_лекцию_button5.Name = "Удалить_лекцию_button5";
            this.Удалить_лекцию_button5.Size = new System.Drawing.Size(231, 31);
            this.Удалить_лекцию_button5.TabIndex = 41;
            this.Удалить_лекцию_button5.Text = "Удалить лекцию";
            this.Удалить_лекцию_button5.UseVisualStyleBackColor = false;
            this.Удалить_лекцию_button5.Click += new System.EventHandler(this.Удалить_лекцию_button5_Click);
            // 
            // Сохранить_button3
            // 
            this.Сохранить_button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Сохранить_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Сохранить_button3.Location = new System.Drawing.Point(559, 268);
            this.Сохранить_button3.Name = "Сохранить_button3";
            this.Сохранить_button3.Size = new System.Drawing.Size(229, 49);
            this.Сохранить_button3.TabIndex = 39;
            this.Сохранить_button3.Text = "Сохранить";
            this.Сохранить_button3.UseVisualStyleBackColor = false;
            // 
            // Добавить_лекцию_button1
            // 
            this.Добавить_лекцию_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Добавить_лекцию_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Добавить_лекцию_button1.Location = new System.Drawing.Point(559, 134);
            this.Добавить_лекцию_button1.Name = "Добавить_лекцию_button1";
            this.Добавить_лекцию_button1.Size = new System.Drawing.Size(231, 31);
            this.Добавить_лекцию_button1.TabIndex = 37;
            this.Добавить_лекцию_button1.Text = "Добавить лекцию";
            this.Добавить_лекцию_button1.UseVisualStyleBackColor = false;
            this.Добавить_лекцию_button1.Click += new System.EventHandler(this.Добавить_лекцию_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Лекции центра";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 332);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // все_текстовые_лекции_админ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "все_текстовые_лекции_админ";
            this.Text = "все_текстовые_лекции_админ";
            this.Load += new System.EventHandler(this.все_текстовые_лекции_админ_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Удалить_лекцию_button5;
        private System.Windows.Forms.Button Сохранить_button3;
        private System.Windows.Forms.Button Добавить_лекцию_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Всего_лекций_textBox1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TabPage tabPage1;
    }
}