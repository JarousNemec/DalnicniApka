using System;
using System.Collections.Generic;
using DalnicniApka.Models;

namespace DalnicniApka.Utils
{
    public static class RecordsSorter
    {
        public static List<CarModel> SortByHighestDate(List<CarModel> records)
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

            return sortedRecords;
        }
        
        public static List<CarModel> SortByLowestDate(List<CarModel> records)
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

            return sortedRecords;
        }
    }
}