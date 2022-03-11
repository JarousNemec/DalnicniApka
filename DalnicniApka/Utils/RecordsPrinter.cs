using System;
using System.Collections.Generic;
using DalnicniApka.Models;

namespace DalnicniApka.Utils
{
    public static class RecordsPrinter
    {
        public static void PrintRecords(List<CarModel> records)
        {
            foreach (var record in records)
            {
                Console.WriteLine(record);
            }
        }

        public static void PrintByLowestDate(List<CarModel> records)
        {
            List<CarModel> sortedRecords = RecordsSorter.SortByLowestDate(records);
            foreach (var record in sortedRecords)
            {
                Console.WriteLine(record);
            }
        }

        public static void PrintByHighestDate(List<CarModel> records)
        {
            List<CarModel> sortedRecords = RecordsSorter.SortByHighestDate(records);
            foreach (var record in sortedRecords)
            {
                Console.WriteLine(record);
            }
        }
    }
}