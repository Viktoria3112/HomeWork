using System;
namespace Cat1
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите размер массива: ");
            int n = ReadInt();
            try 
            {
                if(n<0)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException) 
            {
                Console.WriteLine("Размер массива не может быть отрицательным значением ");
            }
            return n;

            
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Введите значение {i}  элементов массива");
                array[i] = ReadInt();
                try
                {
                    if (array[i] < 3000 || array[i] > 3000)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }


                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Введите числа от -3000 до +3000 ");
                }
                return;
            }

            int[]array= new int n;
            int max = 0;
            int secondMax = 0;
            for(int i=0; i<n; i++)
            {
                if (array[i] > max)
                {
                    secondMax = max;
                    max = array[i];
                }
                else if (array[i]<max && array[i]>secondMax)
                {
                    secondMax = array[i];
                }
                Console.WriteLine("Второй максимальныйэлемент: ");
            }
        }
    }
}

