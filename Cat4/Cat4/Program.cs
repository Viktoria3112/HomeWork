using CsvHelper;
using System;
using System.IO.Compression;
using System.Security.Claims;

namespace Cat4
{
    class Program
    {

        static void Main(string[] args)
        {
            string startPath = @"C:\Users\tori3\Desktop\программирование\2 семестр\Cat4\HW5";
            string zipPath = @"C:\Users\tori3\Desktop\программирование\2 семестр\Cat4\HW5.zip";
            string extractPath = @"C:\Users\tori3\Desktop\программирование\2 семестр\Cat4\newHW5";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);

            var directory = new DirectoryInfo(startPath);
            if (directory.Exists)
            {
                Console.WriteLine("Подкатологи:");
                DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    Console.WriteLine(dir.FullName);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы: ");
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.FullName);

                }


            }
            string pathCsvFile = @"C:\Users\tori3\Desktop\программирование\2 семестр\Cat4\Csv.csv";
            List<Csv> csv = new List<Csv>
                {
                    new Csv{Type="Папка",Name="Cat4",DateOfChange="09.04.23"},
                    new Csv{Type="Файл",Name="Cin",DateOfChange="09.04.23"}

                };
            using (StreamWriter streamReader = new StreamWriter(pathCsvFile))
            {
                using (CsvWriter csvReader = new CsvWriter(streamReader))
                {
                    csvReader.Configuration.Delimiter = "\t";
                    csvReader.WriteRecords(csv);
                }



            }
            try
            {
                File.Delete(zipPath);
            }
            catch(Exception)
            {
                Console.WriteLine("Не удалось удалить: {0}");
            }

            string pathCsvFile1 = Environment.ExpandEnvironmentVariables(@"%AppData%/Lesson12Homework.txt");
            Directory.CreateDirectory(pathCsvFile1);
        }

    }
}

