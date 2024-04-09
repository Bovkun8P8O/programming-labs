namespace Lab5
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        string Position { get; init; }
        double Salary { get; set; }
        int Experience { get; set; }
        int HolidaysPerYear { get; set; }
        void Work();
        void Resign();
        void TakeVacation();
        void GainYearOfExperience();
    }
}
