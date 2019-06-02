using System;

namespace Models {
    public class Car {

        /// <summary>
        /// A Car struct
        /// </summary>
        /// <param name="vehicleNumber"></param>
        public Car (string vehicleNumber) {
            Number = vehicleNumber;
            ComeIn = DateTime.UtcNow;
        }

        public string Number { get; }
        public string Color { get; set; }
        public DateTime ComeIn { get; }
        public DateTime ComeOut { get; set; }
    }
}