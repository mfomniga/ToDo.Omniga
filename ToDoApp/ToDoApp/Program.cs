using System;
using ToDoApp.objects;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Namen eingeben");
            string name = Console.ReadLine();

            Console.WriteLine("Schon erledigt? j/n");
            ConsoleKeyInfo eingabe = Console.ReadKey();

            bool doneumstaendlich;
            if(eingabe.Key == ConsoleKey.J)
            {
                doneumstaendlich = true;
            }
            else
            {
                doneumstaendlich = false;
            }

            bool done = eingabe.Key == ConsoleKey.J;            

            ToDo todo = new ToDo(name, done);

            Console.ReadLine();
        }
    }
}
