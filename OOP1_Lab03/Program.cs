using System; // для доступу до бібліотеки Math
              // клас Circle - містить поля, властивості та перевантажені методи CalcSumm
class Circle
{
    // Приховані поля класу
    private double radius = 0.0d; // радіус
    private double x = 0.0d;    // координата х центру
    private double y = 0.0d;    // координата y центру

    // Властивість доступу до поля класу "radius"
    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
        }
    }
    // Властивість доступу до поля класу "x"
    public double X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
    // Властивість доступу до поля класу "y"
    public double Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }
    // Метод обчислення площі кругу за замовчуванням
    public double CalcArea()
    {
        return 0.0d;
    }
    // Метод обчислення площі кругу з параметром "радіус"
    public double CalcArea(double newR)
    {
        Radius = newR;
        return 2 * Math.PI * Radius * Radius;
    }
    // Метод обчислення площі кругу з параметрами "радіус" та "координати центру"
    public double CalcArea(double newR, double newX, double newY)
    {
        Radius = newR;
        X = newX;
        Y = newY;

        return 2 * Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {

        // /створюємо об'єкт класу Cicrcle
        Circle myCircle = new Circle();

        // виклик базового методу CalcArea()
        double area = myCircle.CalcArea();
        Console.WriteLine("Area = {0:f3}", area);

        // виклик перевантаженого методу CalcArea(newR)
        area = myCircle.CalcArea(10);
        Console.WriteLine("Area = {0:f3}, R = {1:f3}", area, myCircle.Radius);

        // виклик перевантаженого методу CalcArea(newR, newX, newY)
        area = myCircle.CalcArea(20, 15, 25);
        Console.WriteLine("Area = {0:f3}, R = {1:f3}, X = {2:f3}, Y = {3:f3}",
                           area, myCircle.Radius, myCircle.X, myCircle.Y);
    }
}