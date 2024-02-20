
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Показать_button2 = new System.Windows.Forms.Button();
            this.Временной_промежуток_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Распечатать_расписание_button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Выход_button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.Показать_button2);
            this.tabPage1.Controls.Add(this.Временной_промежуток_comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Распечатать_расписание_button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Выход_button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание занятий";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Показать_button2
            // 
            this.Показать_button2.Location = new System.Drawing.Point(394, 8);
            this.Показать_button2.Name = "Показать_button2";
            this.Показать_button2.Size = new System.Drawing.Size(168, 27);
            this.Показать_button2.TabIndex = 41;
            this.Показать_button2.Text = "Показать";
            this.Показать_button2.UseVisualStyleBackColor = true;
            // 
            // Временной_промежуток_comboBox1
            // 
            this.Временной_промежуток_comboBox1.FormattingEnabled = true;
            this.Временной_промежуток_comboBox1.Location = new System.Drawing.Point(252, 10);
            this.Временной_промежуток_comboBox1.Name = "Временной_промежуток_comboBox1";
            this.Временной_промежуток_comboBox1.Size = new System.Drawing.Size(125, 24);
            this.Временной_промежуток_comboBox1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Выберите временной промежуток:";
            // 
            // Распечатать_расписание_button1
            // 
            this.Распечатать_расписание_button1.Location = new System.Drawing.Point(581, 62);
            this.Распечатать_расписание_button1.Name = "Распечатать_расписание_button1";
            this.Распечатать_расписание_button1.Size = new System.Drawing.Size(204, 36);
            this.Распечатать_расписание_button1.TabIndex = 38;
            this.Распечатать_расписание_button1.Text = "Распечатать расписание";
            this.Распечатать_расписание_button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 370);
            this.dataGridView1.TabIndex = 37;
            // 
            // Выход_button4
            // 
            this.Выход_button4.Location = new System.Drawing.Point(581, 8);
            this.Выход_button4.Name = "Выход_button4";
            this.Выход_button4.Size = new System.Drawing.Size(204, 32);
            this.Выход_button4.TabIndex = 36;
            this.Выход_button4.Text = "Выход";
            this.Выход_button4.UseVisualStyleBackColor = true;
            this.Выход_button4.Click += new System.EventHandler(this.Выход_button4_Click);
            // 
            // Расписание_занятий
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Расписание_занятий";
            this.Text = "Расписание_занятий";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Показать_button2;
        private System.Windows.Forms.ComboBox Временной_промежуток_comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Распечатать_расписание_button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Выход_button4;
    }
}