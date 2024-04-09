namespace Lab5
{
    internal class Engineer(int ID, string Name, int Salary, int Experience, int HolidaysPerYear) : IExecutor
    {
        private int Id = ID;
        private int bossID;
        private string name = Name;
        private string position = "Engineer";
        private double salary = Salary;
        private int experience = Experience;
        private int holidaysPerYear = HolidaysPerYear;

        public int ID
        {
            get => Id;
            set => Id = value;
        }
        public int BossID
        {
            get => bossID;
            set => bossID = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
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

        public void Work()
        {
            Console.WriteLine($"Engineer {ID}: {Name} is working");
        }
        public void Resign()
        {
            Console.WriteLine($"Engineer {ID}: {Name} is resigning");
            ID = 0;
        }
        public void TakeVacation()
        {
            Console.WriteLine($"Engineer {ID}: {Name} is taking vacation");
        }
        public void GainYearOfExperience()
        {
            Experience++;
        }

        public override string ToString()
        {
            return $"ID: {ID}" +
                    $"\nBossID: {BossID}" +
                    $"\nName: {Name}" +
                    $"\nPosition: {Position}" +
                    $"\nSalary: {Salary}" +
                    $"\nExperience (years): {Experience}" +
                    $"\nHolidays per year: {HolidaysPerYear}";
        }
    }
}
