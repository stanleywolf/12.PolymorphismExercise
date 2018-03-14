using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var animals = new List<Animal>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            FillAnimals(command, animals);
        }
        PrintResult(animals);
    }

    private static void PrintResult(List<Animal> animals)
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static void FillAnimals(string command, List<Animal> animals)
    {
        var tokens = command.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);

        var foodTokens = Console.ReadLine().Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries);
        var typeFood = foodTokens[0];
        var quantity = int.Parse(foodTokens[1]);

        Food food = null;
        switch (typeFood)
        {
            case "Vegetable":
                food = new Vegetable(quantity);
                break;
            case "Fruit":
                food = new Fruit(quantity);
                break;
            case "Meat":
                food = new Meat(quantity);
                break;
            case "Seeds":
                food = new Seeds(quantity);
                break;
        }

        if (tokens.Length == 5)
        {
            try
            {
                switch (tokens[0])
                {
                    case "Cat":
                        var cat = new Cat(tokens[1], double.Parse(tokens[2]), 0, tokens[3], tokens[4]);
                        cat.ProduceSound();
                        animals.Add(cat);
                        if (cat.IsEaten(food))
                        {
                            cat.EatFood(quantity);
                        }
                        break;
                    case "Tiger":
                        var tiger = new Tiger(tokens[1], double.Parse(tokens[2]), 0, tokens[3], tokens[4]);
                        tiger.ProduceSound();
                        animals.Add(tiger);
                        if (tiger.IsEaten(food))
                        {
                            tiger.EatFood(quantity);
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else if (tokens.Length == 4)
        {
            try
            {
                switch (tokens[0])
                {
                    case "Mouse":
                        var mouse = new Mouse(tokens[1], double.Parse(tokens[2]), 0, tokens[3]);
                        mouse.ProduceSound();
                        animals.Add(mouse);
                        if (mouse.IsEaten(food))
                        {
                            mouse.EatFood(quantity);
                        }
                        break;
                    case "Dog":
                        var dog = new Dog(tokens[1], double.Parse(tokens[2]), 0, tokens[3]);
                        dog.ProduceSound();
                        animals.Add(dog);
                        if (dog.IsEaten(food))
                        {
                            dog.EatFood(quantity);
                        }
                        break;
                    case "Hen":
                        var hen = new Hen(tokens[1], double.Parse(tokens[2]), 0, double.Parse(tokens[3]));
                        hen.ProduceSound();
                        animals.Add(hen);
                        if (hen.IsEaten(food))
                        {
                            hen.EatFood(quantity);
                        }
                        break;
                    case "Owl":
                        var owl = new Owl(tokens[1], double.Parse(tokens[2]), 0, double.Parse(tokens[3]));
                        owl.ProduceSound();
                        animals.Add(owl);
                        if (owl.IsEaten(food))
                        {
                            owl.EatFood(quantity);
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}