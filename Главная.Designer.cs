
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Далее_button = new System.Windows.Forms.Button();
            this.Выборка_пользователя_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Далее_button);
            this.tabPage1.Controls.Add(this.Выборка_пользователя_combobox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(687, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Далее_button
            // 
            this.Далее_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Далее_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Далее_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Далее_button.Location = new System.Drawing.Point(335, 336);
            this.Далее_button.Name = "Далее_button";
            this.Далее_button.Size = new System.Drawing.Size(111, 41);
            this.Далее_button.TabIndex = 28;
            this.Далее_button.Text = "Далее";
            this.Далее_button.UseVisualStyleBackColor = false;
            this.Далее_button.Click += new System.EventHandler(this.Далее_button_Click);
            // 
            // Выборка_пользователя_combobox
            // 
            this.Выборка_пользователя_combobox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выборка_пользователя_combobox.FormattingEnabled = true;
            this.Выборка_пользователя_combobox.Location = new System.Drawing.Point(195, 253);
            this.Выборка_пользователя_combobox.Name = "Выборка_пользователя_combobox";
            this.Выборка_пользователя_combobox.Size = new System.Drawing.Size(417, 30);
            this.Выборка_пользователя_combobox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(178, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 154);
            this.label3.TabIndex = 26;
            this.label3.Text = "Добро пожаловать\r\n в программу детского образовательного центра!\r\n\r\nПрежде чем по" +
    "пасть на главную страницу,\r\n выберите из списка подходящий вариант для вас\r\n и н" +
    "ажмите кнопку \"Далее\".\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(229, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Выберите из списка кем вы являетесь:";
            // 
            // Главная
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(806, 452);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Далее_button;
        private System.Windows.Forms.ComboBox Выборка_пользователя_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl tabControl1;
    }
}