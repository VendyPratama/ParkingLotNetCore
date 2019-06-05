using System;
using Commands;
using Models;

namespace ParkingLotNetCore {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("*****WELCOME TO THE PARKING LOT APPLICATION*****");
            Console.Write ("Input parking lot name : ");
            string inputName = Console.ReadLine ();
            Console.Write ("Input max slot : ");
            int maxSlot = int.Parse (Console.ReadLine ());
            var instance = ParkingLot.Instance (parkingName: inputName);
            Console.WriteLine ("Type \"plot help\" for list commands");

            CommandManager commnadManager = new CommandManager ();
            commnadManager.Run ();
        }
    }
}