namespace Lab5
{
    internal class ArchitectEngineer : Engineer
    {
        public ArchitectEngineer(int ID, string Name, int Salary, int Experience, int HolidaysPerYear) : base(ID, Name, Salary, Experience, HolidaysPerYear)
        {
            Position = "Architect Engineer";
        }
        public new void Work()
        {
            Console.WriteLine($"Architect Engineer {ID}: {Name} is working");
        }
        public new void Resign()
        {
            Console.WriteLine($"Architect Engineer {ID}: {Name} is resigning");
            ID = 0;
        }
        public new void TakeVacation()
        {
            Console.WriteLine($"Architect Engineer {ID}: {Name} is taking vacation");
        }
    }
}
