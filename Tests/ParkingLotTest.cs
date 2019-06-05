using Models;
using Xunit;

namespace Tests {
    public class ParkingLotTest {

        [Fact]
        public void ParkingLotInstance_MustEqual () {
            string parkingLotName = "Test Park";
            //Given
            var instanceParkingLot1 = ParkingLot.Instance (parkingLotName);

            //When
            var instanceParkingLot2 = ParkingLot.Instance ("Test2 Park");

            //Then
            Assert.Equal (expected: instanceParkingLot1, actual: instanceParkingLot2);
            Assert.Equal (expected: parkingLotName, actual: instanceParkingLot2.ToString ());
        }
    }
}