using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat2
{
    public class Patient
    {
        public Patient(string name, int age, int numberphone,string disease, string health)
        {
            NamePatient = name;
            Age = age;
            NumberPhone = numberphone ;
            Disease = disease;
            Health = health;
            
            
        }
        public string NamePatient { get; set; }
        public int Age { get; set; }
        public int NumberPhone { get; set; }
       public string Disease { get; set; } 
        public string Health { get; set; }
        

        public virtual void Display()
        {
            Console.WriteLine($"{NamePatient}, возраст:{Age}, номер телефона:{NumberPhone},заболевание{Disease}, здоровье{Health}");
                
        }

        public bool CurePatient(Patient patient)
        {
            if(Health=="good")
            {
                Console.WriteLine("Лечение помогло");
                return true;

            }
            else 
            {
                Console.WriteLine("Лечение было не правильным");
                return false;
            }
        }
    }

}
