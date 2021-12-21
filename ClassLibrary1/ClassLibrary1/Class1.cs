using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static List<int> Method(List<int> numbers)
        {// 0
            List<int> evenNumbers = new List<int>(); //  1

            for (int i = 0; i < numbers.Count; i++) // 2
            {
                if (numbers[i] % 2 == 0) // 3
                {
                    evenNumbers.Add(numbers[i]); // 4
                }
            } // 5

            return evenNumbers; // 6
        } // 7
    }
}
