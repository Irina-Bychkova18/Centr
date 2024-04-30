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
    public partial class текстовая_лекция : Form
    {
        public текстовая_лекция()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {

        }
        public static int k = 0;
        private void FieldsForm_Fill()
        {
            Название_textBox1.Text = Form1.cdt.Tables["Текстовая лекция"].Rows[k]["Название лекции"].ToString();
            Ссылка_на_лекцию_textBox1.Text = Form1.cdt.Tables["Текстовая лекция"].Rows[k]["Текст лекции"].ToString();

        }

        private void FieldsForm_Clear()
        {
            Название_textBox1.Text = "";
            Ссылка_на_лекцию_textBox1.Text = "";
        }
        public static string n = null;
        public void field()
        {
            string sql = "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\","
                + " text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"";
            Form1.Table_Fill("Текстовая лекция", sql);

            int i = 0;
            k = 0;
            while (Form1.cdt.Tables["Текстовая лекция"].Rows[i]["Код лекции"].ToString() != n)
            {
                i++; 
                k++;
            }
                
            Название_textBox1.Text = Form1.cdt.Tables["Текстовая лекция"].Rows[i]["Название лекции"].ToString();
            Ссылка_на_лекцию_textBox1.Text = Form1.cdt.Tables["Текстовая лекция"].Rows[i]["Текст лекции"].ToString();

            Form1.cdt.Tables["Текстовая лекция"].DefaultView.RowFilter = "[Код лекции]=" + n;
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            field();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Вперед_button1_Click(object sender, EventArgs e)
        {
            if (k < Form1.cdt.Tables["Текстовая лекция"].Rows.Count) k++;
            if (Form1.cdt.Tables["Текстовая лекция"].Rows.Count > k)
            {
                FieldsForm_Fill();
            }
            else
            {
                FieldsForm_Clear();
            }
        }

        

        private void Назад_button2_Click(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--; FieldsForm_Fill();
            }
        }

        private void В_начало_button3_Click(object sender, EventArgs e)
        {
            if (Form1.cdt.Tables["Текстовая лекция"].Rows.Count > 0)
            {
                k = 0; FieldsForm_Fill();
            }
        }

        private void В_конец_button5_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            k = Form1.cdt.Tables["Текстовая лекция"].Rows.Count;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Название_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
