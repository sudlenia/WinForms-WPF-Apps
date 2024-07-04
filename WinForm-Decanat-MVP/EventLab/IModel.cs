using System;

namespace Model
{
    public interface IModel
    {
        void AddStudent(Student student);
        event EventHandler<StudentArgs> EventStudentAddModel;
        void RemoveStudent(Student student);
        event EventHandler<StudentArgs> EventStudentRemoveModel;
        void GetStudents();
        event EventHandler<StudentArgs> EventStudentGetStudentsModel;
    }
}
