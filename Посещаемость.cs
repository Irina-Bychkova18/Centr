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
            string sql = "SELECT id_pos AS \"Номер записи\", uchenik.fio AS \"ФИО ученика\","
               + " d_01_04 AS \"01.04\", d_02_04 AS \"02.04\", d_03_04 AS \"03.04\", d_04_04 AS \"04.04\", " +
               "d_05_04 AS \"05.04\", d_06_04 AS \"06.04\", d_08_04 AS \"08.04\", d_09_04 AS \"09.04\", " +
               "d_10_04 AS \"10.04\", d_11_04 AS \"11.04\", d_12_04 AS \"12.04\", d_13_04 AS \"13.04\", " +
               "d_15_04 AS \"15.04\", d_16_04 AS \"16.04\", d_17_04 AS \"17.04\", d_18_04 AS \"18.04\", " +
               "d_19_04 AS \"19.04\", d_20_04 AS \"20.04\" FROM (poseshaemost inner join uchenik on uchenik.id_uch = poseshaemost.id_uch)"
               + " where uchenik.id_uch = poseshaemost.id_uch" +
               " GROUP BY id_pos, uchenik.fio, d_01_04, d_02_04, d_03_04, d_04_04, " +
               "d_05_04, d_06_04, d_08_04, d_09_04, " +
               "d_10_04, d_11_04, d_12_04, d_13_04, " +
               "d_15_04, d_16_04, d_17_04, d_18_04, " +
               "d_19_04, d_20_04 ORDER BY \"Номер записи\"";
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
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
