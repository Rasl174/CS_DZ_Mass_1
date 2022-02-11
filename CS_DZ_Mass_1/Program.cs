using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Mass_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 6, 3, 1 }, { 6, 1, 8 }, { 2, 5, 0 } };
            int sum = 0;
            int multiplication = 1;
            int selectedRow = 2;
            int selectedСolumn = 1;
            

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i<array.GetLength(1); i++)
            {
                sum += array[selectedRow - 1, i];
            }
            Console.WriteLine("Сумма второй строки рана: " + sum);

            for (int i = 0; i<array.GetLength(0); i++)
            {
                multiplication *= array[i, selectedСolumn - 1];
            }
            Console.WriteLine("Произведение чисел первого столбца: " + multiplication);
        }
    }
}
