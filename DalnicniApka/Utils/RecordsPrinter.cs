using System;
using System.Collections.Generic;
using DalnicniApka.Models;

namespace DalnicniApka
{
    public class RecordsPrinter
    {
        public static void PrintRecords( List<CarModel> records)
        {
            foreach (var rec in records)
            {
                Console.WriteLine(rec.ToString());
            }
        }

        public static void PrintByLowestDate(List<CarModel> records)
        {
            List<CarModel> sortedRecords = records;
            for (int i = 0; i < records.Count; i++)
            {
                CarModel temp = new CarModel();
                int tempIndex = 0;
                temp.Date = DateTime.MaxValue;
                for (int j = i; j < records.Count; j++)
                {
                    if (records[j].Date <= temp.Date)
                    {
                        temp = records[j];
                        tempIndex = j;
                    }
                }

                (sortedRecords[tempIndex], sortedRecords[i]) = (sortedRecords[i], sortedRecords[tempIndex]);
            }

            foreach (var record in sortedRecords)
            {
                Console.WriteLine(record);
            }
        }
        
        public static void PrintByHighestDate(List<CarModel> records)
        {
            List<CarModel> sortedRecords = records;
            for (int i = 0; i < records.Count; i++)
            {
                CarModel temp = new CarModel();
                int tempIndex = 0;
                temp.Date = DateTime.MinValue;
                for (int j = i; j < records.Count; j++)
                {
                    if (records[j].Date >= temp.Date )
                    {
                        temp = records[j];
                        tempIndex = j;
                    }
                }
            
                (sortedRecords[tempIndex], sortedRecords[i]) = (sortedRecords[i], sortedRecords[tempIndex]);
            }
            
            foreach (var record in sortedRecords)
            {
                Console.WriteLine(record);
            }
        }
    }
}