using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class _2_TheCheapestWay
    {
        int[,] array;

        public void Decision()
        {
            Console.WriteLine("Введите N и M: ");
            array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i + 1 < array.GetLength(0) && j + 1 < array.GetLength(1)) 
                    {
                        
                    }
                }
            }
        }

        }
}
