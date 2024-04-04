using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Centr
{
    public partial class Расписание_занятий : Form
    {
        public Расписание_занятий()
        {
            InitializeComponent();
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            меню Меню = new меню();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {

        }
        private void ret()
        {
            string sql = "SELECT id_raspisania AS \"Код расписания\", kursi.name AS \"Название курса\","
               + " dni.name AS \"Дни работы\", vrema.name AS \"Время работы\" FROM (((raspisanie inner join kursi on kursi.id_kursi = raspisanie.id_kursi)"
               + "left join dni on dni.id_dni = raspisanie.id_dni) left join vrema on vrema.id_vrema = raspisanie.id_vrema) where kursi.id_kursi = raspisanie.id_kursi and dni.id_dni = raspisanie.id_dni and vrema.id_vrema = raspisanie.id_vrema" +
               " GROUP BY id_raspisania, kursi.name, dni.name, vrema.name ORDER BY \"Код расписания\"";
            Form1.Table_Fill("Расписание", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Расписание"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            Дни_работы_comboBox1.DataSource = Form1.cdt.Tables["Расписание"].DefaultView;
            Дни_работы_comboBox1.DisplayMember = "Дни работы";

            Временной_промежуток_comboBox1.DataSource = Form1.cdt.Tables["Расписание"].DefaultView;
            Временной_промежуток_comboBox1.DisplayMember = "Время работы";
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ret();
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Распечатать_расписание_button1_Click(object sender, EventArgs e)
        {
            Excel.Application Excel_ = new Excel.Application();
            Excel_.Visible = true;
            Excel.Workbook Workbook_ = Excel_.Workbooks.Add();
            Excel.Worksheet Sheet_ = (Excel.Worksheet)Workbook_.Sheets[1];

            Sheet_.Cells[1, 1].Value = "Расписание";
            Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[1, 4]].Merge();
            Sheet_.Cells[1, 1].HorizontalAlignment = 3;

            Sheet_.Cells[2, 1].Value = dataGridView1.Columns["Код расписания"].HeaderText;
            Sheet_.Cells[2, 2].Value = dataGridView1.Columns["Название курса"].HeaderText;
            Sheet_.Cells[2, 3].Value = dataGridView1.Columns["Дни работы"].HeaderText;
            Sheet_.Cells[2, 4].Value = dataGridView1.Columns["Время работы"].HeaderText;

            Sheet_.Range[Sheet_.Cells[2, 1], Sheet_.Cells[2, 3]].HorizontalAlignment = 3;

            int n = 3;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Sheet_.Cells[n, 1].Value = dataGridView1.Rows[i].Cells["Код расписания"].Value;
                Sheet_.Cells[n, 2].Value = dataGridView1.Rows[i].Cells["Название курса"].Value;
                Sheet_.Cells[n, 3].Value = dataGridView1.Rows[i].Cells["Дни работы"].Value;
                Sheet_.Cells[n, 4].Value = dataGridView1.Rows[i].Cells["Время работы"].Value;
                n++;
            }
            Sheet_.Range[Sheet_.Cells[3, 1], Sheet_.Cells[3 + dataGridView1.RowCount, 3]].HorizontalAlignment = 3;
            Sheet_.Range[Sheet_.Cells[3, 4], Sheet_.Cells[3 + dataGridView1.RowCount, 4]].HorizontalAlignment = 4;
            Sheet_.Range[Sheet_.Cells[2, 1], Sheet_.Cells[2 + dataGridView1.RowCount, 4]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous ;
            Sheet_.Cells.Columns.EntireColumn.AutoFit();
        }

        private void Показать_button2_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Дни_работы_comboBox1.Text);
            string b = Convert.ToString(Временной_промежуток_comboBox1.Text);
            string sql = "SELECT id_raspisania AS \"Код расписания\", kursi.name AS \"Название курса\","
               + " dni.name AS \"Дни работы\", vrema.name AS \"Время работы\" FROM (((raspisanie inner join kursi on kursi.id_kursi = raspisanie.id_kursi)"
               + "left join dni on dni.id_dni = raspisanie.id_dni) left join vrema on vrema.id_vrema = raspisanie.id_vrema) where kursi.id_kursi = raspisanie.id_kursi and dni.id_dni = raspisanie.id_dni " +
               "and vrema.id_vrema = raspisanie.id_vrema and dni.name = '" + a +
               "' and vrema.name = '" + b + "' GROUP BY id_raspisania, kursi.name, dni.name, vrema.name ORDER BY \"Код расписания\"";
            Form1.Table_Fill("Расписание", sql);
        }

        private void Назад_button1_Click(object sender, EventArgs e)
        {
            ret();
        }
    }
}
