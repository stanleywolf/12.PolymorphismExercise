using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    private const double airCondPerKm = 1.6;

    public Truck(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm,tankCapacity)
    {
       
    }

    public override double AirConditioner => airCondPerKm;
    

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel);        
        this.FuelQuantity -= (1 - 0.95) * fuel;     
    }

}