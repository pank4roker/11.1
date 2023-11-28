using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
                         //Task 1
            //Person person = new Person();
            //person.name = "иван";
            //person.surname = "Иванов";
            //person.age = 20;
            //person.Info();
            //Person person1 = new Person();
            //person1.name = "иван";
            //person1.surname = "Иванов";
            //person1.age = 20;
            //Cons;ole.WriteLine($"{person1.ToString()}")
                          //Task 2
            //Address addess = new Address();
            //addess.index = 3300;
            //addess.country = "Молдова";
            //addess.city = "Кишинев";
            //addess.street = "Востояная";
            //addess.houses = 12;
            //addess.apartament = 12;
            //Console.WriteLine($"{addess.ToString()}");
                          //Task 3
            Dog dog = new Dog();
            dog.breed = "Мастифф";
            dog.size = "Большой";
            dog.age = 5;
            dog.color = "Черный";
       
            Console.WriteLine($"{dog.ToString()}");
            

            Console.ReadKey();

        }
    }
}
