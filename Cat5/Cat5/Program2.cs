using Cat4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat5
{
    internal class Program2
    {
        static async void Main(string[] args)
        {

            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lesson12Homework");
            if (File.Exists(fileName) == false)
            {
                Console.WriteLine("Файл не найден: " + fileName);
            }
            else
            {
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string file = await reader.ReadToEndAsync();
                        Console.WriteLine(file);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            

        }
    }
}

