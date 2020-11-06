using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibConsoleMatrix
{
    public class ClassMatrixConsole
    {
        public static int[,] CreatMatrix(int a, int b)
        {
            Random rnd = new Random();
            int[,] matrix = new int[a, b];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-99,100);

                }
            }
            return matrix;
        }//Створення матриці
        public static void WriteMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }//Виведення матриц
        public static int KPositiveElements(int[,] matrix)
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
            return kPoz;
        }//К-сть додатніх елементів_1
        public static int MaxElem(int[,] matrix)
        {
            int k2 = 0, max_ch = 1000000, el1 = -1000000, min=100;
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
                else if(k2 > 1&& min!= el1)
                {
                    max_ch = el1;
                }
                else
                {
                    el1 = 0;
                    break;
                }
            }
            return el1;
        }//Максимальне з чисел(>1 разу)_2
        public static int KNotNullRow(int[,] matrix)
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
            return kRow;
        }//Кількість рядків у яких немає нулів_3
        public static int KNullCol(int[,] matrix)
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
            return k4;
        }//Кількість стовпців у яких є хоча б один 0_4
        public static int NumMaxRow(int[,] matrix)
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
                        kr = i;
                    }
                    counter5 = 0;
            }
            return kr;
        }//Номер рядка з найбільшою к-стю однакових рядків_5
        public static int DobElemRowWithoutNegElem(int[,] matrix)
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
            return dob;
        }//Добуток елементів рядків без негативних елементів_6
        public static int SumMax(int[,] matrix)
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

            return summax;
        }//Знаходження найбільшої суми по паралелям головної діагоналі_7
        public static int SumElemColWithoutNegElem(int[,] matrix)
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
            return sum;
        }//Сума елементів стовпців без негативних елементів_8
        public static int SumMinAbs(int[,] matrix)
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
            return summin;
        }//Знаходження мінімальної суми модулів по паралелям доаткової діагоналі_9
        public static int SumElemColWithNegElem(int[,] matrix)
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
            return sum;
        }//Сума елементів стовпців з негативним елементом_10
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
        }//Транспорована матриця_11
    }
}
