using System;

class pizzeria
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== Ласкаво просимо до Pizza Service ===\n");
        Console.ResetColor();

        Console.WriteLine("🍕 Маргарита – 150 грн/шт");
        Console.WriteLine("🍕 Пепероні – 180 грн/шт");
        Console.WriteLine("🍕 Гавайська – 170 грн/шт");
        Console.WriteLine("🥤 Напій – 40 грн/шт");
        Console.WriteLine("🍟 Картопля фрі – 60 грн/порція");
        Console.WriteLine("🧂 Соус – 25 грн/шт\n");

        double priceMargarita = 150;
        double pricePeperoni = 180;
        double priceHawaiian = 170;
        double priceDrink = 40;
        double priceFries = 60;
        double priceSauce = 25;

        Console.Write("Введіть кількість піци Маргарита: ");
        double margarita = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість піци Пепероні: ");
        double peperoni = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість піци Гавайська: ");
        double hawaiian = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість напоїв: ");
        double drink = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість порцій картоплі фрі: ");
        double fries = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість соусів: ");
        double sauce = Convert.ToDouble(Console.ReadLine());

        double total = margarita * priceMargarita +
                       peperoni * pricePeperoni +
                       hawaiian * priceHawaiian +
                       drink * priceDrink +
                       fries * priceFries +
                       sauce * priceSauce;

        Random rand = new Random();
        double discount = rand.Next(5, 16); // від 5% до 15%
        double discountSum = total * (discount / 100);
        double totalWithDiscount = total - discountSum;

        Console.WriteLine("\n===============================");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Загальна сума: {total:F2} грн");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Знижка: {discount:F2}%");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Сума зі знижкою: {totalWithDiscount:F2} грн");
        Console.ResetColor();
        Console.WriteLine("===============================");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nДякуємо за замовлення у Pizza Service!");
        Console.ResetColor();
    }
}
