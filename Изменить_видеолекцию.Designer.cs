
namespace Centr
{
    partial class Изменить_видеолекцию
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Изменить_видеолекцию));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Изменить_button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Информация_textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Название_textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 702);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.Изменить_button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Информация_textBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Название_textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Изменить видеоролик";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // Изменить_button1
            // 
            this.Изменить_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Изменить_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Изменить_button1.Location = new System.Drawing.Point(250, 291);
            this.Изменить_button1.Name = "Изменить_button1";
            this.Изменить_button1.Size = new System.Drawing.Size(312, 35);
            this.Изменить_button1.TabIndex = 98;
            this.Изменить_button1.Text = "Изменить";
            this.Изменить_button1.UseVisualStyleBackColor = false;
            this.Изменить_button1.Click += new System.EventHandler(this.Изменить_button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(675, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // Информация_textBox4
            // 
            this.Информация_textBox4.Location = new System.Drawing.Point(175, 162);
            this.Информация_textBox4.Multiline = true;
            this.Информация_textBox4.Name = "Информация_textBox4";
            this.Информация_textBox4.Size = new System.Drawing.Size(478, 86);
            this.Информация_textBox4.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ссылка на видеоролик:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Название:";
            // 
            // Название_textBox1
            // 
            this.Название_textBox1.Location = new System.Drawing.Point(175, 87);
            this.Название_textBox1.Multiline = true;
            this.Название_textBox1.Name = "Название_textBox1";
            this.Название_textBox1.Size = new System.Drawing.Size(478, 47);
            this.Название_textBox1.TabIndex = 38;
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход_button.Location = new System.Drawing.Point(11, 13);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(200, 45);
            this.Выход_button.TabIndex = 99;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            // 
            // Изменить_видеолекцию
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "Изменить_видеолекцию";
            this.Text = "Изменить_видеолекцию";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Информация_textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Название_textBox1;
        private System.Windows.Forms.Button Изменить_button1;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Выход_button;
    }
}