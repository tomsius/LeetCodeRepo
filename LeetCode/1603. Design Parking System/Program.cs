using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603.Design_Parking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);

            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(2)); 
            Console.WriteLine(parkingSystem.AddCar(3)); 
            Console.WriteLine(parkingSystem.AddCar(1));

            Console.ReadKey();
        }
    }
}
