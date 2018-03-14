using System;
using System.Collections.Generic;
using System.Text;

public class Bus:Vehicle
{
    private AirConditionerCondition air;

    public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
    {
        this.air = AirConditionerCondition.On;

    }

    public override double AirConditioner =>
        air == AirConditionerCondition.On ? 1.4 : (double)AirConditionerCondition.Off;

    public void SwitchOnAirConditioner()
    {
        this.air = AirConditionerCondition.On;
    }

    public void SwitchOffAirConditioner()
    {
        this.air = AirConditionerCondition.Off;
    }
}