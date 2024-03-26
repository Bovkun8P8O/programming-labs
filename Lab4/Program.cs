using Lab4;
using Lab4_2;

internal class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.Write("Enter 1 or 2 to launch Task 1 or Task 2 (or 0 to exit the program): ");
            if (int.TryParse(Console.ReadLine(), out int num) && num == 1)
            {
                // Завдання 1
                // Створити додаток, який задовольняє вимогам, наведеним в завданні.
                // Наслідування застосовувати тільки в тих завданнях, в яких воно логічно обґрунтоване.
                // Аргументувати належність класу кожного створюваного методу і
                // коректно перевизначити для кожного класу методи Equals, GetHashCode, ToString.
                // При виклику будь-якого методу класу, виводити на екран текстове повідомлення. 

                // 1.Створити об'єкт класу Автомобіль, використовуючи класи Колесо, Двигун.
                // Методи: їхати, заправлятися, заміняти колесо, вивести на консоль марку автомобіля. 

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
                // Завдання 2
                // Створити програму, яка задовольняє наступним вимогам:
                // • Використовувати можливості ООП: класи, наслідування, поліморфізм, інкапсуляція.
                // • Кожен клас повинен мати змістовну назву та інформативний склад.
                // • Наслідування має застосовуватися тільки тоді, коли це має сенс.
                // • Класи повинні бути грамотно та логічно розкладені по пакетах (папках).
                // • Консольне меню повинно бути мінімальним.

                // 1. Рахунки. Клієнт може мати кілька рахунків у банку.
                // Враховувати можливість блокування / розблокування рахунку.
                // Реалізувати пошук і сортування рахунків.
                // Обчислення загальної суми по рахунках.
                // Обчислення суми по всіх рахунках, мають позитивний і негативний баланси окремо.

                while (true)
                {
                    try
                    {
                        Client client = new();
                        client.AddAccount(1, 1000, "USD");
                        client.AddAccount(2, -50, "USD", 3000.0m);
                        client.AddAccount(3, 500, "USD", 100.0);
                        client.AddAccount(4, -100, "USD");

                        Console.WriteLine("\n Enter a number to choose an action:" +
                            "\n 0 - Exit the program." +
                            "\n 1 - Find account." +
                            "\n 2 - Sort accounts." +
                            "\n 3 - Block / unblock account." +
                            "\n 4 - Calculate balance sums." +
                            "\n 5 - See all accounts (IDs, types and balances)" +
                            "\n ");
                        Console.Write(" ");
                        if (!int.TryParse(Console.ReadLine(), out int action)) action = -1;
                        if (action == 0) break;
                        switch (action)
                        {
                            case 1:
                                Console.Write("Enter the number of the account: ");
                                int number = int.Parse(Console.ReadLine());
                                Account account = client.FindAccount(number);
                                if (account != null)
                                {
                                    Console.WriteLine("Account found: " + account.Number + "-" + account.GetType().Name + "-" + account.Balance + "-" + account.Currency);
                                }
                                else
                                {
                                    Console.WriteLine("Account not found.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Sorted by balances:");
                                client.SortPerBalance();
                                Console.WriteLine(client.ToString());
                                Console.WriteLine("Sorted by balances (descending):");
                                client.SortPerBalanceDescending();
                                Console.WriteLine(client.ToString());
                                Console.WriteLine("Sorted by numbers:");
                                client.SortPerNumber();
                                Console.WriteLine(client.ToString());
                                Console.WriteLine("Sorted by numbers (descending):");
                                client.SortPerNumberDescending();
                                Console.WriteLine(client.ToString());
                                break;
                            case 3:
                                client.BlockAccount(1);
                                client.UnblockAccount(1);
                                break;
                            case 4:
                                Console.WriteLine("Total balance: " + client.TotalBalance());
                                Console.WriteLine("Total positive balance: " + client.TotalPositiveBalance());
                                Console.WriteLine("Total negative balance: " + (client.TotalBalance() - client.TotalPositiveBalance()));
                                break;
                            case 5:
                                Console.WriteLine(client.ToString());
                                break;
                            case -1:
                            default:
                                Console.WriteLine("There is no such action.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.GetType() + ex.Message);
                        continue;
                    }
                }
            }
            if (num == 0) break;
            else Console.WriteLine("Invalid input (also it may be an \"enter problem\").");
        }
    }
}