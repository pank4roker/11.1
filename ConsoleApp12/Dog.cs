using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// Класс, описывающий собак
    /// </summary>
    class Dog
    {
        /// <summary>
        /// Поле породы
        /// </summary>
        public string breed;
        /// <summary>
        /// Поле размера
        /// </summary>
        public string size;
        /// <summary>
        /// Поле возраста
        /// </summary>
        public int age;
        /// <summary>
        /// Поле цвета
        /// </summary>
        public string color;
        public override string ToString()
        {
            return $"Порода:{breed}\nРазмер:{size}\nВозраст:{age} лет\nЦвет:{color}\n";
        }
        public  Eat()
        {
            return "";
        }
        
    }
}
