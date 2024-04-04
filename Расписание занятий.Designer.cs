
namespace Centr
{
    partial class Расписание_занятий
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Расписание_занятий));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Дни_работы_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Выход_button = new System.Windows.Forms.Button();
            this.Показать_button2 = new System.Windows.Forms.Button();
            this.Временной_промежуток_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Распечатать_расписание_button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Назад_button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 453);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Назад_button1);
            this.tabPage1.Controls.Add(this.Дни_работы_comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.Показать_button2);
            this.tabPage1.Controls.Add(this.Временной_промежуток_comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Распечатать_расписание_button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание занятий";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // Дни_работы_comboBox1
            // 
            this.Дни_работы_comboBox1.FormattingEnabled = true;
            this.Дни_работы_comboBox1.Location = new System.Drawing.Point(676, 105);
            this.Дни_работы_comboBox1.Name = "Дни_работы_comboBox1";
            this.Дни_работы_comboBox1.Size = new System.Drawing.Size(109, 24);
            this.Дни_работы_comboBox1.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 34);
            this.label2.TabIndex = 94;
            this.label2.Text = "Выберите \r\nдни работы:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 5);
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
            this.Выход_button.Location = new System.Drawing.Point(12, 8);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(121, 38);
            this.Выход_button.TabIndex = 92;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click);
            // 
            // Показать_button2
            // 
            this.Показать_button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Показать_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Показать_button2.Location = new System.Drawing.Point(571, 204);
            this.Показать_button2.Name = "Показать_button2";
            this.Показать_button2.Size = new System.Drawing.Size(214, 27);
            this.Показать_button2.TabIndex = 41;
            this.Показать_button2.Text = "Показать";
            this.Показать_button2.UseVisualStyleBackColor = false;
            this.Показать_button2.Click += new System.EventHandler(this.Показать_button2_Click);
            // 
            // Временной_промежуток_comboBox1
            // 
            this.Временной_промежуток_comboBox1.FormattingEnabled = true;
            this.Временной_промежуток_comboBox1.Location = new System.Drawing.Point(676, 151);
            this.Временной_промежуток_comboBox1.Name = "Временной_промежуток_comboBox1";
            this.Временной_промежуток_comboBox1.Size = new System.Drawing.Size(109, 24);
            this.Временной_промежуток_comboBox1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 34);
            this.label1.TabIndex = 39;
            this.label1.Text = "Выберите \r\nвремя работы:\r\n";
            // 
            // Распечатать_расписание_button1
            // 
            this.Распечатать_расписание_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Распечатать_расписание_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Распечатать_расписание_button1.Location = new System.Drawing.Point(571, 378);
            this.Распечатать_расписание_button1.Name = "Распечатать_расписание_button1";
            this.Распечатать_расписание_button1.Size = new System.Drawing.Size(214, 36);
            this.Распечатать_расписание_button1.TabIndex = 38;
            this.Распечатать_расписание_button1.Text = "Распечатать расписание";
            this.Распечатать_расписание_button1.UseVisualStyleBackColor = false;
            this.Распечатать_расписание_button1.Click += new System.EventHandler(this.Распечатать_расписание_button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 339);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // Назад_button1
            // 
            this.Назад_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Назад_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Назад_button1.Location = new System.Drawing.Point(571, 265);
            this.Назад_button1.Name = "Назад_button1";
            this.Назад_button1.Size = new System.Drawing.Size(214, 27);
            this.Назад_button1.TabIndex = 96;
            this.Назад_button1.Text = "Назад\r\n";
            this.Назад_button1.UseVisualStyleBackColor = false;
            this.Назад_button1.Click += new System.EventHandler(this.Назад_button1_Click);
            // 
            // Расписание_занятий
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Расписание_занятий";
            this.Text = "Расписание_занятий";
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
        private System.Windows.Forms.ComboBox Временной_промежуток_comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Показать_button2;
        private System.Windows.Forms.Button Распечатать_расписание_button1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Дни_работы_comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Назад_button1;
    }
}