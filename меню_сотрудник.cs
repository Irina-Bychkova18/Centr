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
    }
}
