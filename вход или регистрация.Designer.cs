
namespace Centr
{
    partial class вход_или_регистрация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(вход_или_регистрация));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Войти_button = new System.Windows.Forms.Button();
            this.Зарегистрироваться_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Войти_button);
            this.tabPage1.Controls.Add(this.Зарегистрироваться_button);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход или регистрация";
            // 
            // Войти_button
            // 
            this.Войти_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Войти_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Войти_button.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Войти_button.Location = new System.Drawing.Point(603, 362);
            this.Войти_button.Name = "Войти_button";
            this.Войти_button.Size = new System.Drawing.Size(314, 52);
            this.Войти_button.TabIndex = 19;
            this.Войти_button.Text = "Войти";
            this.Войти_button.UseVisualStyleBackColor = false;
            this.Войти_button.Click += new System.EventHandler(this.Войти_button_Click);
            // 
            // Зарегистрироваться_button
            // 
            this.Зарегистрироваться_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Зарегистрироваться_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Зарегистрироваться_button.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Зарегистрироваться_button.Location = new System.Drawing.Point(111, 362);
            this.Зарегистрироваться_button.Name = "Зарегистрироваться_button";
            this.Зарегистрироваться_button.Size = new System.Drawing.Size(314, 52);
            this.Зарегистрироваться_button.TabIndex = 18;
            this.Зарегистрироваться_button.Text = "Зарегистрироваться";
            this.Зарегистрироваться_button.UseVisualStyleBackColor = false;
            this.Зарегистрироваться_button.Click += new System.EventHandler(this.Зарегистрироваться_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label3.Location = new System.Drawing.Point(237, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 135);
            this.label3.TabIndex = 17;
            this.label3.Text = "Теперь попрошу вас выбрать:\r\nявляетесь ли вы зарегистрированным пользователем\r\nил" +
    "и нет.\r\n\r\nЕсли нет, то, пожалуйста, зарегистрируйтесь!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(849, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // вход_или_регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "вход_или_регистрация";
            this.Text = "вход_или_регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.вход_или_регистрация_FormClosing);
            this.Load += new System.EventHandler(this.вход_или_регистрация_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Войти_button;
        private System.Windows.Forms.Button Зарегистрироваться_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}