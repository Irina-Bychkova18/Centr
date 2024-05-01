using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Centr
{
    public partial class все_видеоролики : Form
    {
        public все_видеоролики()
        {
            InitializeComponent();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Сортировать_button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Сортировка_textBox1.Text);
            string sql = "SELECT id_vid AS \"Код видео\", name AS \"Название видеоролика\","
                + " text AS \"Видеоролик\" FROM video" + " ORDER BY \"" + a + "\"";
            Form1.Table_Fill("Все видеоролики", sql);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_vid AS \"Код видео\", name AS \"Название видеоролика\","
                + " text AS \"Видеоролик\" FROM video" + " ORDER BY \"Код видео\"";
            Form1.Table_Fill("Все видеоролики", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Все видеоролики"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            int numRows = dataGridView1.Rows.Count;
            Всего_видеороликов_textBox1.Text = numRows.ToString();

            dataGridView1.Columns["Видеоролик"].DefaultCellStyle.ForeColor = Color.Blue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверка, что нажата конкретная ячейка с ссылкой
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                // Получение значения ячейки с ссылкой
                string url = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Открытие ссылки в браузере по умолчанию
                Process.Start(url);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Видео_лекции.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код видео"].Value.ToString();
            Видео_лекции видео_Лекции = new Видео_лекции();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(видео_Лекции.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }
    }
}
