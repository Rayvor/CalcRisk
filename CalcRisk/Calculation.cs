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
        double[,] inputStr = new double[19, 101]; //денежные потоки
        double[,] inputIst = new double[3, 101]; //источники финансирования
        double[,] generation = new double[503, 701]; //генерации
        double[,] cov = new double[101, 101]; //матрица ковариации
        double[,] nPVt = new double[3, 100]; //массив для NPVt
        double[,] rt = new double[4, 100]; //массив для Rt
        int firstCap; //инвестиции
        double сoef; //Коэффициент дисконтирования
        double rtZnam; //знаменатель для расчета Rt
        double[,] sigmaNPV = new double[3, 101];
        double[,] rightSumVt = new double[101, 101]; //массив для правого слагаемого Vt
        double[,] leftSumVt = new double[3, 101]; //массив для левого слагаемого Vt
        double[] vt = new double[101]; //массив для Vt
        double[] ct = new double[101]; //массив для Ct
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
            for (int j = 3; j <= PUPCount + 2; j++)
            {
                //Доходы от реализации продукции
                inputStr[1, j - 2] = Convert.ToDouble(tbInputDiap.Rows[0].Cells[j].Value);
                inputStr[2, j - 2] = Convert.ToDouble(tbInputDiap.Rows[1].Cells[j].Value);
                //Возмещение НДС по инвестициям
                inputStr[3, j - 2] = Convert.ToDouble(tbInputDeter.Rows[0].Cells[j - 1].Value);
                //Амортизация
                inputStr[4, j - 2] = Convert.ToDouble(tbInputDeter.Rows[1].Cells[j - 1].Value);
                //Инвестиции, включая НДС
                inputStr[5, j - 2] = Convert.ToDouble(tbInputDeter.Rows[2].Cells[j - 1].Value);
                //Прирост оборотных средств
                inputStr[6, j - 2] = Convert.ToDouble(tbInputDeter.Rows[3].Cells[j - 1].Value);
                //Эксплуатационные затраты
                inputStr[7, j - 2] = Convert.ToDouble(tbInputDiap.Rows[2].Cells[j].Value);
                inputStr[8, j - 2] = Convert.ToDouble(tbInputDiap.Rows[3].Cells[j].Value);
                //Налоги
                inputStr[9, j - 2] = Convert.ToDouble(tbInputDiap.Rows[4].Cells[j].Value);
                inputStr[10, j - 2] = Convert.ToDouble(tbInputDiap.Rows[5].Cells[j].Value);
            }
            //---Считываем источники финансирования--- 
            for (int i = 0; i <= PUPCount - 1; i++)
            {
                inputIst[1, i + 1] = Convert.ToDouble(tbInputSob.Rows[0].Cells[i].Value);
                inputIst[2, i + 1] = Convert.ToDouble(tbInputZaem.Rows[0].Cells[i].Value);
            }

        }

        private void Calc()
        {
            double Sum; int s; int t;
            //считываем минимум и максимум по сальдо денежных потоков
            //---чистые денежные потоки
            for (int i = 1; i <= PUPCount; i++)
            {
                //мин
                inputStr[15, i] = (inputStr[1, i] + inputStr[3, i] + inputStr[4, i]) -
                    (inputStr[5, i] + inputStr[6, i] + inputStr[7, i] + inputStr[9, i]);
                //макс
                inputStr[16, i] = (inputStr[2, i] + inputStr[3, i] + inputStr[4, i]) -
                    (inputStr[5, i] + inputStr[6, i] + inputStr[8, i] + inputStr[10, i]);
                //чистые денежные потоки
                inputStr[17, i] = (inputStr[15, i] + inputStr[16, i]) / 2;
            }
            //---производим случайные генерации
            Random rnd = new Random();
            for (int i = 1; i <= 500; i++)
            {
                for (int j = 1; j <= PUPCount; j++)
                {
                    if (inputStr[16, j] > inputStr[15, j])
                        generation[i, j] =
                            rnd.Next(Convert.ToInt32(Math.Round(inputStr[15, j])), Convert.ToInt32(Math.Round(inputStr[16, j])));
                    else
                        generation[i, j] =
                            rnd.Next(Convert.ToInt32(Math.Round(inputStr[16, j])), Convert.ToInt32(Math.Round(inputStr[15, j])));
                }
            }
            //Расчет мат. ожиданий денежных потоков
            for (int j = 1; j <= PUPCount; j++)
            {
                Sum = 0;
                for (int i = 1; i <= 500; i++)
                    Sum += generation[i, j];
                inputStr[18, j] = Sum / 500;
            }
            //Расчет дисперсии денежных потоков
            for (int j = 1; j <= PUPCount; j++)
            {
                Sum = 0;
                for (int i = 1; i <= 500; i++)
                {
                    generation[i, j + PUPCount] = Math.Pow(generation[i, j] - inputStr[18, j], 2);
                    Sum += generation[i, j + PUPCount];
                }
                generation[501, j + 12] = Sum;
            }
            //Расчет среднеквадратичных отклонений
            for (int i = 1; i <= 500; i++)
                for (int j = 1; j <= PUPCount; j++)
                    generation[i, j + 2 * PUPCount] = generation[i, j] - inputStr[18, j];
            //расчет коэффициентов для матрицы ковариации
            for (int k = 1; k <= 500; k++)
            {
                s = 0;
                for (int i = 1; i <=  PUPCount - 1; i++)
                {
                    for (int j = i + 1; j <= PUPCount; j++)
                    {
                        generation[k, 3 * PUPCount + s + j - i] =
                            generation[k, 2 * PUPCount + i] * generation[k, 2 * PUPCount + j];
                        string ij = i.ToString() + j.ToString();
                        generation[502, 3 * PUPCount + s + j - i] = int.Parse(ij);
                    }
                    s += PUPCount - i;
                }
            }
            t = 0;
            for (int i = 1; i <= PUPCount; i++)
                t += i;
            for (int j = 3 * PUPCount + 1; j <= t + 3 * PUPCount; j++)
            {
                Sum = 0;
                for (int i = 1; i <= 500; i++)
                    Sum += generation[i, j];
                generation[501, j] = Sum;
            }

            //Расчет матрицы ковариации
            for (int i = 1; i <= PUPCount; i++)
                cov[i, i] = generation[501, i + 12] / 500;

            for (int j = 2; j <= PUPCount; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (!(i == j))
                    {
                        for (int k = PUPCount + 1; k <= t + 3 * PUPCount; k++)
                        {
                            if (generation[502, k].ToString() == i.ToString() + j.ToString())
                            {
                                cov[i, j] = generation[501, k] / 500;
                                break;
                            }
                        }
                    }
                }
            }

            //Расчет NPVt
            for (int i = 1; i <= PUPCount; i++)
                nPVt[1, i] = inputStr[18, i] / Math.Pow(сoef, i);

            for (int i = 1; i <= PUPCount; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += nPVt[1, j];
                nPVt[2, i] = Sum - firstCap;
            }
            //Расчет Rt
            rtZnam = 0;
            for (int i = 1; i <= PUPCount; i++)
                rtZnam += nPVt[1, i];
            rtZnam -= firstCap;
            for (int i = 2; i <= PUPCount; i++)
                rt[1, i - 1] = inputStr[17, i] / Math.Pow(сoef, i);
            for (int i = 1; i <= PUPCount - 1; i++)
            {
                Sum = 0;
                for (int j = PUPCount - 1; j >= i; j--)
                    Sum += rt[1, j];
                rt[2, i] = Sum;
            }
            for (int i = 1; i <= PUPCount - 1; i++)
                rt[3, i] = (nPVt[2, i] + rt[2, i]) / rtZnam;

            //Расчет сигма NPV
            for (int i = 1; i <= PUPCount; i++)
                sigmaNPV[1, i] = (inputStr[18, i] - inputStr[17, i]) * Math.Pow(сoef, i);
            for (int i = 1; i <= PUPCount; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += sigmaNPV[1, j];
                sigmaNPV[2, i] = Math.Pow(Sum, 2);
            }
            for (int i = 1; i <= PUPCount; i++)
                sigmaNPV[2, i] = Math.Sqrt(sigmaNPV[2, i]);

            //Расчет Vt
            //---Расчет правого слагаемого Vt
            for (int j = 3; j <= PUPCount; j++)
                for (int i = 1; i <= j - 1; i++)
                    rightSumVt[i, j - 1] = cov[i, j] / Math.Pow(сoef, i + j);
            for (int j = 1; j <= PUPCount - 1; j++)
            {
                Sum = 0;
                for (int i = 1; i <= PUPCount - 1; i++)
                    Sum += rightSumVt[i, j];
                rightSumVt[PUPCount, j] = Sum;
            }
            for (int i = 1; i <= PUPCount - 1; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += rightSumVt[PUPCount, j];
                rightSumVt[PUPCount + 1, i] = Sum;
            }
            //---Расчет левого слагаемого Vt
            for (int i = 1; i <= PUPCount; i++)
                leftSumVt[1, i] = cov[i, i] / Math.Pow(сoef, 2 * i);
            for (int i = 1; i <= PUPCount; i++)
            {
                Sum = 0;
                for (int j = 1; j <= i; j++)
                    Sum += leftSumVt[1, j];
                leftSumVt[2, i] = Sum;
            }
            vt[1] = leftSumVt[2, 1];
            for (int i = 2; i <= PUPCount; i++)
                vt[i] = leftSumVt[2, i] + rightSumVt[PUPCount + 1, i - 1] * 2;

            //Расчет Ct
            for (int i = 1; i <= PUPCount; i++)
            {
                if (inputIst[2, i] == 0)
                    ct[i] = 100;
                else
                    ct[i] = inputIst[1, i] / inputIst[2, i];
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
