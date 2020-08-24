using System;
using System.Collections.Generic;
using System.Linq;
using CSharpBasic.Abstraction;
using CSharpBasic.AccessModifiers;
using CSharpBasic.DateTimeManipulation;
using CSharpBasic.Dictionary;
using CSharpBasic.Getter_Setter;
using CSharpBasic.HashSets;
using CSharpBasic.IEnumrable_and_IQueryable;
using CSharpBasic.IEumerable_And_IEnumerator;
using CSharpBasic.Interface;
using CSharpBasic.Param_KeyWord;
using CSharpBasic.Ref_and_out;
using static CSharpBasic.Vehicle;

namespace CSharpBasic
{
    public abstract class Vehicle
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
    }
    class Program
        {
            static void Main(string[] args)
            {
                Vehicle vehicle = new SportsCar();
                vehicle.vehicalInfo();
                  Manipulation.showDate();
                #region IEnumerable and IQuerable
                IEnumerable<Demo1> demo1s = Database.Data();
                IEnumerable<Demo1> Search = demo1s.Where(e => e.ID.Equals(101)).ToList();
                /*
                 * IQuryable work when we make our dbset so it will not work in static data 
                 * Major Difference betwwen both of them is IEnumrable get all data from database 
                 * and after check the condition But IQueryable First check the condition then retrive the data from database
                 */

                //it
                //IQueryable<Demo1> Search1 = demo1s.Where(t => t.ID.Equals(101));
                foreach (var item in Search)
                {
                    Console.WriteLine($"Student ID =>  {item.ID}\n  Student Name => {item.Name} \n  Student Marks => {item.Marks}");
                }

                #endregion
                #region YieldKeyword
                Console.WriteLine("--------------------Yield Keyword--------------------------------------------------------");
                foreach (var item in Yield.getYieldResults())
                {
                    Console.WriteLine(item);
                }
                #endregion
                #region HashSets
                Console.WriteLine("--------------------Hash Sets--------------------------------------------------------");
                Hash.CreateHashSet();
                #endregion
                #region Dictionary
                DataDictionary dataDictionary = new DataDictionary();
                dataDictionary.ID = 101;
                dataDictionary.Name = "Abubakar";
                dataDictionary.Marks = 80;
                DataDictionary dataDictionary1 = new DataDictionary();
                dataDictionary1.ID = 102;
                dataDictionary1.Name = "Ali Hassan";
                dataDictionary1.Marks = 90;
                DataDictionary dataDictionary2 = new DataDictionary();
                dataDictionary2.ID = 103;
                dataDictionary2.Name = "Ahmed Hammad";
                dataDictionary2.Marks = 100;
                Dictionary<int, DataDictionary> data = new Dictionary<int, DataDictionary>();
                data.Add(dataDictionary1.ID, dataDictionary1);
                data.Add(dataDictionary2.ID, dataDictionary2);
                data.Add(dataDictionary.ID, dataDictionary);

                foreach (var x in data)
                {
                    Console.WriteLine("Key is :: " + x.Key);
                    Console.WriteLine("Value is ::" + x.Value.ID + "Name :: " + x.Value.Name + "Marks ::" + x.Value.Marks);
                }

                #endregion
                #region IEnumerable
                Console.WriteLine("--------------------IEnumrable And IEnumrator Collections--------------------------------------------------------");
                List<int> Enum = new List<int>();
                Enum.Add(1990);
                Enum.Add(1999);
                Enum.Add(2000);
                Enum.Add(2004);
                Enum.Add(2005);
                IEumable eumable = new IEumable();
                IEnumrator enumrator = new IEnumrator();
                IEnumerator<int> Enum1 = Enum.GetEnumerator();
                enumrator.getNintees(Enum1);
                eumable.getNintees(Enum);
                #endregion
                #region Ref And Out
                Console.WriteLine("--------------------Ref And Out keyword--------------------------------------------------------");
                int reference = 40;
                int Out;
                Class1 class1 = new Class1();
                class1.show(ref reference);
                class1.show1(out Out);
                class1.writeFile();
                class1.readFile();
                Console.WriteLine($"Using Reference keyword:: {reference} \nUsing Out keyword :: {Out}");
                #endregion
                #region use Parms Keyword 
                Console.WriteLine("--------------------Pass Multipal arguments Using Param keyword-------------------------------------");
                int English = 68, Math = 75, Urdu = 85, Chemistry = 80, physics = 90;
                Params p = new Params();
                Console.WriteLine($"Total Marks = {p.CalculateTotalMarks("Pass", new int[] { English, Urdu, Math, Chemistry, physics })}");
                #endregion
                #region Getter Settter
                Console.WriteLine("--------------------Getter Setter-------------------------------------------------------------------");
                Student student = new Student();
                student.setId(101);
                student.setName("Abubakar");
                student.setMarks(10);
                Console.WriteLine($"Student ID :: {student.GetID()}\nStudent Name :: {student.getName()}\nStudent Marks :: {student.getMarks()}");
                #endregion
                #region Access Modifiers
                Console.WriteLine("--------------------ACCESS MODIFIERS-------------------------------------");
                Child child = new Child();
                child.Print();
                Console.WriteLine($"{child.id}");
                #endregion
                #region Interface
                Console.WriteLine("--------------------INTERFACE-------------------------------------");
                ICustomer2 customer2 = new Demo();
                customer2.Print();
                customer2.Print1();
                #endregion
                #region Abstraction
                Console.WriteLine("--------------------Abstraction-------------------------------------");
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
                #endregion
                #region Types of Variables
                Console.WriteLine("--------------------Types OF Variable-------------------------------------");
                Variables variables = new Variables();
                Console.WriteLine($" static & Also Constant Variable=> {Variables.PI} \n static Variable =>{Variables.Kilo = 100}\n readonly Variable =>{ variables.Name}");
                Console.Read();
                #endregion
            }
        }
    }
