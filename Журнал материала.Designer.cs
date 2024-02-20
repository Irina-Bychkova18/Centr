
namespace Centr
{
    partial class Журнал_материала
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Отменить_изменения_button2 = new System.Windows.Forms.Button();
            this.Сохранить_изменения_button1 = new System.Windows.Forms.Button();
            this.Выход_button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 455);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Отменить_изменения_button2);
            this.tabPage1.Controls.Add(this.Сохранить_изменения_button1);
            this.tabPage1.Controls.Add(this.Выход_button4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Журнал материала";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Отменить_изменения_button2
            // 
            this.Отменить_изменения_button2.Location = new System.Drawing.Point(578, 179);
            this.Отменить_изменения_button2.Name = "Отменить_изменения_button2";
            this.Отменить_изменения_button2.Size = new System.Drawing.Size(204, 43);
            this.Отменить_изменения_button2.TabIndex = 48;
            this.Отменить_изменения_button2.Text = "Отменить изменения";
            this.Отменить_изменения_button2.UseVisualStyleBackColor = true;
            // 
            // Сохранить_изменения_button1
            // 
            this.Сохранить_изменения_button1.Location = new System.Drawing.Point(578, 111);
            this.Сохранить_изменения_button1.Name = "Сохранить_изменения_button1";
            this.Сохранить_изменения_button1.Size = new System.Drawing.Size(204, 46);
            this.Сохранить_изменения_button1.TabIndex = 47;
            this.Сохранить_изменения_button1.Text = "Сохранить изменения";
            this.Сохранить_изменения_button1.UseVisualStyleBackColor = true;
            // 
            // Выход_button4
            // 
            this.Выход_button4.Location = new System.Drawing.Point(578, 18);
            this.Выход_button4.Name = "Выход_button4";
            this.Выход_button4.Size = new System.Drawing.Size(204, 32);
            this.Выход_button4.TabIndex = 46;
            this.Выход_button4.Text = "Выход";
            this.Выход_button4.UseVisualStyleBackColor = true;
            this.Выход_button4.Click += new System.EventHandler(this.Выход_button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 396);
            this.dataGridView1.TabIndex = 45;
            // 
            // Журнал_материала
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Журнал_материала";
            this.Text = "Журнал_материала";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Отменить_изменения_button2;
        private System.Windows.Forms.Button Сохранить_изменения_button1;
        private System.Windows.Forms.Button Выход_button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}