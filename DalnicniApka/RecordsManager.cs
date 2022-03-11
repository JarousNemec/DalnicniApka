using DalnicniApka.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace DalnicniApka
{
    public class RecordsManager
    {
        private readonly List<CarModel> _records = new List<CarModel>();

        public RecordsManager(string filePath)
        {
            if (IsFilePathValid(filePath))
                LoadRecords(filePath);
        }

        private void LoadRecords(string filePath)
        {
            try
            {
                var line = File.ReadAllLines(filePath);
                var parsingStartIndex = GetParsingStartIndex(line);
                for (var i = parsingStartIndex; i < line.Length - parsingStartIndex; i++)
                {
                    var row = line[i].Split(';');
                    if (ValidateVehicleRow(row))
                    {
                        var model = ParseCarModel(row);
                        _records.Add(model);
                    }
                    else
                    {
                        Console.WriteLine($"Could not parse vehicle on index {i}: {line[i]}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in loading records: ");
                Console.WriteLine(e);
            }
        }

        private bool ValidateVehicleRow(string[] row)
        {
            if (row.Length != 5)
                return false;
            if (!DateTime.TryParse(row[1], out var tempDateTime))
                return false;
            if (!double.TryParse(row[4], out var tempDouble))
                return false;
            if (!int.TryParse(row[3], out var tempInt))
                return false;
            return true;
        }

        private int GetParsingStartIndex(string[] line)
        {
            return IgnoreFirstLine(line) ? 1 : 0;
        }

        private bool IgnoreFirstLine(string[] line)
        {
            return (line[0].Split(';')[0] == "SPZ");
        }

        private CarModel ParseCarModel(string[] row)
        {
            CarModel model = new CarModel();
            model.Spz = row[0];
            model.Date = DateTime.Parse(row[1]);
            model.Color = row[2];
            model.Speed = double.Parse(row[4]);
            model.Vehicle = (CarType)int.Parse(row[3]);
            return model;
        }

        private bool IsFilePathValid(string filePath)
        {
            return File.Exists(filePath);
        }

        public List<CarModel> GetRecords()
        {
            return _records;
        }
    }
}