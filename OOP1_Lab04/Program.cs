using System.Text;
namespace OOP1_Lab05
{
    // Клас Circle містить поля, властивості та різні типи конструкторів
    class Circle
    {
        // Приватні поля класу
        private double radius;    // радіус кола
        private double x;         // координата x центру кола
        private double y;         // координата y центру кола

        // Властивість для доступу до поля radius
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Властивість для доступу до поля x
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        // Властивість для доступу до поля y
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        // Конструктор за замовчуванням – ініціалізує об'єкт базовими значеннями
        public Circle()
        {
            radius = 0.0;       // встановлюємо радіус у 0
            x = 0.0;            // встановлюємо координату x у 0
            y = 0.0;            // встановлюємо координату y у 0
            Console.WriteLine("Конструктор за замовчуванням викликано");
        }

        // Конструктор з одним параметром – ініціалізує тільки радіус
        public Circle(double radius)
        {
            x = 0.0;           // координати центру за замовчуванням
            y = 0.0;
            Radius = radius;   // використовуємо властивість для встановлення радіуса
            Console.WriteLine("Конструктор з параметром 'radius' викликано");
        }

        // Конструктор з трьома параметрами – повна ініціалізація об'єкта
        public Circle(double radius, double x, double y)
        {
            Radius = radius;   // ініціалізуємо всі поля через властивості
            X = x;
            Y = y;
            Console.WriteLine("Конструктор з параметрами 'radius', 'x', 'y' викликано");
        }

        // Конструктор копіювання – створює копію існуючого об'єкта
        public Circle(Circle other)
        {
            Radius = other.Radius;        // копіюємо значення полів з іншого об'єкта
            X = other.X;
            Y = other.Y;
            Console.WriteLine("Конструктор копіювання об'єкта викликано");
        }

        // Деструктор – викликається при знищенні об'єкта
        ~Circle()
        {
            Console.WriteLine("Деструктор викликано");
        }

        // Метод обчислення площі кола за замовчуванням
        public double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Перевантажений метод обчислення площі з новим радіусом
        public double CalcArea(double newRadius)
        {
            Radius = newRadius;                     // оновлюємо радіус
            return Math.PI * Radius * Radius;       // обчислюємо площу
        }

        // Перевантажений метод обчислення площі з новими координатами та радіусом
        public double CalcArea(double newRadius, double newX, double newY)
        {
            Radius = newRadius;                     // оновлюємо всі поля
            X = newX;
            Y = newY;
            return Math.PI * Radius * Radius;       // обчислюємо площу
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Підтримка української мови в консолі
            Console.OutputEncoding = Encoding.UTF8;

            // Демонстрація роботи конструктора за замовчуванням
            Circle circle1 = new Circle();
            double area = circle1.CalcArea();
            Console.WriteLine("circle1: площа = {0:F3}", area);

            // Демонстрація роботи конструктора з одним параметром
            Circle circle2 = new Circle(10.0);
            area = circle2.CalcArea();
            Console.WriteLine("circle2: площа = {0:F3}, радіус = {1:F3}",
                            area, circle2.Radius);

            // Демонстрація роботи конструктора з трьома параметрами
            Circle circle3 = new Circle(20.0, 15.0, 25.0);
            area = circle3.CalcArea();
            Console.WriteLine("circle3: площа = {0:F3}, радіус = {1:F3}, " +
                "X = {2:F3}, Y = {3:F3}",
                area, circle3.Radius, circle3.X, circle3.Y);

            // Демонстрація роботи конструктора копіювання
            Circle circle4 = new Circle(circle3);
            area = circle4.CalcArea();
            Console.WriteLine("circle4: площа = {0:F3}, радіус = {1:F3}, " +
                "X = {2:F3}, Y = {3:F3}",
                area, circle4.Radius, circle4.X, circle4.Y);
            // Демонстрація роботи деструкторів
            // Встановлюємо посилання на null для ініціювання процесу збирання сміття
            circle1 = null;
            circle2 = null;
            circle3 = null;
            circle4 = null;
            // Примусово викликаємо збирач сміття для демонстрації деструкторів
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Натисніть будь–яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
