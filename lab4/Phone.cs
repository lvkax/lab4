using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Phone
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public string Cost { get; set; }

        public string ReleaseYear { get; set; }

        public int YearOfPurchase { get; set; }

        public string BatteryCapacity { get; set; }

        public bool Has3Cameras { get; set; }

        public bool HasWirelessCharging { get; set; }

        public double GetGuaranteeEndingYear()
        {
            if (Name == "iPhone") return YearOfPurchase + 1;
            else if (Name == "Samsung") return YearOfPurchase + 2;
            else return YearOfPurchase + 3;
        }
/*
        public double GuaranteeEndingYear
        {
            get { return GetGuaranteeEndingYear(); }
            set;
        }
*/
        public Phone(string name, string model, string cost, string releaseyear, int yearofpurchase,
            string batterycapacity, bool has3cameras, bool haswirelesscharging) 
        {
            Name = name; Model = model; Cost = cost; ReleaseYear = releaseyear;
            YearOfPurchase = yearofpurchase; BatteryCapacity = batterycapacity;
            Has3Cameras = has3cameras; HasWirelessCharging = haswirelesscharging;
        }
    }
}
