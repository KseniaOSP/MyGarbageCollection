using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarbageCollection
{
    public class Can : IDisposable
    {
        string name;

        public Can(string name)
        {
            this.name = name;
        }

        public void Dispose()
        {
            Console.WriteLine($"Throw away the can {name}");   
        }
    }
}
