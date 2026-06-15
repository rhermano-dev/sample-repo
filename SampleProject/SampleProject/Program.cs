using System;

namespace SampleNameSpace
{
    public abstract class Vehicle
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID :{this.Id}");
            Console.WriteLine($"Name :{this.Name}");
            Console.WriteLine($"=============");
        }
        public abstract void Sound();
    }

    public class Car : Vehicle
    {

        public override void Sound()
        {
            Console.WriteLine("Vroom");
        }
    }

    public class Bike : Vehicle
    {

        public override void Sound()
        {
            Console.WriteLine("Honk");
        }
    }

    public class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0) { balance += amount; }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance ) { balance -= amount; }
        }

        public decimal GetBalance() { return balance; }

    }

    class Program
    {
        string _myString = "";

        static void Main(string[] args)
        {
            // 
            List<Car> listOfCars = new();

            while (true)
            {
                Console.WriteLine("Enter Something");
                Console.WriteLine("1: Car");
                Console.WriteLine("2: Bike");
                Console.WriteLine("3: Display all Cars");
                Console.WriteLine("4: Display all Bike");
                Console.WriteLine("5: Exit");

                var selectedOption1 = Console.ReadKey().KeyChar.ToString().ToLower();

                switch (selectedOption1)
                {
                    case "1":
                        Car car = new()
                        {
                            Id = Guid.NewGuid().ToString()
                        };

                        Console.WriteLine("Enter Car Name: ");
                        car.Name = Console.ReadLine();

                        listOfCars.Add(car);
                        break;
                    case "3":
                       
                        foreach(Car car1 in listOfCars)
                        {
                            car1.DisplayInfo();
                        }
                        break;
                    case "5": return;
                }

            }
        }
    }


}
