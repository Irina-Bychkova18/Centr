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
    public partial class курсы : Form
    {
        public курсы()
        {
            InitializeComponent();
        }
        public static int k = 0;
        private void FieldsForm_Fill()
        {
            Название_textBox1.Text = Form1.cdt.Tables["Курс"].Rows[k]["Название курса"].ToString();
            Всего_мест_textBox3.Text = Form1.cdt.Tables["Курс"].Rows[k]["Количество мест всего"].ToString();
            Оставшиеся_места_textBox2.Text = Form1.cdt.Tables["Курс"].Rows[k]["Количество оставшихся мест"].ToString();
            Информация_textBox1.Text = Form1.cdt.Tables["Курс"].Rows[k]["Информация о курсе"].ToString();

        }

        private void FieldsForm_Clear()
        {
            Название_textBox1.Text = "";
            Всего_мест_textBox3.Text = "";
            Оставшиеся_места_textBox2.Text = "";
            Информация_textBox1.Text = "";
        }

        public static string n = null;
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\","
              + " kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", " +
              "information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"";
            Form1.Table_Fill("Курс", sql);

            int i = 0;
            while (Form1.cdt.Tables["Курс"].Rows[i]["Код курса"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Курс"].Rows[i]["Название курса"].ToString();
            Всего_мест_textBox3.Text = Form1.cdt.Tables["Курс"].Rows[i]["Количество мест всего"].ToString();
            Оставшиеся_места_textBox2.Text = Form1.cdt.Tables["Курс"].Rows[i]["Количество оставшихся мест"].ToString();
            Информация_textBox1.Text = Form1.cdt.Tables["Курс"].Rows[i]["Информация о курсе"].ToString();

            Form1.cdt.Tables["Курс"].DefaultView.RowFilter = "[Код курса]=" + n;


            

            
        }

        

        private void Записаться_на_курс_button1_Click(object sender, EventArgs e)
        {
            Записаться_на_курс записаться_На_Курс = new Записаться_на_курс();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(записаться_На_Курс.tabControl1.TabPages[0]);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Вперед_button1_Click(object sender, EventArgs e)
        {
            if (k < Form1.cdt.Tables["Курс"].Rows.Count) k++;
            if (Form1.cdt.Tables["Курс"].Rows.Count > k)
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
            if (Form1.cdt.Tables["Курс"].Rows.Count > 0)
            {
                k = 0; FieldsForm_Fill();
            }
        }

        private void В_конец_button5_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            k = Form1.cdt.Tables["Курс"].Rows.Count;
        }
    }
}
