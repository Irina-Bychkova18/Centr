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
            Расписание_занятий_учащийся расписание_Занятий_учащийся = new Расписание_занятий_учащийся();
            Form1.tabControl1.Controls.Add(расписание_Занятий_учащийся.tabControl1.TabPages[0]);
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
            Главная главная = new Главная();
            Form1.tabControl1.Controls.Add(главная.tabControl1.TabPages[0]);
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
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

        private void тестыИЭкзаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_тесты_и_экзамены Все_тесты_и_экзамены = new все_тесты_и_экзамены();
            Form1.tabControl1.Controls.Add(Все_тесты_и_экзамены.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void моиЗанятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Мои_занятия мои_занятия = new Мои_занятия();
            Form1.tabControl1.Controls.Add(мои_занятия.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void моиКурсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Мои_курсы мои_курсы = new Мои_курсы();
            Form1.tabControl1.Controls.Add(мои_курсы.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Посещаемость_учащегося посещаемость_учащегося = new Посещаемость_учащегося();
            Form1.tabControl1.Controls.Add(посещаемость_учащегося.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void успеваемостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Успеваемость_учащегося успеваемость_учащегося = new Успеваемость_учащегося();
            Form1.tabControl1.Controls.Add(успеваемость_учащегося.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
