
namespace Centr
{
    partial class все_курсы_сотрудник
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(все_курсы_сотрудник));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Выход_button = new System.Windows.Forms.Button();
            this.Количество_оставшихся_мест_textBox2 = new System.Windows.Forms.TextBox();
            this.Всего_курсов_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-2, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 456);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.Количество_оставшихся_мест_textBox2);
            this.tabPage1.Controls.Add(this.Всего_курсов_textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все курсы";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(670, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Выход_button.Location = new System.Drawing.Point(19, 16);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(121, 38);
            this.Выход_button.TabIndex = 91;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            this.Выход_button.Click += new System.EventHandler(this.Выход_button_Click);
            // 
            // Количество_оставшихся_мест_textBox2
            // 
            this.Количество_оставшихся_мест_textBox2.Location = new System.Drawing.Point(575, 88);
            this.Количество_оставшихся_мест_textBox2.Name = "Количество_оставшихся_мест_textBox2";
            this.Количество_оставшихся_мест_textBox2.Size = new System.Drawing.Size(204, 22);
            this.Количество_оставшихся_мест_textBox2.TabIndex = 87;
            // 
            // Всего_курсов_textBox1
            // 
            this.Всего_курсов_textBox1.Location = new System.Drawing.Point(137, 88);
            this.Всего_курсов_textBox1.Name = "Всего_курсов_textBox1";
            this.Всего_курсов_textBox1.Size = new System.Drawing.Size(204, 22);
            this.Всего_курсов_textBox1.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Количество оставшихся мест:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Всего курсов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Курсы центра";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 264);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // все_курсы_сотрудник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "все_курсы_сотрудник";
            this.Text = "все_курсы_сотрудник";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Выход_button;
        private System.Windows.Forms.TextBox Количество_оставшихся_мест_textBox2;
        private System.Windows.Forms.TextBox Всего_курсов_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}