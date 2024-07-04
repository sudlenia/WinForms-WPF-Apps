using System;
using System.Collections.Generic;
using Model;

namespace SharedView
{
    public interface IView
    {
        void AddStudent(List<string> studs, Student stud);
        event EventHandler<StudentArgs> EventStudentAddView;
        void RemoveStudent(List<string> studs);
        event EventHandler<StudentArgs> EventStudentRemoveView;
        void GetStudents(List<string> studs);
        event EventHandler<StudentArgs> EventStudentGetStudentsView;
    }
}
