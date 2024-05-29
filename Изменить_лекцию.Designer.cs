
namespace Centr
{
    partial class Изменить_лекцию
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Изменить_лекцию));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Выход_button = new System.Windows.Forms.Button();
            this.Изменить_button1 = new System.Windows.Forms.Button();
            this.Ссылка_на_лекцию_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Название_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.Изменить_button1);
            this.tabPage1.Controls.Add(this.Ссылка_на_лекцию_textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Название_textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Изменить текстовую лекцию";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход_button.Location = new System.Drawing.Point(11, 15);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(200, 45);
            this.Выход_button.TabIndex = 98;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            // 
            // Изменить_button1
            // 
            this.Изменить_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Изменить_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Изменить_button1.Location = new System.Drawing.Point(368, 472);
            this.Изменить_button1.Name = "Изменить_button1";
            this.Изменить_button1.Size = new System.Drawing.Size(338, 50);
            this.Изменить_button1.TabIndex = 97;
            this.Изменить_button1.Text = "Изменить";
            this.Изменить_button1.UseVisualStyleBackColor = false;
            this.Изменить_button1.Click += new System.EventHandler(this.Изменить_button1_Click);
            // 
            // Ссылка_на_лекцию_textBox1
            // 
            this.Ссылка_на_лекцию_textBox1.Location = new System.Drawing.Point(234, 208);
            this.Ссылка_на_лекцию_textBox1.Multiline = true;
            this.Ссылка_на_лекцию_textBox1.Name = "Ссылка_на_лекцию_textBox1";
            this.Ссылка_на_лекцию_textBox1.Size = new System.Drawing.Size(593, 147);
            this.Ссылка_на_лекцию_textBox1.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 27);
            this.label2.TabIndex = 95;
            this.label2.Text = "Ссылка на лекцию:";
            // 
            // Название_textBox1
            // 
            this.Название_textBox1.Location = new System.Drawing.Point(234, 151);
            this.Название_textBox1.Name = "Название_textBox1";
            this.Название_textBox1.Size = new System.Drawing.Size(593, 34);
            this.Название_textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Название лекции:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(849, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // Изменить_лекцию
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "Изменить_лекцию";
            this.Text = "Изменить_лекцию";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox Ссылка_на_лекцию_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Название_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Изменить_button1;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}