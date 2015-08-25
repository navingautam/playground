using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        protected static Singleton _obj;
        private Singleton()
        {

        }
        public static Singleton GetObject()
        {
            if(_obj==null)
            {
                _obj = new Singleton();
            }
            return _obj;
        }
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
