using SharedView;
using Model;

namespace Presenter
{
    public class PresenterStudent
    {
        private IView view = null;
        private IModel model = null;

        public PresenterStudent(IView studentView, IModel studentModel)
        {
            view = studentView;
            view.EventStudentAddView += view_StudentAdd;
            view.EventStudentRemoveView += view_StudentRemove;
            view.EventStudentGetStudentsView += view_GetStudents;

            model = studentModel;
            model.EventStudentAddModel += model_StudentAdd;
            model.EventStudentRemoveModel += model_StudentRemove;
            model.EventStudentGetStudentsModel += model_GetStudents;
        }

        public void view_StudentAdd(object sender, StudentArgs e)
        {
            model.AddStudent(e.Student);
        }

        public void model_StudentAdd(object sender, StudentArgs e)
        {
            view.AddStudent(e.Students, e.Student);
        }

        public void view_StudentRemove(object sender, StudentArgs e)
        {
            model.RemoveStudent(e.Student);
        }

        public void model_StudentRemove(object sender, StudentArgs e)
        {
            view.RemoveStudent(e.Students);
        }

        public void view_GetStudents(object sender, StudentArgs e)
        {
            model.GetStudents();
        }

        public void model_GetStudents(object sender, StudentArgs e)
        {
            view.GetStudents(e.Students);
        }
    }
}
