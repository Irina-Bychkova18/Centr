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
    public partial class Посещаемость_учащегося : Form
    {
        public Посещаемость_учащегося()
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
            dataGridView1.DataSource = Form1.cdt.Tables["Посещаемость учащегося"];
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

            dataGridView2.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridView2.DataSource = Form1.cdt.Tables["Даты учащегося"];
            dataGridView2.Columns["id_pos"].Visible = false;
            dataGridView2.Columns["id_uch"].Visible = false;
            dataGridView2.Columns["fio"].Visible = false;
            dataGridView2.Columns["data_r"].Visible = false;
            dataGridView2.Columns["telephon_uch"].Visible = false;
            dataGridView2.Columns["id_g"].Visible = false;
            dataGridView2.Columns["id_ul"].Visible = false;
            dataGridView2.Columns["id_d"].Visible = false;
            dataGridView2.Columns["id_k"].Visible = false;
            dataGridView2.Columns["telephon_roditela"].Visible = false;
            dataGridView2.Columns["login"].Visible = false;
            dataGridView2.Columns["parol"].Visible = false;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;
            dataGridView2.AutoResizeColumns();
            dataGridView2.CurrentCell = null;
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView2_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView2.AutoResizeColumns();
            dataGridView2.CurrentCell = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
