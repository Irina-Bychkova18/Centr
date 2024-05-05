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
    public partial class меню_сотрудник : Form
    {
        public меню_сотрудник()
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

        private void текстовыеЛекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_текстовые_лекции_админ все_Текстовые_Лекции_Админ = new все_текстовые_лекции_админ();
            Form1.tabControl1.Controls.Add(все_Текстовые_Лекции_Админ.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void расписаниеЗанятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Расписание_занятий расписание_Занятий = new Расписание_занятий();
            Form1.tabControl1.Controls.Add(расписание_Занятий.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация(data);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void видеороликиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_видеоролики_админ все_Видеоролики_Админ = new все_видеоролики_админ();
            Form1.tabControl1.Controls.Add(все_Видеоролики_Админ.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void тестыИЭкзаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_тесты_и_экзамены_админ Все_тесты_и_экзамены_админ = new все_тесты_и_экзамены_админ();
            Form1.tabControl1.Controls.Add(Все_тесты_и_экзамены_админ.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Посещаемость посещаемость = new Посещаемость();
            Form1.tabControl1.Controls.Add(посещаемость.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void успеваемостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Успеваемость успеваемость = new Успеваемость();
            Form1.tabControl1.Controls.Add(успеваемость.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Личный_кабинет_сотрудника личный_кабинет_сотрудника = new Личный_кабинет_сотрудника();
            Form1.tabControl1.Controls.Add(личный_кабинет_сотрудника.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void записиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Записи_на_курс записи_на_курс = new Записи_на_курс();
            Form1.tabControl1.Controls.Add(записи_на_курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void записатьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Записаться_на_курс записаться_На_Курс = new Записаться_на_курс();
            Form1.tabControl1.Controls.Add(записаться_На_Курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
