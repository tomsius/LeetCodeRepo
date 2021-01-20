using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603.Design_Parking_System
{
    class ParkingSystem
    {
        private int[] parkingLots = new int[3];

        public ParkingSystem(int big, int medium, int small)
        {
            parkingLots[0] = big;
            parkingLots[1] = medium;
            parkingLots[2] = small;
        }

        public bool AddCar(int carType)
        {
            if (parkingLots[carType - 1] > 0)
            {
                parkingLots[carType - 1]--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
