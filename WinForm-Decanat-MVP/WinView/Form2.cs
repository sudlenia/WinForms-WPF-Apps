using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace WinView
{
    public partial class Form2 : Form
    {
        public Form2(List<string> studs)
        {
            InitializeComponent();
            InitGraph(studs);
        }
        private void InitGraph(List<string> studs)
        {
            List<string> speciality = studs.Where((value, index) => index % 3 == 1).GroupBy(x => x).Select(x => x.Key).ToList();

            GraphPane graphpane = zedGraphControl1.GraphPane;

            graphpane.CurveList.Clear();

            double[] values = new double[speciality.Count];

            graphpane.Title.Text = "График распреления студентов по специальностям";

            graphpane.YAxis.Title.Text = "Количество студентов";

            for (int i = 0; i < speciality.Count; i++)
            {
                int count = 0;
                for (int k = 0; k < studs.Count; k += 3)
                {
                    if (studs[k + 1] == speciality[i])
                    {
                        count += 1;
                    }
                }
                values[i] = count;
                count = 0;
            }

            BarItem curve = graphpane.AddBar("Гистограмма", null, values, Color.Blue);

            graphpane.XAxis.Type = AxisType.Text;

            graphpane.XAxis.Scale.TextLabels = speciality.ToArray();

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
        public void UpdateGraph(List<string> studs)
        {
            if (this.Visible)
                InitGraph(studs);
        }
    }
}
