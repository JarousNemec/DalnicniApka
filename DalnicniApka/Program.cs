using System;

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
            RecordsPrinter.PrintRecords(rcm.GetRecords());
            Console.WriteLine("-----------------------------------------------------");
            RecordsPrinter.PrintByLowestDate(rcm.GetRecords());
            Console.WriteLine("-----------------------------------------------------");
            RecordsPrinter.PrintByHighestDate(rcm.GetRecords());
            Console.ReadKey();
        }
    }
}
