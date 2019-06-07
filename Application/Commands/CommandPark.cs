using System;
using System.Collections.Generic;
using Constants;
using Models;

namespace Commands {
    public class CommandPark : ICommand {
        public CommandPark () {
            _parkingLotInstance = ParkingLot.Instance (Constant.ParkingLotArgs);
            Args = new List<string> ();
        }

        private readonly ParkingLot _parkingLotInstance;

        public List<string> Args { get; set; }

        public string Help () {
            string msg = "Help park command \"park [Vehicle Number] [Color (optional)]\"";
            return msg;
        }

        public void ParseArguments (List<string> args) {
            Args = args;
        }

        public string Run () {
            if (Args.Contains (Constant.HelpArgumentCommand))
                return Help ();

            if (Args.Count < 1)
                return Help ();

            string msg = string.Empty;
            return msg;
        }

        public bool CheckSlotIsAvailable () {
            bool isSlotAvailable = true;

            return isSlotAvailable;
        }
    }
}