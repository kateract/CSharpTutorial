﻿using System;

namespace PolymorphismDemo
{
    //no access modifier means internal by default
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle wagon = new Vehicle();
            wagon.Wheels = 4;
            Console.WriteLine(wagon.SurroundingVehicleNotification());
        }
    }

    
}
