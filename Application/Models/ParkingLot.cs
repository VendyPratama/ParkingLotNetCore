using System.Collections.Generic;

namespace Models {
    public class ParkingLot {

        /// <summary>
        /// Parking lot structure 
        /// </summary>
        /// <param name="parkingName"></param>
        private ParkingLot (string parkingName) {
            Name = parkingName;
            Slots = new List<Slot> ();
            Histories = new List<Car> ();
        }

        public string Name { get; }
        public List<Slot> Slots { get; }
        public List<Car> Histories { get; }
        public override string ToString () {
            return Name;
        }

        private static ParkingLot _singleton = null;
        /// <summary>
        /// Singleton parkinglot struct
        /// </summary>
        /// <param name="parkingName"></param>
        /// <returns></returns>
        public static ParkingLot Instance (string parkingName) {
            if (_singleton == null)
                _singleton = new ParkingLot (parkingName: parkingName);
            return _singleton;
        }
    }
}