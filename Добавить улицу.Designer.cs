
namespace Centr
{
    partial class Добавить_улицу
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
            this.Добавить_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Название_улицы_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Добавить_button1
            // 
            this.Добавить_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Добавить_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Добавить_button1.Location = new System.Drawing.Point(117, 108);
            this.Добавить_button1.Name = "Добавить_button1";
            this.Добавить_button1.Size = new System.Drawing.Size(135, 29);
            this.Добавить_button1.TabIndex = 0;
            this.Добавить_button1.Text = "Добавить";
            this.Добавить_button1.UseVisualStyleBackColor = false;
            this.Добавить_button1.Click += new System.EventHandler(this.Добавить_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите улицу:";
            // 
            // Название_улицы_textBox1
            // 
            this.Название_улицы_textBox1.Location = new System.Drawing.Point(127, 48);
            this.Название_улицы_textBox1.Name = "Название_улицы_textBox1";
            this.Название_улицы_textBox1.Size = new System.Drawing.Size(214, 22);
            this.Название_улицы_textBox1.TabIndex = 2;
            // 
            // Добавить_улицу
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(353, 167);
            this.Controls.Add(this.Название_улицы_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Добавить_button1);
            this.Name = "Добавить_улицу";
            this.Text = "Добавить_улицу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Добавить_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Название_улицы_textBox1;
    }
}