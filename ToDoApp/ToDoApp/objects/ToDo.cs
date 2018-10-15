using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.objects
{
    public class ToDo
    {
    
        public ToDo(string name, bool done)
        {
            this.Name = name;
            Console.WriteLine($"Die String Variable Name wurde auf {name} gesetzt.");

            this.Date = DateTime.Now;
            Console.WriteLine(this.Date);
            
            this.Done = done;

            //string variable = Boolean ? wenntrue : wennfalse
            string jaNein = done ? "ja" : "nein";

            Console.WriteLine($"Schon erledigt? {jaNein}");
        }

        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public bool Done { get; set; }
        
      
        
        
    }
}
