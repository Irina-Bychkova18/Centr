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
    public partial class меню_админ : Form
    {
        public меню_админ()
        {
            InitializeComponent();
        }
        string data = "";
        private void робототехникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            курсы Курсы = new курсы();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Курсы.tabControl1.TabPages[0]);
        }

        private void текстовыеЛекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_текстовые_лекции_админ все_Текстовые_Лекции_Админ = new все_текстовые_лекции_админ();
            Form1.tabControl1.Controls.Add(все_Текстовые_Лекции_Админ.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void видеороликиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_видеоролики_админ все_Видеоролики_Админ = new все_видеоролики_админ();
            Form1.tabControl1.Controls.Add(все_Видеоролики_Админ.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сотрудники сотрудники = new Сотрудники();
            Form1.tabControl1.Controls.Add(сотрудники.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void расписаниеЗанятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Расписание_занятий расписание_Занятий = new Расписание_занятий();
            Form1.tabControl1.Controls.Add(расписание_Занятий.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void моиЗанятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Мои_занятия мои_Занятия = new Мои_занятия();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(мои_Занятия.tabControl1.TabPages[0]);
        }

        private void записьНаКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void записатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Записаться_на_курс записаться_На_Курс = new Записаться_на_курс();
            Form1.tabControl1.Controls.Add(записаться_На_Курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void моиКурсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Мои_курсы мои_Курсы = new Мои_курсы();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(мои_Курсы.tabControl1.TabPages[0]);
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Посещаемость посещаемость = new Посещаемость();
            Form1.tabControl1.Controls.Add(посещаемость.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void журналМатериалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Журнал_материала журнал_Материала = new Журнал_материала();
            Form1.tabControl1.Controls.Add(журнал_Материала.tabControl1.TabPages[0]);
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
            Личный_кабинет личный_Кабинет = new Личный_кабинет();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(личный_Кабинет.tabControl1.TabPages[0]);
        }

        private void лекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            
            Главная главная = new Главная();
            Form1.tabControl1.Controls.Add(главная.tabControl1.TabPages[0]);
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;

        }



        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void курсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_курсы Все_Курсы = new все_курсы();
            Form1.tabControl1.Controls.Add(Все_Курсы.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void домашнее_задание_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            все_тесты_и_экзамены_админ Все_тесты_и_экзамены_админ = new все_тесты_и_экзамены_админ();
            Form1.tabControl1.Controls.Add(Все_тесты_и_экзамены_админ.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void учащиесяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Учащиеся учащиеся = new Учащиеся();
            Form1.tabControl1.Controls.Add(учащиеся.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void записатьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Записаться_на_курс записаться_На_Курс = new Записаться_на_курс();
            Form1.tabControl1.Controls.Add(записаться_На_Курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void записиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Записи_на_курс записи_на_курс = new Записи_на_курс();
            Form1.tabControl1.Controls.Add(записи_на_курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
