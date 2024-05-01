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
    public partial class Записи_на_курс : Form
    {
        public Записи_на_курс()
        {
            InitializeComponent();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_zap AS \"Номер записи\", fio AS \"ФИО ученика\","
                + " kursi.name AS \"Название курса\","
               + " dni.name AS \"Дни работы\", vrema.name AS \"Время работы\" FROM (((zapis inner join kursi on kursi.id_kursi = zapis.id_kursi)"
               + "left join dni on dni.id_dni = zapis.id_dni) left join vrema on vrema.id_vrema = zapis.id_vrema) where kursi.id_kursi = zapis.id_kursi and dni.id_dni = zapis.id_dni and vrema.id_vrema = zapis.id_vrema" +
               " GROUP BY id_zap, fio, kursi.name, dni.name, vrema.name ORDER BY \"Номер записи\"";
            Form1.Table_Fill("Записи", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Записи"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            int numRows = dataGridView1.Rows.Count;
            Всего_записей_textBox1.Text = numRows.ToString();

           
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }
    }
}
