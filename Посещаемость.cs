using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Centr
{
    public partial class Посещаемость : Form
    {
        public Посещаемость()
        {
            InitializeComponent();

            Название_столбца_textBox1.Text = "d_22_04";
            Название_столбца_textBox1.ForeColor = Color.Gray;
        }
        List<Tuple<int, int, bool>> changedBoolData = new List<Tuple<int, int, bool>>(); // Коллекция для хранения измененных данных типа boolean
        private void ret()
        {
            string sql = "SELECT id_pos AS \"Номер\", uchenik.fio AS \"ФИО ученика\" FROM (poseshaemost inner join uchenik on uchenik.id_uch = poseshaemost.id_uch)"
               + " where uchenik.id_uch = poseshaemost.id_uch" +
               " GROUP BY id_pos, uchenik.fio ORDER BY \"Номер\"";
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

            string sql1 = "SELECT * FROM poseshaemost ORDER BY id_pos";
            Form1.Table_Fill("Даты", sql1);

            //dataGridView2.Rows[0].Height = 15;
            dataGridView2.DataSource = Form1.cdt.Tables["Даты"];
            
            dataGridView2.Columns["id_uch"].Visible = false;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;
            dataGridView2.AutoResizeColumns();
            dataGridView2.CurrentCell = null;

            dataGridView2.ReadOnly = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ret();
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

        private void Название_столбца_textBox1_Enter(object sender, EventArgs e)
        {
            Название_столбца_textBox1.Text = "";
            Название_столбца_textBox1.ForeColor = Color.Black;
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string newValue = cell.Value.ToString();
        }

        private void Сохранить_изменения_button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5433;User Id = postgres; Password=toor;Database=center;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    foreach (var data in changedBoolData)
                    {
                        int rowId = data.Item1;
                        int columnIdx = data.Item2;
                        bool cellValue = data.Item3;

                        string columnName = dataGridView2.Columns[columnIdx].Name;

                        cmd.CommandText = $"UPDATE poseshaemost SET {columnName} = @value WHERE id_pos = @rowId";
                        cmd.Parameters.AddWithValue("@value", cellValue);
                        cmd.Parameters.AddWithValue("@rowId", rowId);
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                    }
                }
            }
            ret();
            MessageBox.Show("Данные успешно изменены!");
            // Очистка коллекции измененных данных
            changedBoolData.Clear();
        }
    

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView2.Columns[e.ColumnIndex].ValueType == typeof(bool))
            {
                int rowId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["id_pos"].Value);
                bool cellValue = Convert.ToBoolean(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                changedBoolData.Add(new Tuple<int, int, bool>(rowId, e.ColumnIndex, cellValue));
            }
        }
    }
}
