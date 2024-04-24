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
    public partial class Успеваемость : Form
    {
        public Успеваемость()
        {
            InitializeComponent();
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            меню_админ Меню = new меню_админ();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_usp AS \"Номер записи\", uchenik.fio AS \"ФИО\", lekcii.name AS \"Название лекции\","
                   + " proideno_lekcii_fl AS \"Пройдено лекций\", vsego_lekcii_fl AS \"Всего лекций\",  (proideno_lekcii_fl/vsego_lekcii_fl)*100 AS \"Процент успеваемости\" FROM ((uspevaemost inner join uchenik on uchenik.id_uch = uspevaemost.id_uch)"
                   + "left join lekcii on lekcii.id_lek = uspevaemost.id_lek) where uchenik.id_uch = uspevaemost.id_uch and lekcii.id_lek = uspevaemost.id_lek" +
                   " GROUP BY id_usp, uchenik.fio, lekcii.name, proideno_lekcii_fl, vsego_lekcii_fl ORDER BY \"Номер записи\"";
            Form1.Table_Fill("Успеваемость", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Успеваемость"];
            dataGridView1.Columns["Пройдено лекций"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["Всего лекций"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["Процент успеваемости"].DefaultCellStyle.Format = "0\\% ";
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
            string sql = "DELETE FROM uspevaemost WHERE id_usp = " + kod;
            Form1.Modification_Execute(sql);
            for (int i = Form1.cdt.Tables["Успеваемость"].Rows.Count - 1; i >= 0; i--)
                if (Form1.cdt.Tables["Успеваемость"].Rows[i]["Номер записи"].ToString() == kod)
                {
                    Form1.cdt.Tables["Успеваемость"].Rows.RemoveAt(i);
                    dataGridView1.CurrentCell = null;
                    return;
                }
        }

        private void Добавить_запись_button1_Click(object sender, EventArgs e)
        {
            Добавить_успеваемость добавить_успеваемость = new Добавить_успеваемость();
            Form1.tabControl1.Controls.Add(добавить_успеваемость.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Изменить_запись_button2_Click(object sender, EventArgs e)
        {
            Изменить_успеваемость.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Номер записи"].Value.ToString();
            Изменить_успеваемость изменить_успеваемость = new Изменить_успеваемость();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(изменить_успеваемость.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;

        }
    }
}
