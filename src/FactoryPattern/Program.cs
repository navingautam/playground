using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IChoice objChoice;
            Console.WriteLine("Enter choice: ");
            string choice = Console.ReadLine().ToString();
            objChoice = FactoryChoice.getChoiceObj(choice);
            Console.WriteLine(objChoice.Buy());
            Console.ReadLine();
        }
    }
}
