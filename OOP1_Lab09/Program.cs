using System;
using System.Text;

class Dog
{
    public string Name { get; set; }
    public bool IsHappy { get; set; }

    public Dog(string name, bool isHappy)
    {
        Name = name;
        IsHappy = isHappy;
    }
    // Перевизначення оператора true: повертає істину, якщо собака в позитивному стані
    public static bool operator true(Dog dog)
    {
        return dog.IsHappy;
    }
    // Перевизначення оператора false: повертає істину, якщо собака в негативному стані
    public static bool operator false(Dog dog)
    {
        return !dog.IsHappy;
    }
    // Перевизначення оператора &: поєднує двох собак з урахуванням їх емоційного стану
    public static Dog operator &(Dog dog1, Dog dog2)
    {
        bool result = dog1.IsHappy && dog2.IsHappy;
        return new Dog($"Об'єднаний_{dog1.Name}_{dog2.Name}", result);
    }
    // Перевизначення оператора !: створює нову собаку з протилежним емоційним станом
    public static Dog operator !(Dog dog)
    {
        return new Dog($"Не_{dog.Name}", !dog.IsHappy);
    }
    // Перевизначення оператора +: поєднує імена собак
    // і зберігає позитивний стан, якщо принаймні одна в позитивному стані
    public static Dog operator +(Dog dog1, Dog dog2)
    {
        return new Dog($"{dog1.Name}_{dog2.Name}", dog1.IsHappy || dog2.IsHappy);
    }
    // Перевизначення оператора --: створює нову собаку з модифікованим ім'ям
    // та встановлює негативний емоційний стан
    public static Dog operator --(Dog dog)
    {
        return new Dog($"Нещасний_{dog.Name}", false);
    }
}

class Program
{
    static void Main()
    {
        Dog dog1 = new Dog("Бадді", true);
        Dog dog2 = new Dog("Макс", false);
        Console.OutputEncoding = UTF8Encoding.UTF8; // підтримка українських літер

        // Демонстрація перевизначених операторів
        Console.WriteLine($"{dog1.Name} є щасливим: {dog1}");
        Console.WriteLine($"{dog2.Name} є щасливим: {dog2}");

        Dog combinedDog = dog1 & dog2;
        Console.WriteLine($"Об'єднаний пес: {combinedDog.Name} " +
                         $"є щасливим: {combinedDog}");

        Dog notHappyDog = !dog1;
        Console.WriteLine($"Не {dog1.Name}: {notHappyDog.Name} " +
                         $"є щасливим: {notHappyDog}");

        Dog addedDogs = dog1 + dog2;
        Console.WriteLine($"Додані пси: {addedDogs.Name} " +
                         $"є щасливим: {addedDogs}");

        Dog unhappyDog = dog1--;
        Console.WriteLine($"Нещасний {dog1.Name}: {unhappyDog.Name} " +
                         $"є щасливим: {unhappyDog}");
    }
}
