using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// Класс, описывающий адрес
    /// </summary>
    class Address
    {
        /// <summary>
        /// Поле индекса
        /// </summary>
        public ushort index;
        /// <summary>
        /// Поле название страны
        /// </summary>
        public string country;
        /// <summary>
        ///  Поле названия города
        /// </summary>
        public string city;
        /// <summary>
        ///  Поле улицы
        /// </summary>
        public string street;
        /// <summary>
        /// Поле дома
        /// </summary>
        public ushort houses;
        /// <summary>
        /// Поле квартиры
        /// </summary>
        public ushort apartament;
        /// <summary>
        /// Метод вывода информации об адресе
        /// </summary>
        /// <returns>индекс,страна,город,улица,дом,квартира</returns>
        public override string ToString()
        {
            return $"{index}\t{country}\t{city}\t{street}\t{houses}\t{apartament}\t";
        }


    }
}
