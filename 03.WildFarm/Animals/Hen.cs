using System;
using System.Collections.Generic;
using System.Text;

public class Hen:Bird
{
    public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {
    }

    public override int EatFood(int quantity)
    {
        this.Weight += 0.35 * quantity;
        return base.EatFood(quantity);
    }
  
    public override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }
}