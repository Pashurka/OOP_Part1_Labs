using System.Text;
namespace OOP1_Lab07
{
    // базовий клас Circle
    class Circle
    {
        // публічне поле – тип фігури
        public readonly string type = "circle";
        // Автореалізовані властивості
        public double Radius { get; set; } // радіус
        public double X { get; set; } // координата х центру
        public double Y { get; set; } // координата y центру

        // Конструктор за замовчуванням
        public Circle()
        {
            Radius = 0.0d; // ініціалізація радіусу
            X = 0.0d; // ініціалізація координати х
            Y = 0.0d; // ініціалізація координати y
            Console.WriteLine("Конструктор за замовчуванням викликано");
        }

        // Конструктор зі всіма параметрами
        public Circle(double radius, double x, double y)
        {
            Radius = radius;
            X = x;
            Y = y;
            Console.WriteLine("Конструктор з параметрами 'radius', " +
                            "'x', 'y' викликано");
        }
        // Деструктор
        ~Circle()
        {
            Console.WriteLine("Деструктор викликано");
        }
        // Метод обчислення площі кругу
        public double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Sector : Circle
    {
        // приховування публічного поля
        public new readonly string type = "sector";

        // Нова автореалізована властивість, величина кута сектора в градусах
        public double Angle { get; set; }

        // Конструктор за замовчуванням
        public Sector() : base()
        {
            Angle = 0.0;
            Console.WriteLine("Конструктор за замовчуванням для " +
                            "Sector викликано");
        }

        // Конструктор зі всіма параметрами
        public Sector(double radius, double angle, double x, double y)
            : base(radius, x, y)
        {
            Angle = angle;
            Console.WriteLine("Конструктор з параметрами 'radius', 'angle', " +
                            "'x', 'y' для Sector викликано");
        }

        // Приховування методу обчислення площі сектора
        public new double CalcArea()
        {
            return base.CalcArea() * (Angle / 360.0);
        }

        // Деструктор
        ~Sector()
        {
            // необхідно переконатися, що це повідомлення ми не побачимо
            Console.WriteLine("Деструктор викликано");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // підтримка українських літер
            Console.OutputEncoding = Encoding.UTF8;

            // створюємо об'єкт класу Circle за замовчуванням
            Circle circle1 = new Circle();
            double area = circle1.CalcArea();
            Console.WriteLine("circle1: площа = {0:f3}", area);

            // створюємо об'єкт класу Circle з параметрами
            Circle circle2 = new Circle(20, 15, 25);
            Console.WriteLine("circle2: площа = {0:f3}, радіус = {1:f3}, " +
                            "X = {2:f3}, Y = {3:f3}, тип = {4}", circle2.CalcArea(),
                            circle2.Radius, circle2.X, circle2.Y, circle2.type);

            // створюємо об'єкт класу Sector з параметрами
            Sector sector1 = new Sector(20, 90, 100, 200);
            Console.WriteLine("sector1: площа = {0:f3}, радіус = {1:f3}, " +
                            "кут = {2:f3}, тип = {3}", sector1.CalcArea(),
                            sector1.Radius, sector1.Angle, sector1.type);
        }
    }
}
