using System.Text;

namespace OOP1_Lab06
{
    // Базовий клас Circle містить поля, властивості 
    // та перевантажені методи CalcArea
    class Circle
    {
        // Приховані поля класу
        private double radius; // радіус
        private double x; // координата х центру
        private double y; // координата y центру
        // Властивість доступу до поля класу "radius"
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        // Властивість доступу до поля класу "x"
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        // Властивість доступу до поля класу "y"
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Конструктор за замовчуванням
        public Circle()
        {
            radius = 0.0d; // ініціалізація радіусу
            x = 0.0d; // ініціалізація координати х
            y = 0.0d; // ініціалізація координати y
            Console.WriteLine("Конструктор за замовчуванням викликано");
        }

        // Конструктор з параметром "радіус"
        public Circle(double radius)
        {
            x = 0.0d; // ініціалізація координати х
            y = 0.0d; // ініціалізація координати y
            Radius = radius;
            Console.WriteLine("Конструктор з параметром 'radius' викликано");
        }

        // Конструктор з параметрами "радіус", "x" та "y"
        public Circle(double radius, double x, double y)
        {
            Radius = radius;
            X = x;
            Y = y;
            Console.WriteLine("Конструктор з параметрами 'radius', 'x', 'y' викликано");
        }

        // Конструктор копіювання
        public Circle(Circle other)
        {
            Radius = other.Radius;
            X = other.X;
            Y = other.Y;
            Console.WriteLine("Конструктор копіювання об'єкта викликано");
        }

        // Деструктор
        ~Circle()
        {
            Console.WriteLine("Деструктор викликано");
        }

        // Віртуальний метод обчислення площі кругу за замовчуванням
        virtual public double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Метод обчислення площі кругу з параметром "радіус"
        public double CalcArea(double newR)
        {
            Radius = newR;
            return Math.PI * Radius * Radius;
        }

        // Метод обчислення площі кругу з параметрами "радіус" та "координати центру"
        public double CalcArea(double newR, double newX, double newY)
        {
            Radius = newR;
            X = newX;
            Y = newY;
            return Math.PI * Radius * Radius;
        }
    }
    // Похідний клас Oval наслідує від Circle
    class Oval : Circle
    {
        // Автореалізовані властивості для довгої та короткої вісей
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }
        // Конструктор за замовчуванням зі зверненням 
        // до унаслідованого конструктору класу Circle
        public Oval() : base()
        {
            MajorAxis = 0.0;
            MinorAxis = 0.0;
            Console.WriteLine("Конструктор за замовчуванням для Oval викликано");
        }

        // Конструктор з параметрами
        public Oval(double majorAxis, double minorAxis) : base()
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
            Console.WriteLine("Конструктор з параметрами 'majorAxis' та 'minorAxis'" +
                              " для Oval викликано");
        }

        // Конструктор з параметрами для центр координат
        public Oval(double majorAxis, double minorAxis, double x, double y) :
                    base(0.0, x, y)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
            Console.WriteLine("Конструктор з параметрами 'majorAxis','minorAxis'" +
                              "'x', 'y' для Oval викликано");
        }
        // Перевизначений метод обчислення площі овалу
        public override double CalcArea()
        {
            return Math.PI * MajorAxis * MinorAxis / 4;
        }
        // Деструктор
        ~Oval()
        {
            Console.WriteLine("Деструктор Oval викликано");
        }
    }

    // Похідний клас Ellipse наслідує від Circle
    class Ellipse : Circle
    {
        // Додаткові поля для довгої та короткої осі
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }
        // Конструктор за замовчуванням
        public Ellipse() : base()
        {
            MajorAxis = 0.0;
            MinorAxis = 0.0;
            Console.WriteLine("Конструктор за замовчуванням для Ellipse викликано");
        }

        // Конструктор з параметрами
        public Ellipse(double majorAxis, double minorAxis) : base()
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
            Console.WriteLine("Конструктор з параметрами 'majorAxis' та 'minorAxis'" +
                              "для Ellipse викликано");
        }

        // Конструктор з параметрами для центр координат
        public Ellipse(double majorAxis, double minorAxis, double x, double y) :
                       base(0.0, x, y)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
            X = x;
            Y = y;
            Console.WriteLine("Конструктор з параметрами 'majorAxis', 'minorAxis'," +
                              " 'x', 'y' для Ellipse викликано");
        }

        // Перевизначений метод обчислення площі еліпсу
        public override double CalcArea()
        {
            return Math.PI * MajorAxis * MinorAxis / 4;
        }
        // Деструктор
        ~Ellipse()
        {
            Console.WriteLine("Деструктор Ellipse викликано");
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

            // створюємо об'єкт класу Circle з параметром "радіус"
            Circle circle2 = new Circle(10);
            area = circle2.CalcArea();
            Console.WriteLine("circle2: площа = {0:f3}, радіус = {1:f3}",
                               area, circle2.Radius);

            // створюємо об'єкт класу Circle з параметрами "радіус", "x" та "y"
            Circle circle3 = new Circle(20, 15, 25);
            area = circle3.CalcArea();
            Console.WriteLine("circle3: площа = {0:f3}, радіус = {1:f3}, " +
                              "X = {2:f3}, Y = {3:f3}",
                              area, circle3.Radius, circle3.X, circle3.Y);

            // створюємо копію об'єкту circle3
            Circle circle4 = new Circle(circle3);
            area = circle4.CalcArea();
            Console.WriteLine("circle4: площа = {0:f3}, радіус = {1:f3}, " +
                              "X = {2:f3}, Y = {3:f3}",
                              area, circle4.Radius, circle4.X, circle4.Y);

            // створюємо об'єкт класу Oval з параметрами
            Oval oval1 = new Oval(10, 5);
            area = oval1.CalcArea();
            Console.WriteLine("oval1: площа = {0:f3}, MajorAxis = {1:f3}, " +
                              "MinorAxis = {2:f3}",
                              area, oval1.MajorAxis, oval1.MinorAxis);

            // створюємо об'єкт класу Ellipse з параметрами
            Ellipse ellipse1 = new Ellipse(8, 4, 10, 15);
            area = ellipse1.CalcArea();
            Console.WriteLine("ellipse1: площа = {0:f3}, MajorAxis = {1:f3}, " +
                              "MinorAxis = {2:f3}, X = {3:f3}, Y = {4:f3}",
                              area, ellipse1.MajorAxis, ellipse1.MinorAxis,
                              ellipse1.X, ellipse1.Y);
            Console.ReadKey();
        }
    }
}
