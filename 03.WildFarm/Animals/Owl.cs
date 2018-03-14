using System;
using System.Collections.Generic;
using System.Text;

public class Owl:Bird
{
    public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {
    }
    public override int EatFood(int quantity)
    {
        this.Weight += 0.25 * quantity;
        return base.EatFood(quantity);
    }

    public override bool IsEaten(Food typeFood)
    {
        string type = typeFood.GetType().Name;
        if (type == nameof(Meat))
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
        Console.WriteLine("Hoot Hoot");
    }

}