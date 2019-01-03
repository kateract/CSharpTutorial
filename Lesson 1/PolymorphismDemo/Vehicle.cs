using System;

namespace PolymorphismDemo
{

    public class Vehicle {
        public int Wheels { get; set;}
        public float Speed {get; protected set;}

        public float Accelerate (float amount) {
            Speed += amount;
            return Speed;
        }

        public float Decelerate (float amount) {
            Speed -= amount;
            return Speed;
        }

        public virtual string SurroundingVehicleNotification() {
            return "Honk!";
        }
    }
}