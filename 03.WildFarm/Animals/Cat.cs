using System;
using System.Collections.Generic;
using System.Text;

public class Cat:Feline
{
    public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
    {
    }

    public override int EatFood(int quantity)
    {
        this.Weight += 0.3 * quantity;
        return base.EatFood(quantity);
    }

    public override bool IsEaten(Food typeFood)
    {
        string type = typeFood.GetType().Name;
        if (type == nameof(Vegetable) || type == nameof(Meat))
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
        Console.WriteLine("Meow");
    }

    
}