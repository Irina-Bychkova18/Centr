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
        public int numRows;
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_zap AS \"Номер записи\", uchenik.fio AS \"ФИО ученика\","
                + " kursi.name AS \"Название курса\","
               + " dni.name AS \"Дни работы\", vrema.name AS \"Время работы\" FROM ((((zapis inner join kursi on kursi.id_kursi = zapis.id_kursi)"
               + "left join dni on dni.id_dni = zapis.id_dni) left join vrema on vrema.id_vrema = zapis.id_vrema) left join uchenik on uchenik.id_uch = zapis.id_uch) where kursi.id_kursi = zapis.id_kursi and dni.id_dni = zapis.id_dni and vrema.id_vrema = zapis.id_vrema and uchenik.id_uch = zapis.id_uch" +
               " GROUP BY id_zap, uchenik.fio, kursi.name, dni.name, vrema.name ORDER BY \"Номер записи\"";
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

        private void Удалить_запись_button5_Click(object sender, EventArgs e)
        {
            string kod;
            try
            {
                kod = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Номер записи"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не указан удаляемый экземпляр!!!", "Ошибка"); return;
            }
            string message = "Вы точно хотите удалить запись № " + kod + "?";
            string caption = "Удаление записи";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }
            string sql = "DELETE FROM zapis WHERE id_zap = " + kod;
            Form1.Modification_Execute(sql);
            for (int i = Form1.cdt.Tables["Записи"].Rows.Count - 1; i >= 0; i--)
                if (Form1.cdt.Tables["Записи"].Rows[i]["Номер записи"].ToString() == kod)
                {
                    Form1.cdt.Tables["Записи"].Rows.RemoveAt(i);
                    dataGridView1.CurrentCell = null;
                    return;
                }
        }

        private void Добавить_запись_button1_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            Добавление_записи.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Номер записи"].Value.ToString();
            Добавление_записи добавление_записи = new Добавление_записи(numRows);
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(добавление_записи.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
