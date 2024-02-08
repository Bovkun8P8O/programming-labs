while (true)
{
    Console.Write("Choose task to run it (1, 2, 3) or type 0 to exit the program: ");
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
    try
    {
        Console.Write("Enter amount of people in circle: ");
        int n = int.Parse(Console.ReadLine());
        List<int> circle = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            circle.Add(i);
            Console.Write(circle[i - 1] + " ");
        }
        Console.WriteLine();

        while (circle.Count > 1)
        {
            for (int i = 0; i < circle.Count - 1; i++)
            {
                if (i != circle.Count)
                {
                    circle.RemoveAt(i + 1);
                }
            }
            foreach (int person in circle)
            {
                Console.Write(person + " ");
            }
            Console.WriteLine();
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
