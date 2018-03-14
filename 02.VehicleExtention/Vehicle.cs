using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public abstract class Vehicle
{

    public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.LitersPerKM = litersPerKm;
        if (fuelQuantity > TankCapacity)
        {
            FuelQuantity = 0;
        }
        else
        {
            FuelQuantity = fuelQuantity;
        }
    }


    public double TankCapacity { get; set; }
    public double FuelQuantity { get; set; }
    public double LitersPerKM { get; set; }
    public abstract double AirConditioner { get; }



    public virtual string Drive(double km)
    {
        double requiredFuel = (LitersPerKM + AirConditioner) * km;

        if (requiredFuel <= FuelQuantity)
        {
            FuelQuantity -= requiredFuel;
            return $"{this.GetType().Name} travelled {km} km";
        }

        return $"{this.GetType().Name} needs refueling";
    }

    public virtual void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (fuel + FuelQuantity > this.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");

        }
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}