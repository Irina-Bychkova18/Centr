using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centr
{
    public partial class Успеваемость_учащегося : Form
    {
        public Успеваемость_учащегося()
        {
            InitializeComponent();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {

            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridView1.DataSource = Form1.cdt.Tables["Успеваемость учащегося"];
            dataGridView1.Columns["Пройдено лекций"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["Всего лекций"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["Процент успеваемости"].DefaultCellStyle.Format = "0\\% ";
            dataGridView1.Columns["Логин"].Visible = false;
            dataGridView1.Columns["Пароль"].Visible = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
