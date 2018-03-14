using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public abstract class Vehicle
{

    public Vehicle(double fuelQuantity, double litersPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKM = litersPerKm;
    }
    public double FuelQuantity { get; set; }
    public double LitersPerKM { get; set; }
    
    
    public virtual string Drive(double km)
    {
        var fuelSpend = this.LitersPerKM * km;
        if (fuelSpend < this.FuelQuantity)
        {
            this.FuelQuantity -= fuelSpend;
            return $"{this.GetType().Name} travelled {km} km";
        }
        else
        {
            return $"{this.GetType().Name} needs refueling";
        }
    }

    public virtual void Refuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}