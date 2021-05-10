using System;

namespace BasicsOfProgramming
{
    public class MainClass
    {
        public MainClass()
        {
            var className = GetType().Name;
            Console.WriteLine($"------------------------Type: {className}------------------------");
        }
    }
}
