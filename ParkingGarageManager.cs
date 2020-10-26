using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public class ParkingGarageManager
    {
        public int Capacity { get; set; }
        public int CapacitySmall { get; set; }
        public int CapacityMedium { get; set; }
        public int CapacityLarge { get; set; }
        IDictionary<string, string> dict = new Dictionary<string, string>(); //<id, parkingslot>

        public ParkingGarageManager(Config config)
        {
            this.Capacity = config.Capacity;
            this.CapacitySmall = config.CapacitySmall;
            this.CapacityMedium = config.CapacityMedium;
            this.CapacityLarge = config.CapacityLarge;
        }

        public string RequestParkingSlot(Requester requester)
        {
            string tktNum = "";
            int numOfCars = 0;

            foreach (KeyValuePair<string, string> entry in dict)
            {
                if (entry.Key == requester.Id)
                {
                    numOfCars++;
                }
            }

            if(requester.MaxVehicles >= numOfCars || dict.Count == this.Capacity)
                return null;

            tktNum = dict.Count.ToString();
            dict.Add(requester.Id, tktNum);

            return tktNum;
        }

        public bool LeaveParkingGarage(string ticket)
        {
            bool leave = false;
            foreach (KeyValuePair<string, string> entry in dict)
            {
                if (entry.Value == ticket)
                {
                    leave = true;
                    break;
                }
            }

            if (leave)
            {
                dict.Remove(ticket);
            }
            return leave;
        }
    }

     public class Requester {
            public string Id { get; set; }
            public int UnluckyNumber { get; set; }
            public int Size { get; set; }
            public int MaxVehicles { get; set; }
        }

        public class Config {
            public int Capacity; //=> CapacitySmall + CapacityMedium + CapacityLarge;
            public int CapacitySmall { get; set; }
            public int CapacityMedium { get; set; }
            public int CapacityLarge { get; set; }
        }
}
