using System;
using CSharpBasic.Abstraction;
using CSharpBasic.AccessModifiers;
using CSharpBasic.Interface;

namespace CSharpBasic
{
    public abstract class  Vehicle
    {
        public string Modal { get; set; }
        public string Color { get; set; }

        public abstract void vehicalInfo();
        
        public class Car : Vehicle
        {
            public Car()
            {
                Modal = "2019";
                Speed = "300mph";
                Name = "Vazel";
                Color = "White";
            }
            public string Name { get; set; }
            public string Speed { get; set; }
            public override void vehicalInfo()
            {
                Console.WriteLine("\t\t\t\tCar Information ::\n");
                Console.WriteLine($"Car Color is :: {Color}\nCar Modal is {Modal}\n Car Name is {Name}\n Car Speed is {Speed}mph");
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }
        public class SportsCar : Car
        {
            public SportsCar()
            {
                Modal = "2020";
                Color = "Red";
                Name = "Ferrari";
                Speed = "800";
            }
            public override void vehicalInfo()
            {
                Console.WriteLine("\t\t\t\tSportsCar Information ::\n");
                Console.WriteLine($"Car Color is :: {Color}\nCar Modal is {Modal}\nCar Name is {Name}\nCar Speed is {Speed}mph");
                Console.WriteLine("-----------------------------------------------------------------");

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Vehicle vehicle = new SportsCar();
                vehicle.vehicalInfo();
                Child child = new Child();
                child.Print();
                Console.WriteLine($"{child.id}");
                Console.WriteLine("--------------------INTERFACE-------------------------------------");
                ICustomer2 customer2 = new Demo();
                customer2.Print();
                customer2.Print1();
                ParmanentEmployees parmanentEmployees = new ParmanentEmployees();
                parmanentEmployees.FirstName = "Hassan";
                parmanentEmployees.LastName = "Ali";
                parmanentEmployees.MonthlySalary = 30000;
                Console.WriteLine("--------------------Parmanent Employee Information-------------------------------------");
                Console.WriteLine($"Name OF Employee :: {parmanentEmployees.getFullName()}\nYearly Salary ::{parmanentEmployees.CalculateSalary()}RS");
                Console.WriteLine("--------------------Contract Employee Information-------------------------------------");
                ContractEmployees contractEmployees = new ContractEmployees();
                contractEmployees.FirstName = "Muhammad";
                contractEmployees.LastName = "Abubakar";
                contractEmployees.HourlyPay = 100;
                contractEmployees.TotalWorkingHours = 10;
                Console.WriteLine($"Name OF Employee :: {contractEmployees.getFullName()}\nTotal Salary ::{contractEmployees.CalculateSalary()}RS");
                Console.WriteLine("--------------------Types OF Variable-------------------------------------");
                Variables variables = new Variables();
                Console.WriteLine($" static & Also Constant Variable=> {Variables.PI} \n static Variable =>{Variables.Kilo = 100}\n readonly Variable =>{ variables.Name}");
                Console.Read();

            }
        }
    }
}