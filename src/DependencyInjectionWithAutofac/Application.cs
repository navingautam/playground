using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithAutofac
{
    public interface IApplication
    {
        void Run();
    }

    public class Application : IApplication
    {
        private readonly IBatchService _service;
        public Application(IBatchService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.WriteInformation("Injected!");
        }
    }
}
