// Завдання 1
// Створити додаток, який задовольняє вимогам, наведеним в завданні.
// Наслідування застосовувати тільки в тих завданнях, в яких воно логічно обґрунтоване.
// Аргументувати належність класу кожного створюваного методу і
// коректно перевизначити для кожного класу методи Equals, GetHashCode, ToString.
// При виклику будь-якого методу класу, виводити на екран текстове повідомлення. 

// 1.Створити об'єкт класу Автомобіль, використовуючи класи Колесо, Двигун.
// Методи: їхати, заправлятися, заміняти колесо, вивести на консоль марку автомобіля. 

namespace Lab4
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Enter 1 or 2 to launch Task 1 or Task 2 (or 0 to exit the program): ");
                if (int.TryParse(Console.ReadLine(), out int num) && num == 1)
                {
                    Car bmwX6 = new Car("BMW", "X6", Wheel.WheelType.Summer);
                    bmwX6.PrintCarBrand();
                    bmwX6.Refuel();
                    bmwX6.Drive();
                    Car bmwX62 = new Car("BMW", "X6", Wheel.WheelType.Summer);
                    bmwX62.PrintCarBrand();
                    Console.WriteLine($"bmwX6.Equals(bmwX62): {bmwX6.Equals(bmwX62)}");
                    Console.WriteLine("bmwX6 hash code:" + bmwX6.GetHashCode());
                    Console.WriteLine("bmwX62 hash code:" + bmwX62.GetHashCode());
                    bmwX6.ReplaceWheel(0, Wheel.WheelType.AllSeason);
                    bmwX6.ReplaceWheel(Wheel.WheelPosition.RearLeft, Wheel.WheelType.Winter);
                    Console.WriteLine(bmwX6.ToString());
                    Console.WriteLine(bmwX62.ToString());
                }
                if (num == 2)
                {

                }
                if (num == 0) break;
                else Console.WriteLine("Invalid input.");
            }
        }        
    }
}