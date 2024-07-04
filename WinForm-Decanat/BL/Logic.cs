using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class Logic
    {
        public List<Student> students { get; set; } = new List<Student>
        {
            new Student{Name = "Boris", Group = "КИ22-01", Speciality = "E"},
            new Student{Name = "George", Group = "КИ22-03", Speciality = "W"},
            new Student{Name = "Bill", Group = "КИ22-06", Speciality = "Q"},
            new Student{Name = "neBoris", Group = "КИ22-06", Speciality = "Q"},
        };

        
        public List<string> GetStudentsInfo()
        {
            List<string> list = new List<string>();
            foreach (Student stud in students)
            {
                list.Add(stud.Name);
                list.Add(stud.Speciality);
                list.Add(stud.Group);
            }
            return list;
        }

        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student { Name = name, Speciality = speciality, Group = group });
        }

        public void DeleteStudent(int index)
        {
            students.RemoveAt(index);
        }

        public List<string> GetSpeciality()
        {
            List<string> specialities = new List<string>(students
                                         .GroupBy(stud => stud.Speciality)
                                         .Select(g => g.Key)
                                         .ToList());  
            return specialities;
        }
    }
}
