namespace Lesson
{
    class Program
    {
        interface IVehiculo
        {

            bool Refuel(int fuel);
            void Drive();
        }

        class Car : IVehiculo
        {
            private int  _fuel;

            public int Fuel
            {
                get
                {
                    return _fuel; 
                }
                set
                {
                    _fuel = value;
                }
            }

            public Car(int fuel) 
            {
                Fuel = fuel;
            }

            public void Drive()
            {
                if (Fuel < 0)
                {
                    Console.WriteLine("You can't drive");
                }
                else
                {
                    Console.WriteLine("Car driving");
                    Fuel--;
                }
            }

            public bool Refuel(int fuel)
            {
                if (Fuel > 0)
                {
                    Fuel = fuel;
                    return true;
                }
                else
                    Fuel = fuel;
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Car car = new Car(0);
            while (true)
            {
                if (car.Fuel == 0)
                {
                    Console.WriteLine("You want to refuel your car? y/n");
                    string? choice = Console.ReadLine();
                    if (choice == "y")
                        car.Refuel(10);
                    else
                    {
                        Console.WriteLine("You can't drive");
                        break;
                    }
                }

                    car.Drive();
            }
        }
    }
}