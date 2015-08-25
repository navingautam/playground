using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersAndStrings numbersAndStrings = new NumbersAndStrings();
            var numbersandstrings = numbersAndStrings.GetNumbersAndStrings();

            for(int i=0; i<numbersandstrings.Count;i++)
            {
                Console.WriteLine(numbersandstrings[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
