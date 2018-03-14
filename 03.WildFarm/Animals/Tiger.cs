using System;
using System.Collections.Generic;
using System.Text;

public class Tiger:Feline
{
    public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
    {
    }

    public override int EatFood(int quantity)
    {
        this.Weight += 1.0 * quantity;
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
        Console.WriteLine("ROAR!!!");
    }    
}