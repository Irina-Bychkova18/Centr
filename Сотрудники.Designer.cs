
namespace Centr
{
    partial class Сотрудники
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сотрудники));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Поиск_textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Назад_button1 = new System.Windows.Forms.Button();
            this.Показать_button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ведет_курсы_textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Удалить_button3 = new System.Windows.Forms.Button();
            this.Изменить_button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ФИОtextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Добавить_button2 = new System.Windows.Forms.Button();
            this.Должность_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Выход_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 702);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.Поиск_textBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Назад_button1);
            this.tabPage1.Controls.Add(this.Показать_button2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Ведет_курсы_textBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Удалить_button3);
            this.tabPage1.Controls.Add(this.Изменить_button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ФИОtextBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Добавить_button2);
            this.tabPage1.Controls.Add(this.Должность_comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники и их добавление";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // Поиск_textBox2
            // 
            this.Поиск_textBox2.Location = new System.Drawing.Point(577, 257);
            this.Поиск_textBox2.Name = "Поиск_textBox2";
            this.Поиск_textBox2.Size = new System.Drawing.Size(208, 34);
            this.Поиск_textBox2.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 27);
            this.label5.TabIndex = 103;
            this.label5.Text = "Введите данные для поиска:";
            // 
            // Назад_button1
            // 
            this.Назад_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Назад_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Назад_button1.Location = new System.Drawing.Point(375, 300);
            this.Назад_button1.Name = "Назад_button1";
            this.Назад_button1.Size = new System.Drawing.Size(176, 27);
            this.Назад_button1.TabIndex = 102;
            this.Назад_button1.Text = "Назад\r\n";
            this.Назад_button1.UseVisualStyleBackColor = false;
            this.Назад_button1.Click += new System.EventHandler(this.Назад_button1_Click);
            // 
            // Показать_button2
            // 
            this.Показать_button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Показать_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Показать_button2.Location = new System.Drawing.Point(599, 300);
            this.Показать_button2.Name = "Показать_button2";
            this.Показать_button2.Size = new System.Drawing.Size(187, 27);
            this.Показать_button2.TabIndex = 99;
            this.Показать_button2.Text = "Показать";
            this.Показать_button2.UseVisualStyleBackColor = false;
            this.Показать_button2.Click += new System.EventHandler(this.Показать_button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // Ведет_курсы_textBox2
            // 
            this.Ведет_курсы_textBox2.Location = new System.Drawing.Point(477, 165);
            this.Ведет_курсы_textBox2.Name = "Ведет_курсы_textBox2";
            this.Ведет_курсы_textBox2.Size = new System.Drawing.Size(309, 34);
            this.Ведет_курсы_textBox2.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ведет курсы:";
            // 
            // Удалить_button3
            // 
            this.Удалить_button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Удалить_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Удалить_button3.Location = new System.Drawing.Point(661, 375);
            this.Удалить_button3.Name = "Удалить_button3";
            this.Удалить_button3.Size = new System.Drawing.Size(125, 39);
            this.Удалить_button3.TabIndex = 59;
            this.Удалить_button3.Text = "Удалить";
            this.Удалить_button3.UseVisualStyleBackColor = false;
            this.Удалить_button3.Click += new System.EventHandler(this.Удалить_button3_Click);
            // 
            // Изменить_button1
            // 
            this.Изменить_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Изменить_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Изменить_button1.Location = new System.Drawing.Point(520, 375);
            this.Изменить_button1.Name = "Изменить_button1";
            this.Изменить_button1.Size = new System.Drawing.Size(125, 39);
            this.Изменить_button1.TabIndex = 58;
            this.Изменить_button1.Text = "Изменить";
            this.Изменить_button1.UseVisualStyleBackColor = false;
            this.Изменить_button1.Click += new System.EventHandler(this.Изменить_button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 27);
            this.label3.TabIndex = 57;
            this.label3.Text = "Информация о сотрудниках";
            // 
            // ФИОtextBox1
            // 
            this.ФИОtextBox1.Location = new System.Drawing.Point(477, 87);
            this.ФИОtextBox1.Name = "ФИОtextBox1";
            this.ФИОtextBox1.Size = new System.Drawing.Size(309, 34);
            this.ФИОtextBox1.TabIndex = 56;
            this.ФИОtextBox1.TextChanged += new System.EventHandler(this.ФИОtextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "ФИО:";
            // 
            // Добавить_button2
            // 
            this.Добавить_button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Добавить_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Добавить_button2.Location = new System.Drawing.Point(380, 375);
            this.Добавить_button2.Name = "Добавить_button2";
            this.Добавить_button2.Size = new System.Drawing.Size(125, 39);
            this.Добавить_button2.TabIndex = 54;
            this.Добавить_button2.Text = "Добавить";
            this.Добавить_button2.UseVisualStyleBackColor = false;
            this.Добавить_button2.Click += new System.EventHandler(this.Добавить_button2_Click);
            // 
            // Должность_comboBox1
            // 
            this.Должность_comboBox1.FormattingEnabled = true;
            this.Должность_comboBox1.Location = new System.Drawing.Point(477, 124);
            this.Должность_comboBox1.Name = "Должность_comboBox1";
            this.Должность_comboBox1.Size = new System.Drawing.Size(309, 34);
            this.Должность_comboBox1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 52;
            this.label1.Text = "Должность:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(355, 340);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход_button.Location = new System.Drawing.Point(13, 17);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(200, 45);
            this.Выход_button.TabIndex = 106;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            // 
            // Сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "Сотрудники";
            this.Text = "Сотрудники";
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
        private System.Windows.Forms.TextBox Ведет_курсы_textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Удалить_button3;
        private System.Windows.Forms.Button Изменить_button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ФИОtextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Добавить_button2;
        private System.Windows.Forms.ComboBox Должность_comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Назад_button1;
        private System.Windows.Forms.Button Показать_button2;
        private System.Windows.Forms.TextBox Поиск_textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Выход_button;
    }
}