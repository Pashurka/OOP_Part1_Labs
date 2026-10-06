namespace OOP1_Lab10
{
    internal static class God
    {
        // Статичне поле
        public static string name = "Бог";

        // Статична властивість
        public static string Gender
        {
            get { return "невизначений"; }
        }

        // Статичний метод
        public static void BeGod()
        {
            Console.WriteLine("Бог нас всіх любить!");
        }

    }
}
