using BusinessLogic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace WinFormView
{
    public partial class BarChartForm : Form
    {
        public BarChartForm(Logic logic)
        {
            InitializeComponent();

            InitGraph(logic);
        }

        private void InitGraph(Logic logic)
        {
            GraphPane graphpane = zedGraphControl1.GraphPane;

            graphpane.CurveList.Clear();

            double[] values = new double[logic.GetSpeciality().Count];

            graphpane.Title.Text = "График распреления студентов по специальностям";

            graphpane.YAxis.Title.Text = "Количество студентов";

            for (int i = 0; i < logic.GetSpeciality().Count; i++)
            {
                int count = 0;
                for (int k = 1; k < logic.GetStudentsInfo().Count; k += 3)
                {
                    if (logic.GetStudentsInfo()[k] == logic.GetSpeciality()[i])
                    {
                        count += 1;
                    }
                }
                values[i] = count;
            }

            BarItem curve = graphpane.AddBar("Гистограмма", null, values, Color.Blue);

            graphpane.XAxis.Type = AxisType.Text;

            graphpane.XAxis.Scale.TextLabels = logic.GetSpeciality().ToArray();

            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();
        }
        public void UpdateGraphs(Logic logic)
        {
            if (this.Visible)
            {
                InitGraph(logic);
            }
        }
    }
}
