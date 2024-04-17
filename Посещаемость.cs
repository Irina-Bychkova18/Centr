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
    public partial class Посещаемость : Form
    {
        public Посещаемость()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_pos AS \"Номер записи\", uchenik.fio AS \"ФИО ученика\" FROM (poseshaemost inner join uchenik on uchenik.id_uch = poseshaemost.id_uch)"
               + " where uchenik.id_uch = poseshaemost.id_uch" +
               " GROUP BY id_pos, uchenik.fio ORDER BY \"Номер записи\"";
            Form1.Table_Fill("Посещаемость", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Посещаемость"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            string sql1 = "SELECT * FROM poseshaemost";
            Form1.Table_Fill("Даты", sql1);

            dataGridView2.DataSource = Form1.cdt.Tables["Даты"];
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;
            dataGridView2.AutoResizeColumns();
            dataGridView2.CurrentCell = null;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void добавить_новую_дату_button1_Click(object sender, EventArgs e)
        {
            string sql = "ALTER TABLE poseshaemost ADD COLUMN " + Название_столбца_textBox1.Text + " boolean";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
        }
    }
}
