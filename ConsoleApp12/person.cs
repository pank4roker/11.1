using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// Класс Person, который представляет человека 
    /// </summary>
     class Person
    {
        /// <summary>
        /// Поле имени
        /// </summary>
        public string name;
        /// <summary>
        /// Поле фамилии
        /// </summary>
        public string surname;
        /// <summary>
        /// Поле лет
        /// </summary>
        public int age;
        public void Info()
        {
            Console.WriteLine($"name ={name}\t surname = {surname}\t age = {age}");
        }
        public override string ToString()
        {
            return $"name ={name}\t surname = {surname}\t age = {age}";
        }
    }
}
