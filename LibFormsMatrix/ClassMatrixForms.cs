using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibFormsMatrix
{
    public class ClassMatrixForms
    {
        public static void CreatDateGreed(int row, int col, DataGridView dataGrid)
        {
            dataGrid.ColumnCount = col;
            dataGrid.RowCount = row;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    dataGrid.Columns[i].HeaderCell.Value = i.ToString();
                    dataGrid.Rows[j].HeaderCell.Value = j.ToString();
                }
            }
        }//створення grid
        public static int[,] CreatMatrix(DataGridView dataGrid)
        {
            int[,] matrix = new int[dataGrid.RowCount, dataGrid.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(dataGrid[j, i].Value.ToString());

                }
            }
            return matrix;
        }//Створення матриці
        public static void KPositiveElements(int[,] matrix, Label lab)
        {
            int kPoz = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        kPoz++;
                    }
                }
            }
            lab.Text= kPoz.ToString();
        }//К-сть додатніх елементів_1
        public static void MaxElem(int[,] matrix, Label lab)
        {
            int k2 = 0, max_ch = 1000000, el1 = -1000000, min = 100;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                }
            }
            while (9 < 10)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > el1 && matrix[i, j] < max_ch)
                        {
                            el1 = matrix[i, j];
                            k2 = 1;
                        }
                        else if (matrix[i, j] == el1 && matrix[i, j] < max_ch)
                        {
                            k2++;
                        }
                    }
                }
                if (k2 > 1)
                {
                    break;
                }
                else if (k2 > 1 && min != el1)
                {
                    max_ch = el1;
                }
                else
                {
                    el1 = 0;
                    break;
                }
            }
            lab.Text = el1.ToString();
        }//Максимальне з чисел(>1 разу)_2
        public static void KNotNullRow(int[,] matrix, Label lab)
        {
            int kRow = 0, counter0 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        counter0++;
                    }
                }
                if (counter0 == 0)
                {
                    kRow++;
                }
            }
            lab.Text = kRow.ToString();
        }//Кількість рядків у яких немає нулів_3
        public static void KNullCol(int[,] matrix, Label lab)
        {
            int k4 = 0, counter4 = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        counter4++;
                    }
                }
                if (counter4 > 0)
                {
                    k4++;
                }
            }
            lab.Text = k4.ToString();
        }//Кількість стовпців у яких є хоча б один 0_4
        public static void NumMaxRow(int[,] matrix, Label lab)
        {
            int k5 = 0, counter5 = 0, kr = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                    for (int j = 1; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == matrix[i, j-1])
                        {
                            counter5++;
                        }
                    }
                    if (counter5 > k5)
                    {
                        k5 = counter5;
                        kr = i ;
                    }
                    counter5 = 0;
                }
            lab.Text = kr.ToString();
        }//Номер рядка з найбільшою к-стю однакових елементів_5
        public static void DobElemRowWithoutNegElem(int[,] matrix, Label lab)
        {
            int kneg = 0, dob = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        kneg++;
                    }
                }
                if (kneg == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        dob *= matrix[i, j];
                    }
                }
                kneg = 0;
            }
            lab.Text = dob.ToString();
        }//Добуток елементів рядків без негативних елементів_6
        public static void SumMax(int[,] matrix, Label lab)
        {
            int sum = 0, k = 0, summax = -1000;
            int maxlen = matrix.GetLength(0);
            if (matrix.GetLength(1) > matrix.GetLength(0))
            {
                maxlen = matrix.GetLength(1);
            }
            while (true)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == i + k)
                        {
                            sum += matrix[i, j];
                        }
                    }
                }
                if (sum > summax)
                {
                    summax = sum;
                }
                sum = 0;
                k++;
                if (k == maxlen)
                {
                    break;
                }

            }
            k = 0;
            while (true)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == i - k)
                        {
                            sum += matrix[i, j];
                        }
                    }
                }
                if (sum > summax)
                {
                    summax = sum;
                }
                sum = 0;
                k++;
                if (k == maxlen - 1)
                {
                    break;
                }

            }

            lab.Text = summax.ToString();
        }//Знаходження найбільшої суми по паралелям головної діагоналі_7
        public static void SumElemColWithoutNegElem(int[,] matrix, Label lab)
        {
            int sum = 0, kneg = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        kneg++;
                    }
                }
                if (kneg == 0)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        sum += matrix[i, j];
                    }
                }
                kneg = 0;
            }
            lab.Text = sum.ToString();
        }//Сума елементів стовпців без негативних елементів_8
        public static void SumMinAbs(int[,] matrix, Label lab)
        {
            int sum = 0, k = 0, summin = 1000;
            int maxlen = matrix.GetLength(0);
            if (matrix.GetLength(1) > matrix.GetLength(0))
            {
                maxlen = matrix.GetLength(0);
            }
            while (true)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(0) - (i + k))
                        {
                            sum += Math.Abs(matrix[i, j]);
                        }
                    }
                }
                if (sum < summin)
                {
                    summin = sum;
                }
                sum = 0;
                k++;
                if (k == maxlen)
                {
                    break;
                }

            }
            k = 0;
            while (true)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(0) - (i - k))
                        {
                            sum += Math.Abs(matrix[i, j]);
                        }
                    }
                }
                if (sum < summin)
                {
                    summin = sum;
                }
                sum = 0;
                k++;
                if (k == maxlen)
                {
                    break;
                }

            }
            lab.Text = summin.ToString();
        }//Знаходження мінімальної суми модулів по паралелям доаткової діагоналі_9
        public static void SumElemColWithNegElem(int[,] matrix, Label lab)
        {
            int sum = 0, kneg = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        kneg++;
                    }
                }
                if (kneg >= 1)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        sum += matrix[i, j];
                    }
                }
                kneg = 0;
            }
            lab.Text = sum.ToString();
        }//Сума елементів стовпців з негативним елементом_10
        public static void WriterGrid(int[,] matrix, DataGridView dataGrid) {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGrid[j, i].Value = matrix[i, j].ToString();
                }
            }
        }//вивід
        public static int[,] TranspMatrix(int[,] matrix)
        {
            int[,] matrixTransp = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixTransp[j, i] = matrix[i, j];
                }
            }
            return matrixTransp;
        }//транспортування матриці
        public static void VisibledGrid(DataGridView dataGrid)
        {
            dataGrid.Visible = true;
        }//видимість
        public static void VisibledLabel(Label lab)
        {
            lab.Visible = true;
        }//видимість

    }
}
