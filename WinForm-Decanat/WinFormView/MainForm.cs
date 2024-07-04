using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormView
{
    public partial class MainForm : Form
    {
        BarChartForm f2;
        Logic logic = new Logic();
        public MainForm()
        {
            InitializeComponent();
            RefreshList();
        }

        public void RefreshList()
        {
            listView1.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("ФИО", 200);
            listView1.Columns.Add("Cпециальность", 200);
            listView1.Columns.Add("Группа", 70);

            for (int i = 0; i < logic.GetStudentsInfo().Count(); i++)
            {

                ListViewItem newitem = new ListViewItem(logic.GetStudentsInfo().ElementAt(i));
                newitem.SubItems.Add(Convert.ToString(logic.GetStudentsInfo().ElementAt(i + 1)));
                newitem.SubItems.Add(Convert.ToString(logic.GetStudentsInfo().ElementAt(i + 2)));
                i += 2;

                listView1.Items.Add(newitem);
            }
        }

        private void add_Student_Button(object sender, EventArgs e)
        {
            logic.AddStudent(textBox1.Text, textBox2.Text, textBox3.Text);
            RefreshList();
            if (f2 != null)
            {
                f2.UpdateGraphs(logic);
            }
        }

        private void delete_Student_Button(object sender, EventArgs e)
        {
            if (logic.GetStudentsInfo().Count() != 0)
            {
                logic.DeleteStudent(listView1.SelectedIndices[0]);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            if (f2 != null)
            {
                f2.UpdateGraphs(logic);
            }  
;       }

        private void show_Form2_Button(object sender, EventArgs e)
        {
            f2 = new BarChartForm(logic);

            f2.Show();
        }
    }
}
