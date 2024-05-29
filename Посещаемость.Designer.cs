
namespace Centr
{
    partial class Посещаемость
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
            this.Выход_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.добавить_новую_дату_button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Название_столбца_textBox1 = new System.Windows.Forms.TextBox();
            this.Сохранить_изменения_button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 702);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Выход_button);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.добавить_новую_дату_button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Название_столбца_textBox1);
            this.tabPage1.Controls.Add(this.Сохранить_изменения_button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Посещаемость";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // Выход_button
            // 
            this.Выход_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Выход_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Выход_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход_button.Location = new System.Drawing.Point(12, 15);
            this.Выход_button.Name = "Выход_button";
            this.Выход_button.Size = new System.Drawing.Size(200, 45);
            this.Выход_button.TabIndex = 102;
            this.Выход_button.Text = "Выход";
            this.Выход_button.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView2.Location = new System.Drawing.Point(246, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(461, 462);
            this.dataGridView2.TabIndex = 101;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.BindingContextChanged += new System.EventHandler(this.dataGridView2_BindingContextChanged);
            // 
            // добавить_новую_дату_button1
            // 
            this.добавить_новую_дату_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.добавить_новую_дату_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.добавить_новую_дату_button1.Location = new System.Drawing.Point(718, 272);
            this.добавить_новую_дату_button1.Name = "добавить_новую_дату_button1";
            this.добавить_новую_дату_button1.Size = new System.Drawing.Size(276, 50);
            this.добавить_новую_дату_button1.TabIndex = 100;
            this.добавить_новую_дату_button1.Text = "Добавить новую дату";
            this.добавить_новую_дату_button1.UseVisualStyleBackColor = false;
            this.добавить_новую_дату_button1.Click += new System.EventHandler(this.добавить_новую_дату_button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 54);
            this.label2.TabIndex = 98;
            this.label2.Text = "Введите название столбца\r\n(дату):";
            // 
            // Название_столбца_textBox1
            // 
            this.Название_столбца_textBox1.Location = new System.Drawing.Point(718, 199);
            this.Название_столбца_textBox1.Name = "Название_столбца_textBox1";
            this.Название_столбца_textBox1.Size = new System.Drawing.Size(276, 34);
            this.Название_столбца_textBox1.TabIndex = 96;
            this.Название_столбца_textBox1.Enter += new System.EventHandler(this.Название_столбца_textBox1_Enter);
            // 
            // Сохранить_изменения_button1
            // 
            this.Сохранить_изменения_button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Сохранить_изменения_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Сохранить_изменения_button1.Location = new System.Drawing.Point(718, 531);
            this.Сохранить_изменения_button1.Name = "Сохранить_изменения_button1";
            this.Сохранить_изменения_button1.Size = new System.Drawing.Size(276, 57);
            this.Сохранить_изменения_button1.TabIndex = 43;
            this.Сохранить_изменения_button1.Text = "Изменить данные";
            this.Сохранить_изменения_button1.UseVisualStyleBackColor = false;
            this.Сохранить_изменения_button1.Click += new System.EventHandler(this.Сохранить_изменения_button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(275, 462);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Сведения о посещаемости";
            // 
            // Посещаемость
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "Посещаемость";
            this.Text = "Посещаемость";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button добавить_новую_дату_button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Название_столбца_textBox1;
        private System.Windows.Forms.Button Сохранить_изменения_button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Выход_button;
    }
}