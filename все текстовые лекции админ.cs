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
    public partial class все_текстовые_лекции_админ : Form
    {
        public все_текстовые_лекции_админ()
        {
            InitializeComponent();
            
           
        }
        public int numRows;


        private void Выход_button4_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            
            string sql = "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\","
                + " text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"";
            Form1.Table_Fill("Все текстовые лекции", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Все текстовые лекции"];
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

            dataGridView1.Columns["Текст лекции"].DefaultCellStyle.ForeColor = Color.Blue;

            
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Удалить_лекцию_button5_Click(object sender, EventArgs e)
        {
            string kod;
            try
            {
                kod = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код лекции"].Value.ToString();
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
            string sql = "DELETE FROM lekcii WHERE id_lek = " + kod;
            Form1.Modification_Execute(sql);
            for (int i = Form1.cdt.Tables["Все текстовые лекции"].Rows.Count - 1; i >= 0; i--)
                if (Form1.cdt.Tables["Все текстовые лекции"].Rows[i]["Код лекции"].ToString() == kod)
                {
                    Form1.cdt.Tables["Все текстовые лекции"].Rows.RemoveAt(i);
                    dataGridView1.CurrentCell = null;
                    return;
                }
        }
        private void AddLinkColumn()
        {
            DataGridViewLinkColumn links = new DataGridViewLinkColumn();

            links.UseColumnTextForLinkValue = true;
            
            links.ActiveLinkColor = Color.White;
            links.LinkBehavior = LinkBehavior.SystemDefault;
            links.LinkColor = Color.Blue;
            links.TrackVisitedState = true;
            links.VisitedLinkColor = Color.YellowGreen;

            dataGridView1.Columns.Add(links);
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

        private void Всего_лекций_textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Всего_лекций_textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            Всего_лекций_textBox1.Text = numRows.ToString();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void все_текстовые_лекции_админ_Load(object sender, EventArgs e)
        {

        }

        private void Всего_лекций_textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Добавить_лекцию_button1_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            Добавить_лекцию добавить_лекцию = new Добавить_лекцию(numRows);
            Form1.tabControl1.Controls.Add(добавить_лекцию.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            текстовая_лекция.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код лекции"].Value.ToString();
            текстовая_лекция текстовая_Лекция = new текстовая_лекция();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(текстовая_Лекция.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Сортировать_button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Сортировка_textBox1.Text);

            string sql = "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\","
                + " text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"" + a + "\"";
            Form1.Table_Fill("Все текстовые лекции", sql);
        }

        private void Изменить_button1_Click(object sender, EventArgs e)
        {
            Изменить_лекцию.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код лекции"].Value.ToString();
            Изменить_лекцию изменить_лекцию = new Изменить_лекцию();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(изменить_лекцию.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
