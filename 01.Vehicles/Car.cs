using System;
using System.Collections.Generic;
using System.Text;

public class Car:Vehicle
{
    public Car(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
    {
        this.LitersPerKM = litersPerKm + 0.9;
    }

    
}