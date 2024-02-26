
namespace Centr
{
    partial class Выбор_центра
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Выбор_центра));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Назад_button = new System.Windows.Forms.Button();
            this.Далее_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Выборка_центра_combobox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 451);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Назад_button);
            this.tabPage1.Controls.Add(this.Далее_button);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Выборка_центра_combobox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выбор центра";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // Назад_button
            // 
            this.Назад_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Назад_button.Location = new System.Drawing.Point(677, 6);
            this.Назад_button.Name = "Назад_button";
            this.Назад_button.Size = new System.Drawing.Size(111, 37);
            this.Назад_button.TabIndex = 14;
            this.Назад_button.Text = "Назад";
            this.Назад_button.UseVisualStyleBackColor = true;
            this.Назад_button.Click += new System.EventHandler(this.Назад_button_Click);
            // 
            // Далее_button
            // 
            this.Далее_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Далее_button.Location = new System.Drawing.Point(339, 346);
            this.Далее_button.Name = "Далее_button";
            this.Далее_button.Size = new System.Drawing.Size(111, 41);
            this.Далее_button.TabIndex = 13;
            this.Далее_button.Text = "Далее";
            this.Далее_button.UseVisualStyleBackColor = true;
            this.Далее_button.Click += new System.EventHandler(this.Далее_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Выберете, пожалуйста, ваш центр из ниже приведенных вариантов:\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите из списка ваше учереждение \r\nдля дальнейшей работы с программой:";
            // 
            // Выборка_центра_combobox
            // 
            this.Выборка_центра_combobox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выборка_центра_combobox.FormattingEnabled = true;
            this.Выборка_центра_combobox.Location = new System.Drawing.Point(148, 240);
            this.Выборка_центра_combobox.Name = "Выборка_центра_combobox";
            this.Выборка_центра_combobox.Size = new System.Drawing.Size(560, 30);
            this.Выборка_центра_combobox.TabIndex = 7;
            this.Выборка_центра_combobox.SelectedIndexChanged += new System.EventHandler(this.Выборка_центра_combobox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Выбор_центра
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Выбор_центра";
            this.Text = "Выбор_центра";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Далее_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Выборка_центра_combobox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Назад_button;
    }
}