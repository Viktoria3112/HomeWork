using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat2
{
   public class Ophthalmologist : Doctor
    {
        public Ophthalmologist(string name, int age, int experience, int numberOffice) : base(name, age, experience)
        {
            NumberOffice = numberOffice;
            
        }
        public int NumberOffice { get; set; }


        public override void Display()
        {
            Console.WriteLine($"{NameDoc}-{Age}-{Experience} numberOffice:{NumberOffice}");
        }

    }
}
