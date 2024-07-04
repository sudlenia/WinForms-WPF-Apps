using System;
using System.Collections.Generic;

namespace Model
{
    public class StudentModel : IModel
    {
        public List<Student> Students { get; set; } = new List<Student>()
        {
            new Student{Name = "Boris", Group = "КИ22-01", Speciality = "E"},
            new Student{Name = "George", Group = "КИ22-03", Speciality = "W"},
            new Student{Name = "Bill", Group = "КИ22-06", Speciality = "Q"},
            new Student{Name = "neBoris", Group = "КИ22-06", Speciality = "Q"},
        };

        public event EventHandler<StudentArgs> EventStudentAddModel = delegate { };
        public event EventHandler<StudentArgs> EventStudentRemoveModel = delegate { };
        public event EventHandler<StudentArgs> EventStudentGetStudentsModel = delegate { };

        private List<string> list = new List<string>();

        public void AddStudent(Student student)
        {
            Students.Add(student);

            list.Clear();

            foreach (Student _student in Students)
            {
                list.Add(_student.Name);
                list.Add(_student.Speciality);
                list.Add(_student.Group);
            }

            EventStudentAddModel(this, new StudentArgs(list, student));
        }
        public void RemoveStudent(Student student)
        {
            foreach (Student _student in Students)
            {
                if (student.Name == _student.Name & student.Group == _student.Group & student.Speciality == _student.Speciality)
                {
                    student = _student;
                    break;
                }
            }
            Students.Remove(student);

            list.Clear();

            foreach (Student _student in Students)
            {
                list.Add(_student.Name);
                list.Add(_student.Speciality);
                list.Add(_student.Group);
            }

            EventStudentRemoveModel(this, new StudentArgs(list));
        }
        public void GetStudents()
        {
            list.Clear();

            foreach (Student _student in Students)
            {
                list.Add(_student.Name);
                list.Add(_student.Speciality);
                list.Add(_student.Group);
            }
            EventStudentGetStudentsModel(this, new StudentArgs(list));
        }
    }
}
