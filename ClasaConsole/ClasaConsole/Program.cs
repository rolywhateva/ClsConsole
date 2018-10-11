using System;

class Program
    {
        static void Main()
        {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        //Afiseaza un mesaj
        Console.Write("Hello World!");
        //Afiseaza un mesaj si trece la linie noua
        Console.WriteLine("Hello World!");

        //La fel, din cauza caracterului '\n'
        Console.Write("Hello World!\n");

        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Putem schimba culori");
        Console.Beep();
        Console.WriteLine("Am bipuit!");

            Console.ReadKey();
        }
    }

