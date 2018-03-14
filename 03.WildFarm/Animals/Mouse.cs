using System;
using System.Collections.Generic;
using System.Text;

public class Mouse:Mammal
{
    public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
    {
    }

    public override int EatFood(int quantity)
    {
        this.Weight += 0.10 * quantity;
        return base.EatFood(quantity);
    }

    public override bool IsEaten(Food typeFood)
    {
        string type = typeFood.GetType().Name;
        if (type == nameof(Vegetable) || type == nameof(Fruit))
        {
            return base.IsEaten(typeFood);
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name } does not eat {typeFood.GetType().Name}!");
        }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}