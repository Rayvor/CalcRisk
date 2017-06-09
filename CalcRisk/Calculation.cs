using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcRisk
{
    public class Calculation
    {
        int PUPCount; // число ПУП
        double[,] inputStr = new double[18, 100]; //денежные потоки
        double[,] inputIst = new double[2, 100]; //источники финансирования
        double[,] generation = new double[502, 700]; //генерации
        double[,] cov = new double[100, 100]; //матрица ковариации
        double[,] nPVt = new double[2, 100]; //массив для NPVt
        double[,] rt = new double[3, 100]; //массив для Rt
        int firstCap; //инвестиции
        double сoef; //Коэффициент дисконтирования
        double rtZnam; //знаменатель для расчета Rt
        double[,] sigmaNPV = new double[2, 100];
        double[,] rightSumVt = new double[100, 100]; //массив для правого слагаемого Vt
        double[,] leftSumVt = new double[2, 100]; //массив для левого слагаемого Vt
        double[] vt = new double[100]; //массив для Vt
        double[] ct = new double[100]; //массив для Ct
        bool flag; //флаг ошибки
        bool isGener; //флаг расчета предварительных результатов

        DataGridView tbInputSob, tbInputZaem, tbInputDiap, tbInputDeter;

        public Calculation(DataGridView tbInputSob, DataGridView tbInputZaem,
            DataGridView tbInputDiap, DataGridView tbInputDeter,
            ToolStripTextBox txtCoef, ToolStripTextBox txtStartInvest,
            int PUPCount)
        {
            this.tbInputSob = tbInputSob;
            this.tbInputZaem = tbInputZaem;
            this.tbInputDiap = tbInputDiap;
            this.tbInputDeter = tbInputDeter;
            this.PUPCount = PUPCount;
            сoef = double.Parse(txtCoef.Text);
            firstCap = int.Parse(txtStartInvest.Text);
            ReadVal();
            Calc();
        }

        private void ReadVal()
        {
            flag = false;
            //---Считываем денежные потоки---            
            for (int j = 3; j < PUPCount + 3; j++)
            {
                //Доходы от реализации продукции
                inputStr[0, j - 3] = Convert.ToDouble(tbInputDiap.Rows[0].Cells[j].Value);
                inputStr[1, j - 3] = Convert.ToDouble(tbInputDiap.Rows[1].Cells[j].Value);
                //Возмещение НДС по инвестициям
                inputStr[2, j - 3] = Convert.ToDouble(tbInputDeter.Rows[0].Cells[j - 1].Value);
                //Амортизация
                inputStr[3, j - 3] = Convert.ToDouble(tbInputDeter.Rows[1].Cells[j - 1].Value);
                //Инвестиции, включая НДС
                inputStr[4, j - 3] = Convert.ToDouble(tbInputDeter.Rows[2].Cells[j - 1].Value);
                //Прирост оборотных средств
                inputStr[5, j - 3] = Convert.ToDouble(tbInputDeter.Rows[3].Cells[j - 1].Value);
                //Эксплуатационные затраты
                inputStr[6, j - 3] = Convert.ToDouble(tbInputDiap.Rows[2].Cells[j].Value);
                inputStr[7, j - 3] = Convert.ToDouble(tbInputDiap.Rows[3].Cells[j].Value);
                //Налоги
                inputStr[8, j - 3] = Convert.ToDouble(tbInputDiap.Rows[4].Cells[j].Value);
                inputStr[9, j - 3] = Convert.ToDouble(tbInputDiap.Rows[5].Cells[j].Value);
            }
            //---Считываем источники финансирования--- 
            for (int i = 0; i < PUPCount; i++)
            {
                inputIst[0, i] = Convert.ToDouble(tbInputSob.Rows[0].Cells[i].Value);
                inputIst[1, i] = Convert.ToDouble(tbInputZaem.Rows[0].Cells[i].Value);
            }

        }

        private void Calc()
        {
            double Sum; int s; int t;
            //считываем минимум и максимум по сальдо денежных потоков
            //---чистые денежные потоки
            for (int i = 0; i < PUPCount; i++)
            {
                //мин
                inputStr[14, i] = (inputStr[0, i] + inputStr[2, i] + inputStr[3, i]) -
                    (inputStr[4, i] + inputStr[5, i] + inputStr[6, i] + inputStr[8, i]);
                //макс
                inputStr[15, i] = (inputStr[1, i] + inputStr[2, i] + inputStr[3, i]) -
                    (inputStr[4, i] + inputStr[5, i] + inputStr[7, i] + inputStr[9, i]);
                //чистые денежные потоки
                inputStr[16, i] = (inputStr[14, i] + inputStr[15, i]) / 2;
            }
            //---производим случайные генерации
            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < PUPCount; j++)
                {
                    if (inputStr[15, j] > inputStr[14, j])
                        generation[i, j] =
                            rnd.Next(Convert.ToInt32(Math.Round(inputStr[14, j])), Convert.ToInt32(Math.Round(inputStr[15, j])));
                    else
                        generation[i, j] =
                            rnd.Next(Convert.ToInt32(Math.Round(inputStr[15, j])), Convert.ToInt32(Math.Round(inputStr[14, j])));
                }
            }
            //Расчет мат. ожиданий денежных потоков
            for (int j = 0; j < PUPCount; j++)
            {
                Sum = 0;
                for (int i = 0; i < 500; i++)
                    Sum += generation[i, j];
                inputStr[17, j] = Sum / 500;
            }
            //Расчет дисперсии денежных потоков
            for (int j = 0; j < PUPCount; j++)
            {
                Sum = 0;
                for (int i = 0; i < 500; i++)
                {
                    generation[i, j + PUPCount] = Math.Pow(generation[i, j] - inputStr[17, j], 2);
                    Sum += generation[i, j + PUPCount];
                }
                generation[500, j + 12] = Sum;
            }
            //Расчет среднеквадратичных отклонений
            for (int i = 0; i < 500; i++)
                for (int j = 0; j < PUPCount; j++)
                    generation[i, j + 2 * PUPCount] = generation[i, j] - inputStr[17, j];
            //расчет коэффициентов для матрицы ковариации
            for (int k = 0; k < 500; k++)
            {
                s = 0;
                for (int i = 1; i <=  PUPCount - 1; i++)
                {
                    for (int j = i + 1; j <= PUPCount; j++)
                    {
                        generation[k, 3 * PUPCount + s + j - i - 1] =
                            generation[k, 2 * PUPCount + i - 1] * generation[k, 2 * PUPCount + j - 1];
                        string ij = i.ToString() + j.ToString();
                        generation[501, 3 * PUPCount + s + j - i - 2] = int.Parse(ij);
                    }
                    s += PUPCount - i - 1;
                }
            }
            t = 0;
            for (int i = 1; i <= PUPCount; i++)
                t += i;
            for (int j = 3 * PUPCount + 1; j <= t + 3 * PUPCount; j++)
            {
                Sum = 0;
                for (int i = 0; i < 500; i++)
                    Sum += generation[i, j - 1];
                generation[500, j - 1] = Sum;
            }

            //Расчет матрицы ковариации
            for (int i = 0; i < PUPCount; i++)
                cov[i, i] = generation[500, i + 12] / 500;

            for (int j = 2; j <= PUPCount; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (!(i == j))
                    {
                        for (int k = PUPCount + 1; k <= t + 3 * PUPCount; k++)
                        {
                            if (generation[501, k - 1].ToString() == (i).ToString() + (j).ToString())
                            {
                                cov[i - 1, j- 1] = generation[500, k - 1] / 500;
                                break;
                            }
                        }
                    }
                }
            }

            //Расчет NPVt
            for (int i = 0; i < PUPCount; i++)
                nPVt[0, i] = inputStr[17, i] / Math.Pow(сoef, i + 1);

            for (int i = 1; i <= PUPCount; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += nPVt[0, j - 1];
                nPVt[1, i - 1] = Sum - firstCap;
            }
            //Расчет Rt
            rtZnam = 0;
            for (int i = 0; i < PUPCount; i++)
                rtZnam += nPVt[0, i];
            rtZnam -= firstCap;
            for (int i = 1; i <= PUPCount; i++)
                rt[0, i - 1] = inputStr[16, i] / Math.Pow(сoef, i + 1);
            for (int i = 1; i <= PUPCount - 1; i++)
            {
                Sum = 0;
                for (int j = PUPCount - 1; j >= i; j--)
                    Sum += rt[0, j - 1];
                rt[1, i - 1] = Sum;
            }
            for (int i = 0; i < PUPCount - 1; i++)
                rt[2, i] = (nPVt[1, i] + rt[1, i]) / rtZnam;

            //Расчет сигма NPV
            for (int i = 0; i < PUPCount; i++)
                sigmaNPV[0, i] = (inputStr[17, i] - inputStr[16, i]) * Math.Pow(сoef, i + 1);
            for (int i = 1; i <= PUPCount; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += sigmaNPV[0, j - 1];
                sigmaNPV[1, i - 1] = Math.Pow(Sum, 2);
            }
            for (int i = 0; i < PUPCount; i++)
                sigmaNPV[1, i] = Math.Sqrt(sigmaNPV[1, i]);

            //Расчет Vt
            //---Расчет правого слагаемого Vt
            for (int j = 3; j <= PUPCount; j++)
                for (int i = 1; i <= j - 1; i++)
                    rightSumVt[i - 1, j - 2] = cov[i - 1, j - 1] / Math.Pow(сoef, i + j);
            for (int j = 0; j < PUPCount - 1; j++)
            {
                Sum = 0;
                for (int i = 0; i < PUPCount - 1; i++)
                    Sum += rightSumVt[i, j];
                rightSumVt[PUPCount, j] = Sum;
            }
            for (int i = 1; i <= PUPCount - 1; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += rightSumVt[PUPCount, j - 1];
                rightSumVt[PUPCount + 1, i - 1] = Sum;
            }
            //---Расчет левого слагаемого Vt
            for (int i = 0; i < PUPCount; i++)
                leftSumVt[0, i] = cov[i, i] / Math.Pow(сoef, 2 * (i +1));
            for (int i = 1; i <= PUPCount; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += leftSumVt[0, j - 1];
                leftSumVt[1, i - 1] = Sum;
            }
            vt[0] = leftSumVt[1, 0];
            for (int i = 1; i < PUPCount; i++)
                vt[i] = leftSumVt[1, i] + rightSumVt[PUPCount + 1, i - 1] * 2;

            //Расчет Ct
            for (int i = 0; i < PUPCount; i++)
            {
                if (inputIst[1, i] == 0)
                    ct[i] = 100;
                else
                    ct[i] = inputIst[0, i] / inputIst[1, i];
            }
        }


        #region Getters

        public double[,] GetInputStr
        {
            get {return inputStr;}
        }

        public double[,] GetInputIst
        {
            get { return inputIst; }
        }

        public double[,] GetGeneration
        {
            get { return generation; }
        }

        public double[,] GetCov
        {
            get { return cov; }
        }

        public int GetPUPCount
        {
            get { return PUPCount; }
        }

        public double[,] GetNPVt
        {
            get { return nPVt; }
        }

        public double[] GetVt
        {
            get { return vt; }
        }

        public double[,] GetRt
        {
            get { return rt; }
        }

        public double[] GetCt
        {
            get { return ct; }
        }

        public double[,] GetSigmaNPV
        {
            get { return sigmaNPV; }
        }
#endregion

    }
}
