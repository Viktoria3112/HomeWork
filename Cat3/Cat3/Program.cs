using System;
namespace Cat3
{
    class Program
    {
        static void Main(string[] args) 
        {
            ClassCounter counter = new ClassCounter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            counter.OnCount += handler1.Massage;
            counter.OnCount += handler2.Massage;

            counter.Count();

        }
    }
}

