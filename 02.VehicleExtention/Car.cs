﻿using System;
using System.Collections.Generic;
using System.Text;

public class Car:Vehicle
{
    public Car(double fuelQuantity, double litersPerKm,double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
    {
       
    }

    public override double AirConditioner => 0.9;
}