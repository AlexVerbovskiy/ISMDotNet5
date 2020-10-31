using System;
using System.Text;
using LibConsoleMatrix;

namespace MatrixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть кількість рядків:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість стовпців:");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = ClassMatrixConsole.CreatMatrix(row,col);
            int[,] matrixTransp = ClassMatrixConsole.TranspMatrix(matrix);

            Console.WriteLine("Згенерована матриця:");
            ClassMatrixConsole.WriteMatrix(matrix);
            Console.WriteLine("Кількість додатніх елементів:");
            Console.WriteLine($"{ClassMatrixConsole.KPositiveElements(matrix)}");
            Console.WriteLine("Максимальне з чисел, що зустрічаєтья більше 1 разу:");
            Console.WriteLine($"{ClassMatrixConsole.MaxElem(matrix)}");
            Console.WriteLine("Кількість рядків у яких немає нулів:");
            Console.WriteLine($"{ClassMatrixConsole.KNotNullRow(matrix)}");
            Console.WriteLine("Кількість стовпців у яких є хоча б один 0:");
            Console.WriteLine($"{ClassMatrixConsole.KNullCol(matrix)}");
            Console.WriteLine("Номер рядка з найбільшою к-стю однакових рядків:");
            Console.WriteLine($"{ClassMatrixConsole.NumMaxRow(matrix)}");
            Console.WriteLine("Добуток елементів рядків без негативних елементів:");
            Console.WriteLine($"{ClassMatrixConsole.DobElemRowWithoutNegElem(matrix)}");
            Console.WriteLine("Знаходження найбільшої суми по паралелям головної діагоналі:");
            Console.WriteLine($"{ClassMatrixConsole.SumMax(matrix)}");
            Console.WriteLine("Сума елементів стовпців без негативних елементів:");
            Console.WriteLine($"{ClassMatrixConsole.SumElemColWithoutNegElem(matrix)}");
            Console.WriteLine("Знаходження мінімальної суми модулів по паралелям доаткової діагоналі:");
            Console.WriteLine($"{ClassMatrixConsole.SumMinAbs(matrix)}");
            Console.WriteLine("Сума елементів стовпців з негативним елементом:");
            Console.WriteLine($"{ClassMatrixConsole.SumElemColWithNegElem(matrix)}");
            Console.WriteLine("Транспонована матриця:");
            ClassMatrixConsole.WriteMatrix(matrixTransp);

        }
    }
}
