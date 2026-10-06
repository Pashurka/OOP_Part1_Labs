using System.Text;
namespace OOP1_Lab02
{
    // клас Figure - містить поля та властивості
    class Figure
    {
        // Приховані поля класу
        private string name = "Фігура"; // Назва фігури
        private double area = 0.0; // Площа фігури
        // Властивість для доступу до поля Name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // Властивість для доступу до поля Area
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
    }

    class Program
    {
        // Головна точка входу в програму
        static void Main(string[] args)
        {
            // підтримка українських літер в консолі
            Console.OutputEncoding = Encoding.UTF8;

            // Оголошуємо об'єктну змінну тобто новий об'єкт circle1 класу Figure
            Figure circle1;
            // Виділяємо пам'ять для об'єкта тобто ініціалізуємо його
            circle1 = new Figure();
            // приклад скороченої форми оголошення та ініціалізації об'єкту
            Figure rectangle1 = new Figure();

            circle1.Name = "Коло1"; // звернення до властивості Figure.Name
            circle1.Area = 10.0;    // звернення до властивості Figure.Area

            rectangle1.Name = "Прямокутник1"; // звернення до властивості Figure.Name
            rectangle1.Area = 20.0;           // звернення до властивості Figure.Area

            Console.WriteLine("Фігура 1: назва = {0}, площа = {1}",
                circle1.Name, circle1.Area);
            Console.WriteLine("Фігура 2: назва = {0}, площа = {1}",
                rectangle1.Name, rectangle1.Area);
        }
    }
}
