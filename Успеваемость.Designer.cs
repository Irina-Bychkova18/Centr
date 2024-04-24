
namespace Centr
{
    partial class Успеваемость
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Успеваемость));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Выход_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Удалить_запись_button5 = new System.Windows.Forms.Button();
            this.Изменить_запись_button2 = new System.Windows.Forms.Button();
            this.Добавить_запись_button1 = new System.Windows.Forms.Button();
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
            this.tabControl1.Size = new System.Drawing.Size(802, 452);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Удалить_запись_button5);
            this.tabPage1.Controls.Add(this.Изменить_запись_button2);
            this.tabPage1.Controls.Add(this.Добавить_запись_button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Успеваемость";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выход_button.Location = new System.Drawing.Point(9, 15);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(121, 38);
            this.Выход_button.TabIndex = 94;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 278);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Сведения об успеваемости";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Удалить_запись_button5
            // 
            this.Удалить_запись_button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Удалить_запись_button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Удалить_запись_button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Удалить_запись_button5.Location = new System.Drawing.Point(12, 384);
            this.Удалить_запись_button5.Name = "Удалить_запись_button5";
            this.Удалить_запись_button5.Size = new System.Drawing.Size(244, 31);
            this.Удалить_запись_button5.TabIndex = 102;
            this.Удалить_запись_button5.Text = "Удалить запись";
            this.Удалить_запись_button5.UseVisualStyleBackColor = false;
            this.Удалить_запись_button5.Click += new System.EventHandler(this.Удалить_запись_button5_Click);
            // 
            // Изменить_запись_button2
            // 
            this.Изменить_запись_button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Изменить_запись_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Изменить_запись_button2.Location = new System.Drawing.Point(283, 383);
            this.Изменить_запись_button2.Name = "Изменить_запись_button2";
            this.Изменить_запись_button2.Size = new System.Drawing.Size(262, 32);
            this.Изменить_запись_button2.TabIndex = 101;
            this.Изменить_запись_button2.Text = "Изменить запись";
            this.Изменить_запись_button2.UseVisualStyleBackColor = false;
            this.Изменить_запись_button2.Click += new System.EventHandler(this.Изменить_запись_button2_Click);
            // 
            // Добавить_запись_button1
            // 
            this.Добавить_запись_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Добавить_запись_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Добавить_запись_button1.Location = new System.Drawing.Point(568, 384);
            this.Добавить_запись_button1.Name = "Добавить_запись_button1";
            this.Добавить_запись_button1.Size = new System.Drawing.Size(217, 32);
            this.Добавить_запись_button1.TabIndex = 100;
            this.Добавить_запись_button1.Text = "Добавить запись";
            this.Добавить_запись_button1.UseVisualStyleBackColor = false;
            this.Добавить_запись_button1.Click += new System.EventHandler(this.Добавить_запись_button1_Click);
            // 
            // Успеваемость
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Успеваемость";
            this.Text = "Успеваемость";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Удалить_запись_button5;
        private System.Windows.Forms.Button Изменить_запись_button2;
        private System.Windows.Forms.Button Добавить_запись_button1;
    }
}