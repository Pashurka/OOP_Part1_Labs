using System.Text;

namespace OOP1_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            // Створення об'єкта класу "Kitten"
            Kitten myKitten = new Kitten("Кошеня", "Аліса", 4);

            // Виклик реалізованого методу "MakeSound"
            myKitten.MakeSound();

            // Виклик успадкованого методу "BePredator"
            Console.Write($"{myKitten.NickName} - нащадок хижаків, тому ...");
            myKitten.BePredator();

            // Звернення до статичного поля
            Console.WriteLine($"Верховна духовна Сутність - це {God.name}.");
            Console.WriteLine($"Його гендер - {God.Gender}.");

            // Виклик статичного методу
            God.BeGod();
        }
    }
}
