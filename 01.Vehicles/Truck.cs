using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
    {
        this.LitersPerKM = litersPerKm + 1.6;
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel * 0.95;
    }
}