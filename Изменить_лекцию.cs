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
    public partial class Изменить_лекцию : Form
    {
        public Изменить_лекцию()
        {
            InitializeComponent();
        }
        public static string n = null;
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Изменить_button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (Form1.cdt.Tables["Текстовая лекция"].Rows[i]["Код лекции"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Текстовая лекция"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE lekcii SET name ='" + Название_textBox1.Text + "', text = '" + Ссылка_на_лекцию_textBox1.Text + "' WHERE id_lek = " + i;
                if (!Form1.Modification_Execute(sql))
                    return;
                MessageBox.Show("Запись успешно изменена!");
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\","
                + " text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"";
            Form1.Table_Fill("Текстовая лекция", sql);

            int i = 0;
            while (Form1.cdt.Tables["Текстовая лекция"].Rows[i]["Код лекции"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Текстовая лекция"].Rows[i]["Название лекции"].ToString();
            Ссылка_на_лекцию_textBox1.Text = Form1.cdt.Tables["Текстовая лекция"].Rows[i]["Текст лекции"].ToString();
            

            Form1.cdt.Tables["Текстовая лекция"].DefaultView.RowFilter = "[Код лекции]=" + n;
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
