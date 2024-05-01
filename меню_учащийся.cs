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
    
    public partial class меню_учащийся : Form
    {
        public меню_учащийся()
        {
            InitializeComponent();
        }
        string data = "";
        private void курсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_курсы_сотрудник Все_Курсы_сотрудник = new все_курсы_сотрудник();
            Form1.tabControl1.Controls.Add(Все_Курсы_сотрудник.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void расписаниеЗанятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Расписание_занятий расписание_Занятий = new Расписание_занятий();
            Form1.tabControl1.Controls.Add(расписание_Занятий.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void записатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Записаться_на_курс записаться_На_Курс = new Записаться_на_курс();
            Form1.tabControl1.Controls.Add(записаться_На_Курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация(data);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Личный_кабинет личный_Кабинет = new Личный_кабинет();
            Form1.tabControl1.Controls.Add(личный_Кабинет.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void записьНаКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void текстовыеЛекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Все_текстовые_лекции все_Текстовые_Лекции = new Все_текстовые_лекции();
            Form1.tabControl1.Controls.Add(все_Текстовые_Лекции.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void видеороликиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_видеоролики все_Видеоролики = new все_видеоролики();
            Form1.tabControl1.Controls.Add(все_Видеоролики.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
