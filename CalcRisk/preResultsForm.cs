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

            for (int i = 0; i < calc.GetPUPCount + 1; i++)
            {
                dataGridMatrixCov.Rows[0].Cells[i].Value = i.ToString();
                dataGridMatrixCov.Rows[i].Cells[0].Value = i.ToString();
            }

            for (int i = 0; i < calc.GetPUPCount; i++)
                for (int j = 0; j < calc.GetPUPCount; j++)
                {
                    dataGridMatrixCov.Rows[i + 1].Cells[j + 1].Value = Math.Round(calc.GetCov[j, i], 2);
                    dataGridMatrixCov.Rows[j + 1].Cells[i + 1].Value = Math.Round(calc.GetCov[j, i], 2);
                }

            for (int i = 0; i < calc.GetPUPCount + 1; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Width = 70;
                dataGridRandomValues.Columns.Add(col);
            }
            dataGridRandomValues.Rows.Add(500);

            for (int i = 0; i < calc.GetPUPCount; i++)
                for (int j = 0; j < 500; j ++)
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

            for (int i = 0; i < calc.GetPUPCount - 1; i++)
            {
                var cell = Math.Round(calc.GetInputStr[17, i], 3);
                dataGridMoneyFlows.Rows[1].Cells[i].Value = cell;
                cell = Math.Round(calc.GetInputStr[16, i], 3);
                dataGridClearFlows.Rows[1].Cells[i].Value = cell;
                dataGridMoneyFlows.Rows[0].Cells[i].Value = (i + 1).ToString();
                dataGridClearFlows.Rows[0].Cells[i].Value = (i + 1).ToString();
            }
        }
    }
}
