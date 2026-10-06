namespace OOP1_Lab10
{
    internal abstract class Animal
    {
        // Неабстрактне поле
        private string type = "Тварина";

        // Неабстрактна властивість
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // Абстрактна властивість "прізвисько"
        abstract public string NickName
        { get; set; }

        // Неабстрактний конструктор
        public Animal(string type)
        {
            Type = type;
        }

        // Абстрактний метод
        public abstract void MakeSound();

        // Неабстрактний метод
        public void BePredator()
        {
            Console.WriteLine("Хижаки завжди харчуються м'ясом!");
        }
    }
}
