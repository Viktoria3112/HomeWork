using System.Xml.Linq;

namespace Cat2
{
    public abstract class Doctor

    {
        public  Doctor(string name, int age, int experience)
        {
            NameDoc = name;
            Age = age;
            Experience = experience;
        }
        public string NameDoc{ get; set; }
        public int Age{ get; set; }
        public int Experience{ get; set; }

        public abstract void Display();
        
      
    }
}
