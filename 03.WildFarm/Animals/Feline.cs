﻿using System;
using System.Collections.Generic;
using System.Text;

public abstract class Feline : Mammal
{
    public Feline(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion)
    {
        this.Breed = breed;
    }
    public string  Breed { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}