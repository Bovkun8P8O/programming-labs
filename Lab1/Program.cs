using Newtonsoft.Json;

while (true)
{
    Console.WriteLine("\nChoose a task to run it (1, 2, 3) or type 0 to exit the program: ");
    try
    {
        if (!int.TryParse(Console.ReadLine(), out int task)) task = -1;
        switch (task)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            case 0:
                return;
            case -1:
            default:
                Console.WriteLine("There is no such task");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.GetType() + ": " + ex.Message);
        continue;
    }
}

void Task1()
{
    //  У колі стоять N людей, пронумерованих від 1 до N. При веденні
    // рахунку по колу викреслюється кожна друга людина, поки не
    // залишиться один. Скласти програму, що моделює процес за
    // допомогою списків.
    try
    {
        int n = 1;
        while (true)
        {
            Console.Write("Enter amount of people in circle: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Enter a positive integer.");
                continue;
            }
            break;
        }
        List<int> circle = new List<int>();
        Console.WriteLine("\nStarting circle:");
        for (int i = 1; i <= n; i++)
        {
            circle.Add(i);
            Console.Write(circle[i - 1] + " ");
        }
        Console.WriteLine();

        bool crossingOutAtZeroSwitch = n % 2 == 1;
        int sizeBeforeNextCrossingOut;

        Console.WriteLine("\nСrossing out \"2nds\" in the circle: ");
        while (circle.Count > 1) 
        {
            for (int i = 0; i < circle.Count - 1; i++)
            {
                if (i != circle.Count)
                {
                    circle.RemoveAt(i + 1); // викреслення "других"
                }
            }
            foreach (int person in circle)
            {
                Console.Write(person + " ");
            }
            Console.WriteLine();
            sizeBeforeNextCrossingOut = circle.Count;
            if (sizeBeforeNextCrossingOut == 1) break;

            // якщо розмір до поточного викреслення був непарним,
            // то елемент [0] змінює статус "перший" на "другий" і навпаки
            // парний розмір залишає статус
            if (crossingOutAtZeroSwitch) circle.RemoveAt(0);            
            if (sizeBeforeNextCrossingOut % 2 == 1) crossingOutAtZeroSwitch = !crossingOutAtZeroSwitch;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.GetType() + ": " + ex.Message);
    }
}

void Task2()
{
    //  Дано список та словник. Створити новий словник, в якому ключами
    // будуть значення списку, а значеннями ключів — елементи
    // словника. Записати у JSON файл.
    try
    {
        //List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list = new List<int> { 1, 2, 2, 3, 4, 5, 5, 6 };
        bool hasDublicates = false;

        // обробка не унікальних значень
        for (int i = 0; i < list.Count; i++)
        {
            if (i != list.LastIndexOf(list[i]))
            {
                Console.WriteLine($"There are dublicates in the given list: {list[i]}.");
                hasDublicates = true;
            }
            while (i != list.LastIndexOf(list[i]))
            {
                list.RemoveAt(list.LastIndexOf(list[i]));
            }
        }
        if (hasDublicates)
        {
            Console.WriteLine("Given list without dublicates: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Dictionary<string, string> dict = new Dictionary<string, string>
        {
            { "1", "one" },
            { "2", "two" },
            { "3", "three" },
            { "4", "four" },
            { "5", "five" },
            { "6", "six" }
        };

        // обробка різної кількості ключей
        if (list.Count != dict.Keys.Count)
        {
            Console.WriteLine($"Key counts are not equal: new: {list.Count}, old: {dict.Keys.Count}.");
            return;
        }

        Dictionary<int, string> newDict = new Dictionary<int, string>();
        for (int i = 0; i < list.Count; i++)
        {
            string newValue = dict.Keys.ElementAt(i) + " " + dict.Values.ElementAt(i);
            newDict.Add(list[i], newValue);
        }
        string json = JsonConvert.SerializeObject(newDict);
        string path = "C:\\1\\newDict.json";
        File.WriteAllText(path, json);
        Console.WriteLine("Json file is here: " + path);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.GetType() + ": " + ex.Message);
    }
}
void Task3()
{
    //  Дано символ С і строкова послідовність A. Якщо A містить єдиний
    // елемент, що закінчується символом C, то вивести цей елемент;
    // якщо необхідних рядків в A немає, то вивести порожній рядок; якщо
    // необхідних рядків більше одного, то вивести рядок «Error».
    // Використовувати try-блок для перехоплення можливого
    // виключення. (1)

    // (1) - First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
    //     (поелементні операції)
    //     - Count, Sum, Average, Max, Min, Aggregate (агрегування);
    //     - Range(генерування послідовностей).
    try
    {
        Console.Write("Enter a symbol: ");
        // .First() - вирішення проблеми збереження десь у пам'яті пустої строки,
        // яка автоматом йшла 1 раз як відповідь до вибору завдання
        char C = Console.ReadLine().First(); 

        List<string> A = ["one", "two", "three", "four"];
        Console.WriteLine("String list: ");
        foreach (string s in A) Console.Write(s + " ");
        Console.WriteLine();

        var endsWithC = A.Where(s => s.EndsWith(C));
        int amount = endsWithC.Count();
        //int i = r.Index;

        if (amount == 0)
        {
            Console.WriteLine("\"empty string\"");
        }
        if (amount == 1)
        {
            Console.WriteLine("\nElement, that ends with {0}: " + endsWithC.First(), C);
        }
        if (amount > 1) Console.WriteLine("Error");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.GetType() + ": " + ex.Message);
    }
}
