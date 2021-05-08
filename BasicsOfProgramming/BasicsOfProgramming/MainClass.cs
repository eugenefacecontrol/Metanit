using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfProgramming
{
    public class MainClass
    {
        public MainClass()
        {
            var className = this.GetType().Name;
            Console.WriteLine($"------------------------Type: {className}------------------------");
        }
    }
}
