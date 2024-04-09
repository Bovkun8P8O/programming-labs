namespace Lab5
{
    internal class Director(int ID, string Name, double Salary, int Experience, int HolidaysPerYear) : IManager
    {
        private int Id = ID;
        private string name = Name;
        private string position = "Director";
        private double salary = Salary;
        private int experience = Experience;
        private int holidaysPerYear = HolidaysPerYear;
        private List<IExecutor> subordinates = new();

        public int ID
        {
            get => Id;
            set => Id = value;
        }
        public string Name
        {
            get => name;
            set => name = "Mr./Mrs. " + value;
        }
        public string Position
        {
            get => position;
            init => position = value;
        }
        public double Salary
        {
            get => salary;
            set => salary = value;
        }
        public int Experience
        {
            get => experience;
            set => experience = value;
        }
        public int HolidaysPerYear
        {
            get => holidaysPerYear;
            set => holidaysPerYear = value;
        }
        public List<IExecutor> Subordinates { get; }

        public void Work()
        {
            Console.WriteLine($"Director {Name} ({ID}) is working");
        }
        public void Resign()
        {
            Console.WriteLine($"Director {Name} ({ID}) is resigning");
            ID = 0; // ID = 0 => видалити
        }
        public void TakeVacation()
        {
            Console.WriteLine($"Director {Name} ({ID}) is taking a vacation");
        }
        public void GainYearOfExperience()
        {
            Experience++;
        }

        public void AddSubordinate(IExecutor executor)
        {
            if (executor is Manager)
            {
                subordinates.Add(executor);
                Console.WriteLine($"Director {ID}: {Name} added subordinate {executor.ID}: {executor.Name}");
                executor.BossID = ID;
                return;
            }
            Console.WriteLine($"Director cannot add {executor.Position} as a subordinate");
        }
        public void RemoveSubordinate(IExecutor executor)
        {
            subordinates.Remove(executor);
            Console.WriteLine($"Director {ID}: {Name} removed subordinate {executor.ID}: {executor.Name}");
        }
        public void Dismiss(IExecutor executor)
        {
            Console.WriteLine($"Director {ID}: {Name} is dismissing {executor.ID}: {executor.Name}");

            subordinates.Remove(executor);
            executor.ID = 0;
        }
        public int SubordinatesAmount() => subordinates.Count;


        public override string ToString()
        {
            string subordinatesList = "";
            if (subordinates.Count == 0)
                subordinatesList = "None";
            else
            {
                foreach (IExecutor executor in subordinates)
                    subordinatesList += $"\n{executor.ID}: {executor.Name} - {executor.Position}";
            }
            return $"ID: {ID}" +
                    $"\nName: {Name}" +
                    $"\nPosition: {Position}" +
                    $"\nSalary: {Salary}" +
                    $"\nExperience (years): {Experience}" +
                    $"\nHolidays per year: {HolidaysPerYear}" +
                    $"\nSubordinates: {subordinatesList}";
        }
    }
}
