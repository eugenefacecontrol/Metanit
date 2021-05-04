using System; // подключаемое пространство имен

namespace HelloApp // объявление нового пространства имен, которое будет создавать отдельную сборку или исполняемую программу
{
    class Program   // объявление нового класса
    {
        static void Main(string[] args) // объявление нового метода
        {
            Console.WriteLine("Hello World!"); // действия метода
            Example1.AskName();

        } // конец объявления нового метода

    } // конец объявления нового класса

    class Example1
    {
        public static void AskName()
        {
            Console.WriteLine("Введите своё имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
        }
    }

} // конец объявления нового пространства именf