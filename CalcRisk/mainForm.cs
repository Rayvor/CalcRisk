using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;

namespace CalcRisk
{
    public partial class mainForm : Form
    {
        IntWrapper NumPeriods;
        Calculation calc;

        public mainForm()
        {
            InitializeComponent();
            SetDefaultSetting();
        }

        private void numPeriods_ValueChanged(object sender, EventArgs e)
        {
            NumPeriods.Value = (int)((NumericUpDown)nudNumPeriods.NumericUpDownControl).Value;
            int numColDataGridEquity = dataGridEquity.ColumnCount;
            int numColDataGridBorrow = dataGridBorrow.ColumnCount;
            int numColDataGridRangeComp = dataGridRangeComp.ColumnCount;
            int numColDataGridDeterComp = dataGridDeterComp.ColumnCount;
            int numRowDataGridResults = dataGridResults.RowCount;

            if (NumPeriods.Value < NumPeriods.OldValue)
            {
                dataGridEquity.Columns[NumPeriods.Value].Visible = false;
                dataGridBorrow.Columns[NumPeriods.Value].Visible = false;
                dataGridRangeComp.Columns[NumPeriods.Value + 3].Visible = false;
                dataGridDeterComp.Columns[NumPeriods.Value + 2].Visible = false;
                dataGridResults.Rows[NumPeriods.Value].Visible = false;
                NumPeriods.OldValue = NumPeriods.Value;
            }
            else if (NumPeriods.Value > NumPeriods.OldValue)
            {
                NumPeriods.OldValue = NumPeriods.Value;
                dataGridEquity.Columns[NumPeriods.Value - 1].Visible = true;
                dataGridBorrow.Columns[NumPeriods.Value - 1].Visible = true;
                dataGridRangeComp.Columns[NumPeriods.Value + 2].Visible = true;
                dataGridDeterComp.Columns[NumPeriods.Value + 1].Visible = true;
                dataGridResults.Rows[NumPeriods.Value - 1].Visible = true;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Программу выполнил студент группы МИТ-13-2");
            (new aboutForm()).Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void просмотрПредварительныхРезультатовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calc = new Calculation(
                dataGridEquity,
                dataGridBorrow,
                dataGridRangeComp,
                dataGridDeterComp,
                txtCoef,
                txtStartInvest,
                (int)((NumericUpDown)this.nudNumPeriods.NumericUpDownControl).Value);

            построитьГрафикToolStripMenuItem.Enabled = true;
            ctToolStripMenuItem.Enabled = true;
            nPVtToolStripMenuItem.Enabled = true;
            vtToolStripMenuItem.Enabled = true;

            (new preResultsForm(calc)).Show();
        }

        private void ctToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calc != null)
                (new graphForm(calc, "Ct")).Show();
        }

        private void nPVtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calc != null)
                (new graphForm(calc, "nPVt")).Show();
        }

        private void vtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calc != null)
                (new graphForm(calc, "Vt")).Show();
        }

        private void собствЗаемнToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new graphForm(dataGridEquity, dataGridBorrow, NumPeriods.Value)).Show();
        }

        private void SetDefaultSetting()
        {
            toolStrip.Renderer = new ToolStripSysRenderer();

            int numPeriods = (int)((NumericUpDown)this.nudNumPeriods.NumericUpDownControl).Value;
            NumPeriods = new IntWrapper(numPeriods, numPeriods);

            for (int i = 1; i <= NumPeriods.Value; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = i.ToString();
                col.Width = 70;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridEquity.Columns.Add(col);
            }

            for (int i = 1; i <= NumPeriods.Value; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = i.ToString();
                col.Width = 70;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridBorrow.Columns.Add(col);
            }

            for (int i = 1; i <= NumPeriods.Value; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = i.ToString();
                col.Width = 70;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridRangeComp.Columns.Add(col);
            }

            for (int i = 1; i <= NumPeriods.Value; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = i.ToString();
                col.Width = 70;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridDeterComp.Columns.Add(col);
            }

            dataGridRangeComp.Rows.Add(6);
            dataGridRangeComp.Rows[0].Cells[0].Value = "+";
            dataGridRangeComp.Rows[2].Cells[0].Value = "-";
            dataGridRangeComp.Rows[4].Cells[0].Value = "-";
            dataGridRangeComp.Rows[0].Cells[1].Value = "Доходы от реализации продукции";
            dataGridRangeComp.Rows[2].Cells[1].Value = "Эксплуатационные затраты";
            dataGridRangeComp.Rows[4].Cells[1].Value = "Налоги";
            dataGridRangeComp.Rows[0].Cells[2].Value = "Мин.";
            dataGridRangeComp.Rows[1].Cells[2].Value = "Макс.";
            dataGridRangeComp.Rows[2].Cells[2].Value = "Мин";
            dataGridRangeComp.Rows[3].Cells[2].Value = "Макс.";
            dataGridRangeComp.Rows[4].Cells[2].Value = "Мин";
            dataGridRangeComp.Rows[5].Cells[2].Value = "Макс.";

            dataGridDeterComp.Rows.Add(4);
            dataGridDeterComp.Rows[0].Cells[0].Value = "+";
            dataGridDeterComp.Rows[1].Cells[0].Value = "+";
            dataGridDeterComp.Rows[2].Cells[0].Value = "-";
            dataGridDeterComp.Rows[3].Cells[0].Value = "-";
            dataGridDeterComp.Rows[0].Cells[1].Value = "Возмещение НДС по инвестициям";
            dataGridDeterComp.Rows[1].Cells[1].Value = "Амортизация";
            dataGridDeterComp.Rows[2].Cells[1].Value = "Инвестиции";
            dataGridDeterComp.Rows[3].Cells[1].Value = "Прирост оборотных средств";

            dataGridResults.Rows.Add(NumPeriods.Value);

            for (int i = 1; i <= NumPeriods.Value; i++ )
            {
                dataGridResults.Rows[i - 1].Cells[0].Value = i;
            }

            foreach (DataGridViewColumn col in dataGridRangeComp.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewColumn col in dataGridDeterComp.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridRangeComp.Columns[0].Width = 23;
            dataGridRangeComp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridRangeComp.Columns[1].Width = 222;
            dataGridRangeComp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridRangeComp.Columns[2].Width = 45;
            dataGridDeterComp.Columns[0].Width = 23;
            dataGridDeterComp.Columns[1].Width = 267;
            dataGridDeterComp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            ctToolStripMenuItem.Enabled = false;
            nPVtToolStripMenuItem.Enabled = false;
            vtToolStripMenuItem.Enabled = false;
            собствЗаемнToolStripMenuItem.Enabled = false;
            просмотрПредварительныхРезультатовToolStripMenuItem.Enabled = false;
            выполнитьРасчетToolStripMenuItem.Enabled = false;           

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.InitialDirectory = @"C:\Users\neoql\Downloads\KNIR\Два сюжета\Два сюжета\Инвестиционный проект\Осташова М.В. МИ-04-2\программа";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "xlsx файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileXls(openFileDialog.FileName, false);
            }

            ctToolStripMenuItem.Enabled = false;
            nPVtToolStripMenuItem.Enabled = false;
            vtToolStripMenuItem.Enabled = false;
            собствЗаемнToolStripMenuItem.Enabled = true;
            просмотрПредварительныхРезультатовToolStripMenuItem.Enabled = true;
            выполнитьРасчетToolStripMenuItem.Enabled = true;
        }

        private void OpenFileXls(string strfilepath, bool hasHeader = true)
        {
            string nameFile = Path.GetFileName(strfilepath);

            ExcelPackage exPack = new ExcelPackage();
            FileStream stream = null;

            try
            {
                stream = new FileStream(strfilepath, FileMode.Open);
                exPack.Load(stream);
                stream.Close();
                var wkSheet2 = exPack.Workbook.Worksheets[2];
                var wkSheet1 = exPack.Workbook.Worksheets[1];

                FillDataGridFromXls(dataGridEquity, 3, 2, "Column", wkSheet2, hasHeader);
                FillDataGridFromXls(dataGridBorrow, 4, 2, "Period", wkSheet2, hasHeader);
                FillDataGridFromXls(dataGridRangeComp, 4, 2, 9, 13, 0, 3, "Period", wkSheet1);
                FillDataGridFromXls(dataGridDeterComp, 11, 2, 14, 13, 0, 2, "Period", wkSheet1);
            }

            catch {}            
        }

        private void FillDataGridFromXls(DataGridView grid, int startRow, int startCol, string nameCols, ExcelWorksheet wk, bool hasHeader)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            var wsRow = wk.Cells[startRow, startCol, startRow, wk.Dimension.End.Column];
            int count = 1;

            foreach (var firstRowCell in wsRow)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Name = string.Format("{0} {1}", nameCols, firstRowCell.Start.Column);
                col.HeaderText = hasHeader ? firstRowCell.Text : string.Format("{0}", count);
                col.Width = 70;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                grid.Columns.Add(col);
                count++;
            }            
            //var wsRow = wk.Cells[startRow, 2, startRow, wk.Dimension.End.Column];
            grid.Rows.Add();

            foreach (var cell in wsRow)
            {
                int a = cell.Start.Column;
                grid.Rows[grid.Rows.Count - 1].Cells[cell.Start.Column - 2].Value = cell.Text;
            }
        }

        private void FillDataGridFromXls(DataGridView grid, int startRow, int startCol, int endRow, int endCol, int padRow, int padCol, string nameCols, ExcelWorksheet wk)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                var wsRow = wk.Cells[i, startCol, i, endCol]; //wk.Dimension.End.Column

                foreach (var cell in wsRow)
                {
                    int a = cell.Start.Column;
                    grid.Rows[cell.Start.Row - startRow + padRow].Cells[cell.Start.Column - startCol + padCol].Value = cell.Text;
                }

            }

        }

        private void выполнитьРасчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calc = new Calculation(
                dataGridEquity,
                dataGridBorrow,
                dataGridRangeComp,
                dataGridDeterComp,
                txtCoef,
                txtStartInvest,
                (int)((NumericUpDown)this.nudNumPeriods.NumericUpDownControl).Value);            

            for (int i = 1; i <= calc.GetPUPCount; i++)
            {
                var cell = Math.Round(calc.GetNPVt[2, i], 2);
                dataGridResults.Rows[i - 1].Cells[2].Value = cell;
                cell = Math.Round(calc.GetVt[i], 2);
                dataGridResults.Rows[i - 1].Cells[3].Value = cell;
                cell = Math.Round(calc.GetCt[i], 2);
                dataGridResults.Rows[i - 1].Cells[1].Value = cell;
                cell = Math.Round(calc.GetSigmaNPV[2,i], 2);
                dataGridResults.Rows[i - 1].Cells[5].Value = cell;
            }
            for (int i = 1; i <= calc.GetPUPCount - 1; i++)
            {
                var cell = Math.Round(calc.GetRt[3, i], 7);
                dataGridResults.Rows[i].Cells[4].Value = cell;
            }

            построитьГрафикToolStripMenuItem.Enabled = true;
            ctToolStripMenuItem.Enabled = true;
            nPVtToolStripMenuItem.Enabled = true;
            vtToolStripMenuItem.Enabled = true;

        }
    }
}
