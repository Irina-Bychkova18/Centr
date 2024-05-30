
namespace Centr
{
    partial class Записаться_на_курс
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Записаться_на_курс));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Выход_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ФИО_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Записаться_button1 = new System.Windows.Forms.Button();
            this.Время_занятий_comboBox4 = new System.Windows.Forms.ComboBox();
            this.Дни_посещений_comboBox3 = new System.Windows.Forms.ComboBox();
            this.Курс_comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
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
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.ФИО_comboBox1);
            this.tabPage1.Controls.Add(this.Записаться_button1);
            this.tabPage1.Controls.Add(this.Время_занятий_comboBox4);
            this.tabPage1.Controls.Add(this.Дни_посещений_comboBox3);
            this.tabPage1.Controls.Add(this.Курс_comboBox2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Записаться на курс";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(849, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход_button.Location = new System.Drawing.Point(19, 15);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(200, 45);
            this.Выход_button.TabIndex = 128;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(804, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 58);
            this.checkBox1.TabIndex = 127;
            this.checkBox1.Text = "Моей фамилии\r\nнет в списке";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ФИО_comboBox1
            // 
            this.ФИО_comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ФИО_comboBox1.FormattingEnabled = true;
            this.ФИО_comboBox1.Location = new System.Drawing.Point(289, 143);
            this.ФИО_comboBox1.Name = "ФИО_comboBox1";
            this.ФИО_comboBox1.Size = new System.Drawing.Size(509, 34);
            this.ФИО_comboBox1.TabIndex = 94;
            // 
            // Записаться_button1
            // 
            this.Записаться_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Записаться_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Записаться_button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Записаться_button1.Location = new System.Drawing.Point(383, 455);
            this.Записаться_button1.Name = "Записаться_button1";
            this.Записаться_button1.Size = new System.Drawing.Size(321, 53);
            this.Записаться_button1.TabIndex = 48;
            this.Записаться_button1.Text = "Записаться";
            this.Записаться_button1.UseVisualStyleBackColor = false;
            this.Записаться_button1.Click += new System.EventHandler(this.Записаться_button1_Click);
            // 
            // Время_занятий_comboBox4
            // 
            this.Время_занятий_comboBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Время_занятий_comboBox4.FormattingEnabled = true;
            this.Время_занятий_comboBox4.Location = new System.Drawing.Point(289, 281);
            this.Время_занятий_comboBox4.Name = "Время_занятий_comboBox4";
            this.Время_занятий_comboBox4.Size = new System.Drawing.Size(509, 34);
            this.Время_занятий_comboBox4.TabIndex = 47;
            // 
            // Дни_посещений_comboBox3
            // 
            this.Дни_посещений_comboBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Дни_посещений_comboBox3.FormattingEnabled = true;
            this.Дни_посещений_comboBox3.Location = new System.Drawing.Point(289, 238);
            this.Дни_посещений_comboBox3.Name = "Дни_посещений_comboBox3";
            this.Дни_посещений_comboBox3.Size = new System.Drawing.Size(509, 34);
            this.Дни_посещений_comboBox3.TabIndex = 46;
            // 
            // Курс_comboBox2
            // 
            this.Курс_comboBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Курс_comboBox2.FormattingEnabled = true;
            this.Курс_comboBox2.Location = new System.Drawing.Point(289, 193);
            this.Курс_comboBox2.Name = "Курс_comboBox2";
            this.Курс_comboBox2.Size = new System.Drawing.Size(509, 34);
            this.Курс_comboBox2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "Время занятий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 27);
            this.label6.TabIndex = 43;
            this.label6.Text = "Дни посещений";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Название курса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "Фамилия Имя Отчество";
            // 
            // Записаться_на_курс
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "Записаться_на_курс";
            this.Text = "Записаться_на_курс";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Записаться_button1;
        private System.Windows.Forms.ComboBox Время_занятий_comboBox4;
        private System.Windows.Forms.ComboBox Дни_посещений_comboBox3;
        private System.Windows.Forms.ComboBox Курс_comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ФИО_comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}