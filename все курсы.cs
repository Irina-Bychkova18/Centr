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
    public partial class все_курсы : Form
    {
        public все_курсы()
        {
            InitializeComponent();
            //ret();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {

        }

     
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\","
              + " kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", " +
              "information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"";
            Form1.Table_Fill("Курсы", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Курсы"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            int numRows = dataGridView1.Rows.Count;
            Всего_курсов_textBox1.Text = numRows.ToString();

        
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Всего_курсов_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
