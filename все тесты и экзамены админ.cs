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
    public partial class все_тесты_и_экзамены_админ : Form
    {
        public все_тесты_и_экзамены_админ()
        {
            InitializeComponent();
        }
        public int numRows;
        private void tabPage1_Click(object sender, EventArgs e)
        {

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

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_dz AS \"Код домашнего задания\", name AS \"Название домашнего задания\","
                + " text AS \"Ссылка на домашнее задание\" FROM dz" + " ORDER BY \"Код домашнего задания\"";
            Form1.Table_Fill("Все домашнее задание", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Все домашнее задание"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            int numRows = dataGridView1.Rows.Count;
            Всего_лекций_textBox1.Text = numRows.ToString();

            dataGridView1.Columns["Ссылка на домашнее задание"].DefaultCellStyle.ForeColor = Color.Blue;
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Удалить_домашнее_задание_button5_Click(object sender, EventArgs e)
        {
            string kod;
            try
            {
                kod = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код домашнего задания"].Value.ToString();
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
            string sql = "DELETE FROM dz WHERE id_dz = " + kod;
            Form1.Modification_Execute(sql);
            for (int i = Form1.cdt.Tables["Все домашнее задание"].Rows.Count - 1; i >= 0; i--)
                if (Form1.cdt.Tables["Все домашнее задание"].Rows[i]["Код домашнего задания"].ToString() == kod)
                {
                    Form1.cdt.Tables["Все домашнее задание"].Rows.RemoveAt(i);
                    dataGridView1.CurrentCell = null;
                    return;
                }
        }

        private void Добавить_домашнее_задание_button1_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            добавить_тест_экзамен Добавить_тест_экзамен = new добавить_тест_экзамен(numRows);
            Form1.tabControl1.Controls.Add(Добавить_тест_экзамен.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            тест_экзамен.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код домашнего задания"].Value.ToString();
            тест_экзамен Тест_экзамен = new тест_экзамен();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(Тест_экзамен.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Сортировать_button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Сортировка_textBox1.Text);
            string sql = "SELECT id_dz AS \"Код домашнего задания\", name AS \"Название домашнего задания\","
                + " text AS \"Ссылка на домашнее задание\" FROM dz" + " ORDER BY \"" + a + "\"";
            Form1.Table_Fill("Все домашнее задание", sql);
            
        }

        private void Изменить_button1_Click(object sender, EventArgs e)
        {
            Изменить_домашнее_задание.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код домашнего задания"].Value.ToString();
            Изменить_домашнее_задание изменить_домашнее_задание = new Изменить_домашнее_задание();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(изменить_домашнее_задание.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
