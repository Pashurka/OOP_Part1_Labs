// Базовий клас "Хижак"
using System.Text;

internal class Predator
{
    public string Name
    {
        get;
        set;
    }

    // конструктор класу
    public Predator(string name)
    {
        Name = name;
    }

    // деструктор класу за замовчуванням
    ~Predator()
    {
    }

    // Приватний метод не доступний у похідному класі,
    // доступний лише власним методам
    private void BePredator()
    {
        Console.WriteLine($"Лише {Name} може жити у лісі");
    }

    // Віртуальний метод "Голос"
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} говорить: (зловісна тиша)");
        BePredator();
    }

    // Protected–метод доступний властним методам та у похідному класі
    protected void BeProtect()
    {
        Console.WriteLine($"Демонстрація protected-методу");
    }

}

// Клас "Собака" наслідує базовий клас "Тварина"
internal class Dog : Predator
{
    public Dog(string name) : base(name)
    {
        Console.WriteLine($"{Name} - домашня тварина!");
    }

    ~Dog()
    {
    }

    // Перевизначення методу "Голос" для собаки
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} гавкає: Гав-гав!");
    }

    // Метод, який викликає віртуальний метод базового класу
    public void DoAnimalSound()
    {
        // Виклик віртуального методу базового класу за допомогою "base"
        Console.WriteLine($"{Name} говорить: я нащадок хижаків");
        base.MakeSound();	// демонстрація базового методу
        base.BeProtect();   // демонстрація базового protected-методу
        BeProtect();        // демонстрація унаслідуваного protected-методу
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8; // підтримка укр. літер

        // Створення об'єкта класу "Predator"
        Predator predator = new Predator("Хижак");
        predator.MakeSound();
        // predator.BeProtect(); - заборонено доступ!

        // Створення об'єкта класу "Собака"
        Dog myDog = new Dog("Барсик");

        // Виклик методу "MakeSound" класу "Собака"
        myDog.MakeSound();

        // Виклик методу "DoAnimalSound", який викликає метод класу "MakeSound"
        myDog.DoAnimalSound();

    }
}
