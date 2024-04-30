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
    public partial class Видео_лекции : Form
    {
        public Видео_лекции()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public static int k = 0;
        private void FieldsForm_Fill()
        {
            Название_textBox1.Text = Form1.cdt.Tables["Видеоролик"].Rows[k]["Название видеоролика"].ToString();
            Ссылка_на_видеоролик_textBox1.Text = Form1.cdt.Tables["Видеоролик"].Rows[k]["Видеоролик"].ToString();
        }

        private void FieldsForm_Clear()
        {
            Название_textBox1.Text = "";
            Ссылка_на_видеоролик_textBox1.Text = "";
        }
        public static string n = null;
        public void field()
        {
            string sql = "SELECT id_vid AS \"Код видео\", name AS \"Название видеоролика\","
                + " text AS \"Видеоролик\" FROM video" + " ORDER BY \"Код видео\"";
            Form1.Table_Fill("Видеоролик", sql);

            int i = 0;
            k = 0;
            while (Form1.cdt.Tables["Видеоролик"].Rows[i]["Код видео"].ToString() != n)
            {
                i++;
                k++;
            }

            Название_textBox1.Text = Form1.cdt.Tables["Видеоролик"].Rows[i]["Название видеоролика"].ToString();
            Ссылка_на_видеоролик_textBox1.Text = Form1.cdt.Tables["Видеоролик"].Rows[i]["Видеоролик"].ToString();

            Form1.cdt.Tables["Видеоролик"].DefaultView.RowFilter = "[Код видео]=" + n;
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            field();

        }

        private void Вперед_button1_Click(object sender, EventArgs e)
        {
            if (k < Form1.cdt.Tables["Видеоролик"].Rows.Count) k++;
            if (Form1.cdt.Tables["Видеоролик"].Rows.Count > k)
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
            if (Form1.cdt.Tables["Видеоролик"].Rows.Count > 0)
            {
                k = 0; FieldsForm_Fill();
            }
        }

        private void В_конец_button5_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            k = Form1.cdt.Tables["Видеоролик"].Rows.Count;
        }

        
    }
}
