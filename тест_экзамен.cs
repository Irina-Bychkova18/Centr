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
    public partial class тест_экзамен : Form
    {
        public тест_экзамен()
        {
            InitializeComponent();
        }
        public static int k = 0;
        private void FieldsForm_Fill()
        {
            Название_textBox1.Text = Form1.cdt.Tables["Домашнее задание"].Rows[k]["Название домашнего задания"].ToString();
            Ссылка_на_домашнее_задание_textBox1.Text = Form1.cdt.Tables["Домашнее задание"].Rows[k]["Ссылка на домашнее задание"].ToString();

        }

        private void FieldsForm_Clear()
        {
            Название_textBox1.Text = "";
            Ссылка_на_домашнее_задание_textBox1.Text = "";
        }
        public static string n = null;
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public void field()
        {
            string sql = "SELECT id_dz AS \"Код домашнего задания\", name AS \"Название домашнего задания\","
                + " text AS \"Ссылка на домашнее задание\" FROM dz" + " ORDER BY \"Код домашнего задания\"";
            Form1.Table_Fill("Домашнее задание", sql);

            int i = 0;
            k = 0;
            while (Form1.cdt.Tables["Домашнее задание"].Rows[i]["Код домашнего задания"].ToString() != n)
            {
                i++;
                k++;
            }

            Название_textBox1.Text = Form1.cdt.Tables["Домашнее задание"].Rows[i]["Название домашнего задания"].ToString();
            Ссылка_на_домашнее_задание_textBox1.Text = Form1.cdt.Tables["Домашнее задание"].Rows[i]["Ссылка на домашнее задание"].ToString();

            Form1.cdt.Tables["Домашнее задание"].DefaultView.RowFilter = "[Код домашнего задания]=" + n;
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {

            field();
      
            
        }

        

        private void Вперед_button1_Click(object sender, EventArgs e)
        {
            if (k < Form1.cdt.Tables["Домашнее задание"].Rows.Count) k++;
            if (Form1.cdt.Tables["Домашнее задание"].Rows.Count > k)
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
            if (Form1.cdt.Tables["Домашнее задание"].Rows.Count > 0)
            {
                k = 0; FieldsForm_Fill();
            }
        }

        private void В_конец_button5_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            k = Form1.cdt.Tables["Домашнее задание"].Rows.Count;
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
