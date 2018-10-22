//using System;
//using System.Collections.Generic;


//namespace ToDoAddCheckDelete
//{
//    class Program
//    {
//        private static List<string> namen = new List<string>();

//        static void Main(string[] args)
//        {


//            Console.WriteLine("Benutze die Befehle Add, Check und Delete!");

//            add mathias
//            string userInput = Console.ReadLine();

//            if (userInput.StartsWith("add "))
//            {
//                Console.WriteLine("Gib den Namen der Person ein die zu hinzufügen willst:");
//                string userInputName = Console.ReadLine();
//                namen.Add(Console.ReadLine());


//            }
//            else if (userInput.StartsWith("delete "))
//            {

//            }






//            Console.ReadKey();
//        }
//    }
//}




using System;
using System.Collections.Generic;
using ToDoApp.objects;

namespace ToDoApp
{
    class Program
    {
        static List<ToDo> member;

        static void Main(string[] args)
        {            
            // Zyklus -> App wartet auf Eingabe (z.B. add / check / delete "Todo1")

            // -> App verarbeitet Befehl und gibt Meldung ob´s geklappt hat (Todo1 wurde angelegt ODER ToDo1 exsitiert bereits)

            // gehts von vorne los



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

            member = "test";
        }
    }
}
