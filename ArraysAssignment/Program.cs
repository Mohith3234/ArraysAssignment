using System;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary1;
namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
           Car car1 = new Car() { Make="Toyoto",Model="Corolla",RentalPrice=50,Rentted=true};
            Car car2 = new Car() { Make = "Honda", Model = "Civic", RentalPrice = 80, Rentted = true };
            Car car3 = new Car() { Make = "Ford", Model = "Mustang", RentalPrice = 80, Rentted = true };
            Console.WriteLine("Welcome to the car rental System");
            Console.WriteLine();
            int Value = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Rent a car");
                Console.WriteLine("2. Return a car");
                Console.WriteLine("3. View avalable cars");
                Console.WriteLine("4. Exit");
                Console.Write("Please Chose your one option : ");
                Value = int.Parse(Console.ReadLine());
                Console.WriteLine(Value);

                {
                    Car[] array = new Car[3] { car1, car2, car3 };
                    switch (Value)
                    {
                        case 1:
                            {
                                Console.WriteLine("Rent");
                               
                                Console.WriteLine("Rent Car");
                                Console.WriteLine("1. Toyoto Corolla (Rental price: 50/day) : "+car1.Rentted);
                                Console.WriteLine("2. Honda Civic (Rental price: 80/day) : "+car2.Rentted);
                                Console.WriteLine("3. Ford Mustang (Rental price: 80/day) : "+car3.Rentted);
                                Console.Write("chose your Id : ");
                                int id1=int.Parse(Console.ReadLine());
                                array[id1-1].Rent();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Return Car");
                            Console.WriteLine("1. Toyoto Corolla (Rental price: 50/day) : " + car1.Rentted);
                            Console.WriteLine("2. Honda Civic (Rental price: 80/day) : " + car2.Rentted);
                            Console.WriteLine("3. Ford Mustang (Rental price: 80/day) : " + car3.Rentted);
                            Console.Write("chose your Id : ");
                            int id2 = int.Parse(Console.ReadLine());
                            array[id2 - 1].Return();
                            break;
                        case 3:
                            Console.WriteLine("View");
                            Console.WriteLine("Available Car");
                            Console.WriteLine("1. Toyoto Corolla (Rental price: 50/day) : " + car1.Rentted);
                            Console.WriteLine("2. Honda Civic (Rental price: 80/day) : " + car2.Rentted);
                            Console.WriteLine("3. Ford Mustang (Rental price: 80/day) : " + car3.Rentted);
                            
                            break;
                        default:
                            Console.WriteLine("Exit");
                            break;

                    }
                }
            } while (Value != 4);

           

            Console.ReadKey();

        }
    }
}
