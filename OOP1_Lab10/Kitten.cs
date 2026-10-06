namespace OOP1_Lab10
{
    internal sealed class Kitten : Animal
    {
        // Власне поле - кількість лап
        public int numOfPaws;

        // Власне поле - прізвисько
        public string nickName = "кіт";

        // Реалізація базової абстрактної властивості
        public override string NickName
        {
            get { return nickName; }
            set
            {
                // Контроль коректності значення
                if (value == "Васька" || value == "Аліса")
                {
                    nickName = "Барсік";
                }
                else
                {
                    nickName = value;
                }
            }
        }

        // Конструктор класу Kitten
        public Kitten(string type, string nickname, int numofpaws)
            : base(type)
        {
            numOfPaws = numofpaws;
            NickName = nickname;
            Console.WriteLine($"{NickName} - це маленьке {type}, " +
                             $"у нього {numOfPaws} лапи та немає нащадків!");
        }

        // Реалізація абстрактного методу "MakeSound"
        public override void MakeSound()
        {
            Console.WriteLine($"{NickName} муркоче: Мяу-мяу!");
        }
    }
}
