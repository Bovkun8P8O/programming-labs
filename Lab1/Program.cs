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
    //  У колі стоять N людей, пронумерованих від 1 до N. При веденні
    // рахунку по колу викреслюється кожна друга людина, поки не
    // залишиться один. Скласти програму, що моделює процес за
    // допомогою списків
    try
    {
        Console.Write("Enter amount of people in circle: ");
        int n = int.Parse(Console.ReadLine());
        List<int> circle = new List<int>();
        Console.WriteLine("\nStarting circle:");
        for (int i = 1; i <= n; i++)
        {
            circle.Add(i);
            Console.Write(circle[i - 1] + " ");
        }
        Console.WriteLine();

        // у залежності від минулої кількості людей у колі видаляти чи і + 1, чи і.

        Console.WriteLine("\nСrossing out \"2nds\" in the circle: ");
        bool isSecondCrossing = false;
        while (circle.Count > 1) // поки не залишиться один
        {
            // якщо початкова кількість непарна, то далі,
            // йдучи по колу, перший елемент буде завжди "другим"
            if (n % 2 == 1 && isSecondCrossing) { circle.RemoveAt(0); } 
            for (int i = 0; i < circle.Count - 1; i++)
            {
                if (i != circle.Count) // якщо не останній (видаляється наступний)
                {
                    circle.RemoveAt(i + 1);
                }
            }
            foreach (int person in circle)
            {
                Console.Write(person + " ");
            }
            Console.WriteLine();
            isSecondCrossing = true;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.GetType() + ": " + ex.Message);
    }
}

void Task2()
{

}
void Task3()
{

}
