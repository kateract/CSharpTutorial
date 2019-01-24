using System;

namespace PolymorphismDemo {
    public class Bicycle : Vehicle {
        public override int Wheels { get {return 2; } }

        public new string SurroundingVehicleNotification() {

            return base.SurroundingVehicleNotification() + " Oops, I mean, Ring Ring!"; 
        }
    }
}