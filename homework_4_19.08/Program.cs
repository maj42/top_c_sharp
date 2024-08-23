using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane planeDefault = new Plane();
            Plane planeWithParams = new Plane("Kukuruznik", "USSR", PlaneType.Jet, 1930);

            Plane planeWithManInp = new Plane();
            planeWithManInp.InputPlane();

            Console.WriteLine("Planes:\n\n");
            planeDefault.print();
            planeWithParams.print();
            planeWithManInp.print();
        }
    }

    public enum PlaneType
    {
        Passanger,
        Cargo,
        Jet,
        Military,
        Unknown
    }

    class Plane
    {
        string planeName;
        int planeYear;
        string planeCountry;
        PlaneType planeType;

        public Plane() //по умолчанию
        {
            planeName = string.Empty;
            planeCountry = string.Empty;
            planeYear = 0;
            planeType = PlaneType.Unknown;
        }

        public Plane(string name, string country, PlaneType type, int year)
        {
            //с параметрами
            {
                planeName = name;
                planeCountry = country;
                planeType = type;
                planeYear = year;
            }
        }

        public void print()
        {
            Console.WriteLine($"\tName: {this.planeName}\n\tCountry of origin: {this.planeCountry}" +
                $"\n\tType: {this.planeType}\n\tYear of construction: {this.planeYear}\n\n");
        }

        public void InputPlane()
        {
            Console.WriteLine("Сейчас вы будете вводить данные самолета." +
                "\n\n Сперва введите название самолета:");
            planeName = Console.ReadLine();

            Console.WriteLine("\n\n Страна происхождения самолета:");
            planeCountry = Console.ReadLine();

            Console.WriteLine("\n\n Год выпуска:");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                planeYear = year;
            }
            else
            {
                Console.WriteLine("Invalid год, " +
                    "установка значения по умолчанию");
                planeYear = 0;
            }

            Console.WriteLine("Введите тип:");
            Console.WriteLine("0 - пассажирский");
            Console.WriteLine("1 - грузовой");
            Console.WriteLine("2 - приватный джет");
            Console.WriteLine("3  - военный ");
            Console.WriteLine("4 - не знаю");

            if (int.TryParse(Console.ReadLine(), out int typeValue)
                && Enum.IsDefined(typeof(PlaneType), typeValue))
            {
                planeType = (PlaneType)typeValue;
            }
            else
            {
                Console.WriteLine("Unlucky");
                planeType = PlaneType.Unknown;
            }
        }
    }
}
