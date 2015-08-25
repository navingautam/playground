using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FactoryChoice
    {
        static public IChoice getChoiceObj(string choice)
        {
            IChoice objChoice = null;
            if(choice.ToLower()=="car")
            {
                objChoice = new Car();
            }
            else if (choice.ToLower() == "bike")
            {
                objChoice = new Bike();
            }
            else
            {
                objChoice = new InvalidChoice();
            }
            return objChoice;
        }
    }
}
