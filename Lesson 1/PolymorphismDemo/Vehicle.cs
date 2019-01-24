using System;

namespace PolymorphismDemo
{

    public class Vehicle {
        private int _wheels;
        public virtual int Wheels { 
            get {
                return _wheels;
                }
            set {
                _wheels = value;
                }
            }
        public virtual float Speed {get; protected set;}

        public float Accelerate (float amount) {
            Speed += amount;
            return Speed;
        }

        public float Decelerate (float amount) {
            Speed -= amount;
            return Speed;
        }

        public string SurroundingVehicleNotification() {
            return "Honk!";
        }
    }
}