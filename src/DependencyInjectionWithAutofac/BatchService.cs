using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithAutofac
{
    public interface IBatchService
    {
        void WriteInformation(string input);
    }

    public class BatchService : IBatchService
    {
        public void WriteInformation(string input)
        {
            Console.WriteLine(input);
            Console.ReadKey();
        }
    }

    public class BatchService2 : IBatchService
    {
        public void WriteInformation(string input)
        {
            Console.WriteLine("Hello!! "+input);
            Console.ReadKey();
        }
    }

}
