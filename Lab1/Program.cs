using Newtonsoft.Json;

while (true)
{
    Console.Write("\nChoose a task to run it (1, 2, 3) or type 0 to exit the program: ");
    try
    {
        int task = int.Parse(Console.ReadLine());
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
    // может с двумя списками пойдёт

    //  У колі стоять N людей, пронумерованих від 1 до N. При веденні
    // рахунку по колу викреслюється кожна друга людина, поки не
    // залишиться один. Скласти програму, що моделює процес за
    // допомогою списків.



    // 1 2 3 4 5 6 7 8 9 10;
    // 1 2 1 2 1 2 1 2 1  2
    // 
    // 1 3 5 7 9
    // 1 2 1 2 1
    //
    // 
}

void Task2()
{
    //  Дано список та словник. Створити новий словник, в якому ключами
    // будуть значення списку, а значеннями ключів — елементи
    // словника. Записати у JSON файл.

    try
    {
        //List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list = new List<int> { 1, 2, 2, 3, 4, 5, 5, 6};
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

}
