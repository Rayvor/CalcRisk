using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcRisk
{
    public partial class preResultsForm : Form
    {
        public preResultsForm(Calculation calc)
        {
            InitializeComponent();
            SetDefaults(calc);
        }

        public void SetDefaults(Calculation calc)
        {
            for (int i = 0; i < calc.GetPUPCount + 1; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Width = 70;
                dataGridMatrixCov.Columns.Add(col);
            }

            dataGridMatrixCov.Rows.Add(calc.GetPUPCount + 1);
            //матрица ковариаций
            for (int i = 0; i <= calc.GetPUPCount; i++)
            {
                dataGridMatrixCov.Rows[0].Cells[i].Value = i.ToString();
                dataGridMatrixCov.Rows[i].Cells[0].Value = i.ToString();
            }

            for (int i = 1; i <= calc.GetPUPCount; i++)
                for (int j = 1; j <= calc.GetPUPCount; j++)
                {
                    dataGridMatrixCov.Rows[i].Cells[j].Value = Math.Round(calc.GetCov[j, i], 2);
                    dataGridMatrixCov.Rows[j].Cells[i].Value = Math.Round(calc.GetCov[j, i], 2);
                }

            for (int i = 0; i < calc.GetPUPCount + 1; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Width = 70;
                dataGridRandomValues.Columns.Add(col);
            }
            dataGridRandomValues.Rows.Add(501);
            //сгенерированные велечины
            for (int i = 1; i <= calc.GetPUPCount; i++)
                for (int j = 1; j <= 500; j ++)
                {
                    dataGridRandomValues.Rows[0].Cells[i].Value = i.ToString();
                    dataGridRandomValues.Rows[j].Cells[0].Value = j.ToString();
                    dataGridRandomValues.Rows[j].Cells[i].Value = calc.GetGeneration[j, i];
                }

            for (int i = 0; i < calc.GetPUPCount; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Width = 70;
                dataGridMoneyFlows.Columns.Add(col);
                DataGridViewColumn _col = new DataGridViewTextBoxColumn();
                _col.Width = 70;
                dataGridClearFlows.Columns.Add(_col);
            }
            dataGridMoneyFlows.Rows.Add(2);
            dataGridClearFlows.Rows.Add(2);
            //Денежные потоки
            for (int i = 0; i <= calc.GetPUPCount - 1; i++)
            {
                var cell = Math.Round(calc.GetInputStr[18, i + 1], 3);
                dataGridMoneyFlows.Rows[1].Cells[i].Value = cell;
                cell = Math.Round(calc.GetInputStr[17, i + 1], 3);
                dataGridClearFlows.Rows[1].Cells[i].Value = cell;
                dataGridMoneyFlows.Rows[0].Cells[i].Value = (i + 1).ToString();
                dataGridClearFlows.Rows[0].Cells[i].Value = (i + 1).ToString();

            }
        }
    }
}
