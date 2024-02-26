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
    public partial class Выбор_центра : Form
    {
        public Выбор_центра()
        {
            InitializeComponent();
        }
        public static int n = 0;
        private void FieldsForm_Fill()
        {

            Выборка_центра_combobox.Text = Form1.cdt.Tables["Центры"].Rows[n]["Название"].ToString();
        }

        private void FieldsForm_Clear()
        {
            Выборка_центра_combobox.Text = "";
        }
        private void Далее_button_Click(object sender, EventArgs e)
        {
            //if (Выборка_центра_combobox.SelectedIndex == 0)
            //{
                вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация();
                Form1.tabControl1.TabPages.RemoveAt(0);
                Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
            //}
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
           
            Form1.Table_Fill("Центры", "SELECT id_centra AS \"Код_центра\", name AS \"Название_центра\", id_ruk AS \"fio\" FROM centr, rukovoditeli left join rukovoditeli on centr.id_ruk = rukovoditeli.id_ruk ORDER BY \"Код_центра\"");
            Выборка_центра_combobox.DataSource = Form1.cdt.Tables["Центры"].DefaultView;
            Выборка_центра_combobox.DisplayMember = "centr.name";
            if (Form1.cdt.Tables["Центры"].Rows.Count > n)
                FieldsForm_Fill();
        }

        private void Назад_button_Click(object sender, EventArgs e)
        {
            Главная главная = new Главная();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(главная.tabControl1.TabPages[0]);
        }

        private void Выборка_центра_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
