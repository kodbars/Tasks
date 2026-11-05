using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class _2_TheCheapestWay
    {
        int[,] array1;
        int[] array2;

        public void Decision()
        {
            Console.WriteLine("Введите N и M: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            array1 = new int[n, m];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (i + 1 < array1.GetLength(0) && j + 1 < array1.GetLength(1)) 
                    {
                        
                    }
                }
            }
        }

        }
}
