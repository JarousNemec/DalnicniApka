using System;
using DalnicniApka.Utils;

namespace DalnicniApka
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "carData.csv";
            var rcm = new RecordsManager(path);
            if (rcm.GetRecords().Count == 0)
            {
                Console.WriteLine($"Could not print records. File {path} is empty.");
                return;
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Print all records:");
            RecordsPrinter.PrintRecords(rcm.GetRecords());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Print records from lowest date:");
            RecordsPrinter.PrintByLowestDate(rcm.GetRecords());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Print records from highest date:");
            RecordsPrinter.PrintByHighestDate(rcm.GetRecords());
            Console.ReadKey();
        }
    }
}
