using System.Collections.Generic;
using System.Text;

// Перший батьківський клас: Домашня тварина
public class Pet
{
    protected string name; // Ім'я тварини
    protected int age;     // Вік тварини
    protected string color; // Колір тварини

    // Конструктор
    public Pet(string name, int age, string color)
    {
        this.name = name;
        this.age = age;
        this.color = color;
        Console.WriteLine($"{name} (Домашня тварина) створено.");
    }

    // Деструктор
    ~Pet()
    {
        Console.WriteLine($"{name} (Домашня тарина) знищено.");
    }

    // Властивості
    public string Name => name;
    public int Age => age;
    public string Color => color;

    // Віртуальний метод для звуку
    public virtual void MakeSound()
    {
        Console.WriteLine($"{name} видає якийсь звук.");
    }

    // Віртуальний метод для інформації
    public virtual string GetInfo()
    {
        return $"Ім'я: {name}, Вік: {age}, Колір: {color}";
    }

    // Віртуальний метод для гри
    public virtual void Play()
    {
        Console.WriteLine($"{name} грається звичайним чином.");
    }

    // Звичайний метод для сну
    public void Sleep()
    {
        Console.WriteLine($"{name} спить...");
    }
}
// Другий батьківський клас: Робоча Тварина
public class WorkerAnimal
{
    protected string name;   // Ім'я тварини
    protected string role;   // Роль тварини
    protected int strength;  // Сила тварини
    // Конструктор
    public WorkerAnimal(string name, string role, int strength)
    {
        this.name = name;
        this.role = role;
        this.strength = strength;
        Console.WriteLine($"{name} (Робоча тварина) створено.");
    }

    // Деструктор
    ~WorkerAnimal()
    {
        Console.WriteLine($"{name} (Робоча тварина) знищено.");
    }

    // Властивості
    public string Name => name;
    public string Role => role;
    public int Strength => strength;

    // Віртуальний метод для роботи
    public virtual void DoWork()
    {
        Console.WriteLine($"{name} виконує завдання {role}.");
    }

    // Віртуальний метод для інформації
    public virtual string GetInfo()
    {
        return $"Ім'я: {name}, Роль: {role}, Сила: {strength}";
    }
}

// Похідний клас 1 від Тварина: Собака
public class Dog : Pet
{
    private string breed; // Приховане поле: порода

    // Конструктор
    public Dog(string name, int age, string color, string breed)
        : base(name, age, color)
    {
        this.breed = breed;
        Console.WriteLine($"{name} (Собака) створено.");
    }

    // Деструктор
    ~Dog()
    {
        Console.WriteLine($"{name} (Собака) знищено.");
    }

    // Перевизначення віртуального методу
    public override void MakeSound()
    {
        Console.WriteLine($"{name} каже: Гав! Гав!");
    }

    // Перевизначення віртуального методу
    public override string GetInfo()
    {
        return base.GetInfo() + $", Порода: {breed}";
    }

    // Перевизначення методу гри
    public override void Play()
    {
        Console.WriteLine($"{name} грається в приношення м'яча!");
    }
    // Унікальний метод
    public void Guard()
    {
        Console.WriteLine($"{name} охороняє будинок!");
    }

    // Властивість для породи
    public string Breed => breed;

    // Приховування методу
    public new void Sleep()
    {
        Console.WriteLine($"{name} собака спить у своїй будці.");
    }

}
// Похідний клас 2 від Тварина: Кіт
public class Cat : Pet
{
    private bool isIndoor; // Приховане поле: чи живе в приміщенні

    // Конструктор
    public Cat(string name, int age, string color, bool isIndoor)
        : base(name, age, color)
    {
        this.isIndoor = isIndoor;
        Console.WriteLine($"{name} (Кіт) створено.");
    }

    // Деструктор
    ~Cat()
    {
        Console.WriteLine($"{name} (Кіт) знищено.");
    }

    // Перевизначення віртуального методу
    public override void MakeSound()
    {
        Console.WriteLine($"{name} каже: Няв! Няв!");
    }

    // Перевизначення віртуального методу
    public override string GetInfo()
    {
        return base.GetInfo() + $", У приміщенні: {(isIndoor ? "Так" : "Ні")}";
    }

    // Перевизначення методу гри
    public override void Play()
    {
        Console.WriteLine($"{name} грається з клубком пряжі!");
    }

    // Унікальний метод
    public void Hunt()
    {
        Console.WriteLine($"{name} полює на мишей!");
    }

    // Властивість для isIndoor
    public bool IsIndoor => isIndoor;

    // Приховування методу
    public new void Sleep()
    {
        Console.WriteLine($"{name} кіт спить на подушці.");
    }
}

// Похідний клас 1 від Робоча Тварина: Кінь
public class Horse : WorkerAnimal
{
    private double speed; // Приховане поле: швидкість

    // Конструктор
    public Horse(string name, string role, int strength, double speed)
        : base(name, role, strength)
    {
        this.speed = speed;
        Console.WriteLine($"{name} (Кінь) створено.");
    }
    // Деструктор
    ~Horse()
    {
        Console.WriteLine($"{name} (Кінь) знищено.");
    }
    // Перевизначення віртуального методу
    public override void DoWork()
    {
        Console.WriteLine($"{name} тягне віз зі швидкістю {speed} км/год.");
    }
    // Перевизначення віртуального методу
    public override string GetInfo()
    {
        return base.GetInfo() + $", Швидкість: {speed} км/год";
    }
    // Унікальний метод
    public void Gallop()
    {
        Console.WriteLine($"{name} галопує полем!");
    }
    // Властивість для швидкості
    public double Speed => speed;
    // Приховування властивості
    public new string Role => $"спеціалізована роль: {role}";
}

// Похідний клас 2 від Робоча Тварина: Віслюк
public class Donkey : WorkerAnimal
{
    private int loadCapacity; // Приховане поле: вантажопідйомність
    // Конструктор
    public Donkey(string name, string role, int strength, int loadCapacity)
        : base(name, role, strength)
    {
        this.loadCapacity = loadCapacity;
        Console.WriteLine($"{name} (Віслюк) створено.");
    }
    // Деструктор
    ~Donkey()
    {
        Console.WriteLine($"{name} (Віслюк) знищено.");
    }
    // Перевизначення віртуального методу
    public override void DoWork()
    {
        Console.WriteLine($"{name} несе вантаж вагою {loadCapacity} кг.");
    }
    // Перевизначення віртуального методу
    public override string GetInfo()
    {
        return base.GetInfo() + $", Вантажопідйомність: {loadCapacity} кг";
    }
    // Унікальний метод
    public void StubbornStop()
    {
        Console.WriteLine($"{name} вперто зупиняється і відмовляється рухатися!");
    }
    // Властивість для вантажопідйомності
    public int LoadCapacity => loadCapacity;

    // Приховування властивості
    public new string Role => $"спеціалізована роль: {role}";
}
// Клас для управління тваринами
public class PetManager
{
    private List<object> animals; // Список для зберігання всіх тварин

    // Конструктор
    public PetManager()
    {
        animals = new List<object>();
        Console.WriteLine("Менеджер тварин створено.");
    }

    // Деструктор
    ~PetManager()
    {
        Console.WriteLine("Менеджер тварин знищено.");
    }

    // Додавання тварини
    public void AddAnimal(object animal)
    {
        animals.Add(animal);
        string name = animal is Pet pet ? pet.Name : ((WorkerAnimal)animal).Name;
        Console.WriteLine($"Додано тварину: {name}");
    }

    // Показати інформацію про всіх тварин
    public void ShowAllInfo()
    {
        Console.WriteLine("\n Усі Тварини ");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal is Pet pet ? pet.GetInfo() :
                              ((WorkerAnimal)animal).GetInfo());
        }
    }

    // Виконати звуки всіх тварин (тільки для Pet)
    public void MakeAllSounds()
    {
        Console.WriteLine("\n Звуки Тварин ");
        foreach (var animal in animals)
        {
            if (animal is Pet pet)
            {
                pet.MakeSound();
            }
        }
    }

    // Виконати роботу всіх робочих тварин
    public void DoAllWork()
    {
        Console.WriteLine("\n Робочі Дії ");
        foreach (var animal in animals)
        {
            if (animal is WorkerAnimal worker)
            {
                worker.DoWork();
            }
        }
    }
    // Грати з усіма тваринами (тільки для Pet)
    public void PlayWithAll()
    {
        Console.WriteLine("\n Час Гри ");
        foreach (var animal in animals)
        {
            if (animal is Pet pet)
            {
                pet.Play();
            }
        }
    }

    // Кількість тварин
    public int AnimalCount => animals.Count;
}
// Демонстрація роботи
public class Program
{
    public static void Main()
    {
        // підтримка українських літер в консолі
        Console.OutputEncoding = Encoding.UTF8;

        // Створення менеджера
        var manager = new PetManager();
        // Створення тварин
        var dog = new Dog("Рекс", 3, "Коричневий", "Золотистий Ретривер");
        var cat = new Cat("Мурзик", 2, "Сірий", true);
        var horse = new Horse("Гром", "Транспорт", 80, 40.5);
        var donkey = new Donkey("Мирко", "Вантажник", 60, 200);

        // Додавання тварин
        manager.AddAnimal(dog);
        manager.AddAnimal(cat);
        manager.AddAnimal(horse);
        manager.AddAnimal(donkey);

        // Показати інформацію
        manager.ShowAllInfo();
        // Виконати звуки (тільки для Pet)
        manager.MakeAllSounds();
        // Виконати роботу (тільки для WorkerAnimal)
        manager.DoAllWork();
        // Грати з тваринами
        manager.PlayWithAll();
        // Унікальні дії
        Console.WriteLine("\n Спеціальні Дії ");
        dog.Guard();
        cat.Hunt();
        horse.Gallop();
        donkey.StubbornStop();

        // Демонстрація приховування методів і властивостей
        Console.WriteLine("\n Приховані Методи та Властивості ");
        dog.Sleep(); // Викликає Sleep собаки
        cat.Sleep(); // Викликає Sleep кота
        ((Pet)dog).Sleep(); // Викликає Sleep батьківського класу
        ((Pet)cat).Sleep(); // Викликає Sleep батьківського класу
        Console.WriteLine($"Кінь, {horse.Role}"); // Викликає Role коня
        Console.WriteLine($"Віслюк, {donkey.Role}"); // Викликає Role віслюка

        // Загальна кількість тварин
        Console.WriteLine($"\nЗагальна кількість тварин: {manager.AnimalCount}");

        // Виклик збору сміття для демонстрації деструкторів
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

