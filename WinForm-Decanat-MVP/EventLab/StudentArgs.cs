using System.Collections.Generic;

namespace Model
{
    public class StudentArgs
    {
        public Student Student { get; set; }
        public List<string> Students { get; set; }
        public StudentArgs(Student student)
        {
            Student = student;
        }
        public StudentArgs(List<string> students)
        {
            Students = students;
        }

        public StudentArgs() { }
        public StudentArgs(List<string> students, Student student)
        {
            Students = students;
            Student = student;
        }
    }
}
