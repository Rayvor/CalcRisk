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
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using System.IO;

namespace CalcRisk
{
    public partial class graphForm : Form
    {
        public graphForm(Calculation calc, string name)
        {
            InitializeComponent();
            DrawGraph(calc, name);
        }

        public graphForm(DataGridView Equity, DataGridView Borrow, int numPeriods)
        {
            InitializeComponent();
            DrawGraph(Equity, Borrow, numPeriods);
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

            LineItem curve = new LineItem("", list, Color.Blue, SymbolType.None, 3.0f);
            pane.CurveList.Add(curve);
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private void DrawGraph(DataGridView Equity, DataGridView Borrow, int numPeriods)
        {
            GraphPane pane = zedGraphControl.GraphPane;
            pane.CurveList.Clear();

            pane.Title.Text = "Зависимость Собств./Заемн. капитала от периода";
            pane.XAxis.Title.Text = "Период, мес.";
            pane.YAxis.Title.Text = "Собств./Заемн. капитал, %";
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;

            PointPairList listEquity = new PointPairList();
            PointPairList listBorrow = new PointPairList();

            for (int i = 0; i < numPeriods; i++)
            {
                double itemEquity = Convert.ToDouble(Equity.Rows[0].Cells[i].Value);
                double itemBorrow = Convert.ToDouble(Borrow.Rows[0].Cells[i].Value);
                listEquity.Add(i + 1, itemEquity);
                listBorrow.Add(i + 1, itemBorrow);
            }

            LineItem curveEquity = new LineItem("", listEquity, Color.Blue, SymbolType.None, 3.0f);
            LineItem curveBorrow = new LineItem("", listBorrow, Color.Red, SymbolType.None, 3.0f);
            pane.CurveList.Add(curveEquity);
            pane.CurveList.Add(curveBorrow);

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog.Filter = "xlsx файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            //saveFileDialog.Title = "Сохранить график как...";
            //saveFileDialog.ShowDialog();

            //if (saveFileDialog.FileName != "")
            //{

            //}

            SaveFileAsXls();
        }

        private void SaveFileAsXls()
        {
            ExcelPackage ExcelPkg = new ExcelPackage();
            ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");
            ExcelWorksheet chartSheet = ExcelPkg.Workbook.Worksheets.Add("Chart");

            //using (ExcelRange Rng = wsSheet1.Cells[2, 2, 2, 2])
            //{
            //    Rng.Value = "Welcome to Everyday be coding - tutorials for beginners";
            //    Rng.Style.Font.Size = 16;
            //    Rng.Style.Font.Bold = true;
            //    Rng.Style.Font.Italic = true;
            //}
            wsSheet1.Cells["A4"].Value = 1;
            wsSheet1.Cells["A5"].Value = 2;
            wsSheet1.Cells["A6"].Value = 3;
            wsSheet1.Cells["B4"].Value = 5;
            wsSheet1.Cells["B5"].Value = 7;
            wsSheet1.Cells["B6"].Value = 9;

            wsSheet1.Protection.IsProtected = false;
            wsSheet1.Protection.AllowSelectLockedCells = false;

            ExcelChart chart = chartSheet.Drawings.AddChart("FindingsChart", eChartType.ColumnClustered);
            chart.Title.Text = "Category Chart";
            chart.SetPosition(1, 0, 3, 0);
            chart.SetSize(800, 300);
            var ser1 = (ExcelChartSerie)(chart.Series.Add(wsSheet1.Cells["B4:B6"],
            wsSheet1.Cells["A4:A6"]));
            ser1.Header = "Category";


            ExcelPkg.SaveAs(new FileInfo(@"C:\dip\mydip\test.xlsx"));
        }
    }
}
