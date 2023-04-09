using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using CsvHelper;
using System.Collections;

namespace Cat4
{
    class Program2
    {
        static void Main(string[] args)
        {
            /*string filePath1 = Path.Combine(pathCsvFile1);
            File.WriteAllText(filePath);*/
            string pathCsvFile = @"C:\Users\tori3\Desktop\программирование\2 семестр\Cat4\Csv.csv";
            using (StreamReader streamReader = new StreamReader(pathCsvFile))
            {
                using (CsvReader csvReader = new CsvReader((IParser)streamReader))
                {
                    csvReader.Configuration.Delimiter = "\t";
                    IEnumerable Csv = csvReader.GetRecords<Csv>();
                }
            }

        }
    }
}
