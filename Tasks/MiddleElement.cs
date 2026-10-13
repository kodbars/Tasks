using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class MiddleElement
    {
        private List<int> array = new List<int>(3);

        public void Decision() 
        {
            array = Console.ReadLine().Trim().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            array.Sort();
            Console.WriteLine(array[1]);
        }
    }
}
