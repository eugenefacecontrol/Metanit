using System;

namespace BasicsOfProgramming
{
    public class Variables : MainClass
    {
        public void AboutVariables()
        {

            Console.WriteLine("Переменная представляет именнованную область памяти, в которой хранится значение определенного типа");
            Console.WriteLine("Переменная имеет тип, имя и значение");
            string name = "Yauheni"; 

            var explanation = @"
имя может содержать любые цифры, буквы и символ подчеркивания, при этом первый символ в имени должен быть буквой или символом подчеркивания
в имени не должно быть знаков пунктуации и пробелов
имя не может быть ключевым словом языка C#
";
            Console.WriteLine(explanation);
             
            Console.WriteLine($"Hello, {name}");

            Console.WriteLine("Определение:");
            Console.WriteLine("string Name");

            Console.WriteLine("Инициализация:");
            Console.WriteLine("Name = \"Egor\"");

            string Name = "Egor";
            Console.WriteLine($"First person: {name}, Another pesron: {Name}");

            // Материалы:
            // Переменные и типы данных в C#
            // https://youtu.be/GeUrbwSYFvM
        }
    }
}
