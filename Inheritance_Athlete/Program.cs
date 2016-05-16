using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Athlete
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete connor = new Athlete();
            connor.lastName = "Washburn";

            Athlete noah = new Athlete();
            noah.lastName = "Washburn";

            Athlete luke = new Athlete();
            luke.lastName = "Washburn";

            Athlete brevin = new Athlete();
            brevin.lastName = "Barker";

        }
    }

    public class Athlete
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string nameOfSport { get; set; }

        public int age { get; set; }

        public bool siblings { get; set; }

        public void playerName()
        {
            Console.WriteLine("My name is {0}", lastName);
            Console.ReadLine();
        }
    }



    public class lacrosse : Athlete
    {
        public int jerseyNumber { get; set; }

        public bool mouthGuard { get; set; }

        lacrosse noah = new lacrosse();


        public void series()
        {
            Console.WriteLine("Athlete bio:", lastName, jerseyNumber);
            Console.Read();
        }
        
    }

    
    

}
