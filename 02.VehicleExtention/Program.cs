using System;


class Program
{
    static void Main(string[] args)
    {
        var carInput = Console.ReadLine().Split();
        var truckInput = Console.ReadLine().Split();
        var busInput = Console.ReadLine().Split();

        Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]),double.Parse(carInput[3]));
        Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
        Vehicle bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

        var nums = int.Parse(Console.ReadLine());
        CommandVehicles(car, truck, bus,nums);
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static void CommandVehicles(Vehicle car, Vehicle truck, Vehicle bus,int nums)
    {
        for (int i = 0; i < nums; i++)
        {
            var commands = Console.ReadLine().Split();
            var typeCommand = commands[0];
            var typeVehicle = commands[1];
            var distance = double.Parse(commands[2]);
            try
            {
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
                            case "Bus":
                                Console.WriteLine(bus.Drive(distance));
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
                            case "Bus":
                                bus.Refuel(distance);
                                break;
                        }
                        break;
                    case "DriveEmpty":
                        ((Bus)bus).SwitchOffAirConditioner();
                        Console.WriteLine(bus.Drive(distance));
                        ((Bus)bus).SwitchOnAirConditioner();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}
