using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using OfficeOpenXml;

namespace CalcRisk
{
    public partial class graphForm : Form
    {
        public graphForm(Calculation calc, string name)
        {
            InitializeComponent();
            DrawGraph(calc, name);
        }

        public graphForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawGraph(Calculation calc, string name)
        {
            GraphPane pane = zedGraphControl.GraphPane;
            pane.CurveList.Clear();

            pane.Title.Text = $"Зависимость {name} от периода";
            pane.XAxis.Title.Text = "Период";
            pane.YAxis.Title.Text = name;
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;

            PointPairList list = new PointPairList();

            for (int i = 1; i <= calc.GetPUPCount; i++)
            {
                double item = 0;

                switch (name)
                {
                    case "Ct":
                        item = Math.Round(calc.GetCt[i], 3);
                        break;
                    case "nPVt":
                        item = Math.Round(calc.GetNPVt[2, i], 3);
                        break;
                    case "Vt":
                        item = Math.Round(calc.GetVt[i], 3);
                        break;
                }
                list.Add(i, item);
            }

            LineItem curve = pane.AddCurve("", list, Color.Blue, SymbolType.None);

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
    }
}
