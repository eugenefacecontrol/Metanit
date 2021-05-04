using System;


{
    Console.WriteLine("Hello World!"); // Базовым строительным блоком программы являются инструкции (statement)

    /*
     * Одни блоки кода могут содержать другие блоки:
     */

    {
        Console.WriteLine("Первый блок");
        {
            Console.WriteLine("Второй блок");
        }
    }
}