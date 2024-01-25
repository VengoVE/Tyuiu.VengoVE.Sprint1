using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VengoVE.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double x)
        {
            Console.WriteLine("Введите температуру в градусах Фаренгейта:");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            int roundedCelsius = Convert.ToInt32(celsius);

            Console.WriteLine("Температура в градусах Цельсия: " + roundedCelsius);

            return roundedCelsius;
        }
    }
}
