using System;

namespace BasicsOfProgramming
{
    class Literals : MainClass
    {
        public void AboutLiterals()
        {
            Console.WriteLine("Литералы представляют неизменяемые значения(иногда их еще называют константами)");
            var explanation = @"
Литералы бывают логическими, целочисленными, вещественными, символьными и строчными.
И отдельный литерал представляет ключевое слово null.
";
            Console.WriteLine(explanation);
            Console.WriteLine("Логические литералы:");
            Console.WriteLine(true);
            Console.WriteLine(false);

            explanation = @"
            /* Целочисленные литералы представляют положительные и отрицательные целые числа, например, 1, 2, 3, 4, -7, -109.
             * Целочисленные литералы могут быть выражены в десятичной, шестнадцатеричной и двоичной форме.
            */
";
            Console.WriteLine(explanation);
            // Десятеричная форма
            Console.WriteLine(-11);

            // Двоичная форма

            Console.WriteLine(0b11);
        }
    }
}
