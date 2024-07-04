using SharedView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model;
using Presenter;
using static System.Windows.Forms.ListView;

namespace WinView
{
    public partial class Form1 : Form, IView
    {
        public event EventHandler<StudentArgs> EventStudentAddView = delegate { };
        public event EventHandler<StudentArgs> EventStudentRemoveView = delegate { };
        public event EventHandler<StudentArgs> EventStudentGetStudentsView = delegate { };

        private IModel model = null;
        private PresenterStudent presenter;
    
        List<string> Students = new List<string>();

        Form2 f2;
        public Form1()
        {
            InitializeComponent();

            model = new StudentModel();
            presenter = new PresenterStudent(this, model);
                        
        }
        public void AddStudent(List<string> students, Student student)
        {
            ListViewItem additem = new ListViewItem(student.Name);
            additem.SubItems.Add(student.Speciality);
            additem.SubItems.Add(student.Group);
            listView1.Items.Add(additem);

            this.Students = students;

            if (f2 != null) 
                if(f2.Visible) f2.UpdateGraph(students);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                Student student = new Student()
                {
                    Name = textBox1.Text,
                    Group = textBox3.Text,
                    Speciality = textBox3.Text
                };

                EventStudentAddView(this, new StudentArgs(student));
            }
        }

        public void RemoveStudent(List<string> students)
        {            
            listView1.Items.Remove(listView1.SelectedItems[0]);
            this.Students = students;

            if (f2 != null)
                if (f2.Visible) f2.UpdateGraph(students);
        }

        private void ShowGraphs_Click(object sender, EventArgs e)
        {
            f2 = new Form2(Students);
            f2.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Student student = new Student()
                {
                    Name = listView1.SelectedItems[0].SubItems[0].Text,
                    Speciality = listView1.SelectedItems[0].SubItems[1].Text,
                    Group = listView1.SelectedItems[0].SubItems[2].Text
                };
                EventStudentRemoveView(this, new StudentArgs(student));
            }

        }
        public void GetStudents(List<string> students)
        {
            this.Students = students;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EventStudentGetStudentsView(this, new StudentArgs());

            listView1.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("Имя", 150);
            listView1.Columns.Add("Cпециальность", 150);
            listView1.Columns.Add("Группа", 126);

            for (int i = 0; i < Students.Count; i += 3)
            {
                ListViewItem newitem = new ListViewItem(Students.ElementAt(i));
                newitem.SubItems.Add(Students.ElementAt(i + 1));
                newitem.SubItems.Add(Students.ElementAt(i + 2));

                listView1.Items.Add(newitem);
            }
        }
    }
}
