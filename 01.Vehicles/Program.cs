using System;


class Program
{
    static void Main(string[] args)
    {
        var carInput = Console.ReadLine().Split();
        var truckInput = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
        Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

        var nums = int.Parse(Console.ReadLine());
        CommandVehicles(car, truck, nums);
        Console.WriteLine(car);
        Console.WriteLine(truck);
    }

    private static void CommandVehicles(Vehicle car, Vehicle truck, int nums)
    {
        for (int i = 0; i < nums; i++)
        {
            var commands = Console.ReadLine().Split();
            var typeCommand = commands[0];
            var typeVehicle = commands[1];
            var distance = double.Parse(commands[2]);
            switch (typeCommand)
            {
                case "Drive":
                    switch (typeVehicle)
                    {
                        case "Car":
                            Console.WriteLine(car.Drive(distance));
                            break;
                        case "Truck":
                            Console.WriteLine(truck.Drive(distance));
                            break;
                    }
                    break;
                case "Refuel":
                    switch (typeVehicle)
                    {
                        case "Car":
                            car.Refuel(distance);
                            break;
                        case "Truck":
                            truck.Refuel(distance);
                            break;
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}