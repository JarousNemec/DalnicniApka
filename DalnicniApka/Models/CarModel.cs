using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalnicniApka.Models
{
    public class CarModel
    {
        public string Spz { get; set; }
        public string Color { get; set; }
        public double Speed { get; set; }
        public DateTime Date { get; set; }
        public CarType Vehicle { get; set; }

        public override string ToString()
        {
            return $"{Spz} - {Date}";
        }

        public string GetDetails()
        {
            return $"SPZ: {Spz}, Color: {Color}, Speed: {Speed}, Type: {Vehicle}";
        }
    }

    public enum CarType
    {
        Car = 0,
        Bus = 1,
        Truck = 2,
        Tank = 300,
        Motobike = 4
    }
}
