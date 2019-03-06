using System;

namespace Incapsulation
{
    class Program
    {
        static void Main()
        {
            var someCat = new Cat("Бегемот");
            Console.WriteLine($"Старое имя кота --> \"{someCat.Name}\"");
            someCat.Name = "Баюн";
            Console.WriteLine($"Новое имя кота --> \"{someCat.Name}\"");
        }
    }
}
