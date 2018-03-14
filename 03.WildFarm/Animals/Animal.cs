using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{
    public Animal(string name, double weight,int foodEaten)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = foodEaten;
    }
    private string name;
    private double weight;
    private int foodEaten;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double  Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }

    public virtual void ProduceSound()
    {
        
    }

    public virtual bool IsEaten(Food typeFood)
    {
        return true;
    }
    public virtual int EatFood(int quantity)
    {
        return this.FoodEaten += quantity;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, ";
    }
}