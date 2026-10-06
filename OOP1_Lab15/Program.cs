using System.Text;
// Абстрактний клас, що представляє елемент бібліотеки (книга або журнал)
public abstract class LibraryItem
{
    // Назва елемента бібліотеки
    protected string title;
    // Рік видання елемента
    protected int year;

    // Конструктор для ініціалізації назви та року видання
    public LibraryItem(string title, int year)
    {
        this.title = title;
        this.year = year;
    }

    // Абстрактний метод для обчислення цінності елемента
    public abstract double CalculateValue();

    // Віртуальний метод для отримання опису елемента
    public virtual string GetDescription()
    {
        return $"Назва книжки: {title}, рік видання: {year}";
    }
}

// Клас, що представляє книгу, успадковує LibraryItem
public sealed class Book : LibraryItem
{
    // Автор книги
    private string author;
    // Кількість сторінок у книзі
    private int pages;

    // Конструктор для ініціалізації книги з назвою, роком, автором, сторінками
    public Book(string title, int year, string author, int pages) : base(title, year)
    {
        this.author = author;
        this.pages = pages;
    }

    // Обчислює цінність книги на основі кількості сторінок
    public override double CalculateValue()
    {
        return pages * 10; // Кожна сторінка коштує 10 одиниць
    }

    // Повертає детальний опис книги
    public override string GetDescription()
    {
        return $"Книжка: {title}, автор: {author}, сторінок: {pages}, " +
            $"рік видання: {year}";

    }

    // Перевантаження оператора == для порівняння книг за назвою та автором
    public static bool operator ==(Book b1, Book b2)
    {
        if (ReferenceEquals(b1, null) || ReferenceEquals(b2, null))
            return false;
        return b1.title == b2.title && b1.author == b2.author;
    }
    // Перевантаження оператора != для порівняння книг
    public static bool operator !=(Book b1, Book b2)
    {
        return !(b1 == b2);
    }

    // Деструктор, що виводить повідомлення про видалення книги
    ~Book()
    {
        Console.WriteLine($"Книжка {title} видалена.");
    }
}

// Клас, що представляє журнал, успадковує LibraryItem
public class Magazine : LibraryItem
{
    // Номер випуску журналу
    private int issueNumber;

    // Конструктор для ініціалізації журналу з назвою, роком і номером випуску
    public Magazine(string title, int year, int issueNumber) : base(title, year)
    {
        this.issueNumber = issueNumber;
    }

    // Обчислює цінність журналу залежно від року видання
    public override double CalculateValue()
    {
        return (year >= 2020) ? 100.0 : 50.0; // Нові журнали (з 2020) цінніші
    }

    // Повертає детальний опис журналу
    public override string GetDescription()
    {
        return $"Журнал: {title}, Випуск: {issueNumber}, Рік випуску: {year}";
    }
}

// Статичний клас для управління бібліотечними елементами
public static class LibraryManager
{
    // Лічильник загальної кількості елементів у бібліотеці
    private static int itemCount = 0;

    // Додає елемент до бібліотеки, збільшуючи лічильник
    public static void AddItem()
    {
        itemCount++;
    }

    // Повертає поточну кількість елементів у бібліотеці
    public static int GetItemCount()
    {
        return itemCount;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // підтримка українських літер в консолі
        Console.OutputEncoding = Encoding.UTF8;

        // Створюємо приклади українських книг і журналів
        Book book1 = new Book("Енеїда", 1798, "Іван Котляревський", 150);
        Book book2 = new Book("Лісова пісня", 1911, "Леся Українка", 80);
        Magazine magazine1 = new Magazine("Локальна історія", 2023, 12);
        Magazine magazine2 = new Magazine("Український тиждень", 2018, 45);

        // Додаємо елементи до бібліотеки
        LibraryManager.AddItem();
        LibraryManager.AddItem();
        LibraryManager.AddItem();
        LibraryManager.AddItem();

        // Виводимо описи та цінність елементів
        Console.WriteLine(book1.GetDescription());
        Console.WriteLine($"Цінність: {book1.CalculateValue():F2}");
        Console.WriteLine();

        Console.WriteLine(book2.GetDescription());
        Console.WriteLine($"Цінність: {book2.CalculateValue():F2}");
        Console.WriteLine();

        Console.WriteLine(magazine1.GetDescription());
        Console.WriteLine($"Цінність: {magazine1.CalculateValue():F2}");
        Console.WriteLine();

        Console.WriteLine(magazine2.GetDescription());
        Console.WriteLine($"Цінність: {magazine2.CalculateValue():F2}");
        Console.WriteLine();

        // Перевіряємо кількість елементів у бібліотеці
        Console.WriteLine($"Загальна кількість елементів у бібліотеці: " +
            $"{LibraryManager.GetItemCount()}");


        // Перевіряємо оператори порівняння для книг
        Book book3 = new Book("Енеїда", 1798, "Іван Котляревський", 150);
        Console.WriteLine($"\nПеревірка порівняння книг:");
        Console.WriteLine($"book1 == book3: {book1 == book3}");
        Console.WriteLine($"book1 != book2: {book1 != book2}");
    }
}

