﻿
namespace Centr
{
    partial class все_видеоролики
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(все_видеоролики));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.Сортировать_button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Выход_button = new System.Windows.Forms.Button();
            this.Всего_видеороликов_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Сортировка_textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 456);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Сортировка_textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Сортировать_button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.Всего_видеороликов_textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все видеоролики ";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Введите столбец для сортировки:";
            // 
            // Сортировать_button1
            // 
            this.Сортировать_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Сортировать_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Сортировать_button1.Location = new System.Drawing.Point(553, 222);
            this.Сортировать_button1.Name = "Сортировать_button1";
            this.Сортировать_button1.Size = new System.Drawing.Size(231, 31);
            this.Сортировать_button1.TabIndex = 58;
            this.Сортировать_button1.Text = "Сортировать";
            this.Сортировать_button1.UseVisualStyleBackColor = false;
            this.Сортировать_button1.Click += new System.EventHandler(this.Сортировать_button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выход_button.Location = new System.Drawing.Point(12, 11);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(121, 38);
            this.Выход_button.TabIndex = 51;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click);
            // 
            // Всего_видеороликов_textBox1
            // 
            this.Всего_видеороликов_textBox1.Location = new System.Drawing.Point(698, 101);
            this.Всего_видеороликов_textBox1.Name = "Всего_видеороликов_textBox1";
            this.Всего_видеороликов_textBox1.Size = new System.Drawing.Size(87, 22);
            this.Всего_видеороликов_textBox1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Всего видеороликов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Видеоматериал центра";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 331);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // Сортировка_textBox1
            // 
            this.Сортировка_textBox1.Location = new System.Drawing.Point(553, 174);
            this.Сортировка_textBox1.Name = "Сортировка_textBox1";
            this.Сортировка_textBox1.Size = new System.Drawing.Size(229, 22);
            this.Сортировка_textBox1.TabIndex = 60;
            // 
            // все_видеоролики
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "все_видеоролики";
            this.Text = "все_видеоролики";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Сортировка_textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Сортировать_button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.TextBox Всего_видеороликов_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}