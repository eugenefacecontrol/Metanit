using System;

namespace BasicsOfProgramming
{
    class Variables
    {
        public static void AboutVariables()
        {
            // Переменная представляет именнованную область памяти, в которой хранится значение определенного типа
            string name = "Yauheni"; // Переменная имеет тип, имя и значение

            /*
             * имя может содержать любые цифры, буквы и символ подчеркивания, при этом первый символ в имени должен быть буквой или символом подчеркивания
             * в имени не должно быть знаков пунктуации и пробелов
             * имя не может быть ключевым словом языка C#
             */
            Console.WriteLine($"Hello, {name}");
            // Определение:
            string Name;
            // Инициализация:
            Name = "Egor";
            Console.WriteLine($"First person: {name}, Another pesron: {Name}");

            // Материалы:
            // Переменные и типы данных в C#
            // https://youtu.be/GeUrbwSYFvM
        }
    }
}
