using Lab5;

/*
 Створити базовий суперклас (абстрактний клас або інтерфейс) і
визначити загальні методи для даного класу. Створити підкласи, в
які додати специфічні властивості та методи. Частину методів
перевизначити.

Розробити програму з використанням абстрактних класів та
інтерфейсів. Чітко розуміти, де доцільно використати суперклас, а
де звичайний.

При розробці використовувати наслідування та поліморфізм

У всіх класах повинні бути реалізовані доцільні для класу методи,
навіть якщо це не вказано у завданні

Використовувати об’єкти підкласів для моделювання реальних
ситуацій та об’єктів
 */
 /*
 1. Створити суперклас Співробітник підкласи Управлінці, Виконавці,
Керівник, Менеджер, Інженер, Механік, Інженер-архітектор.
Подумати, які з вищенаведених підкласів також можуть бути
суперкласами. За допомогою конструктора задати кількість досвіду
співробітника в роках. Вивести зарплату кожного співробітника та
кількість вихідних в році у інженерів. Реалізувати функцію
підрахунку кількості підлеглих у менеджера.
 */
const int managersHolidays = 28;
const int executorsHolidays = 24;
List<IEmployee> employees = new();
Director director = new Director(100, "Pedro", 10, 1, managersHolidays);
employees.Add(director);

List<Manager> managers = new();
managers.Add(new Manager(200, "Juan", 8, 1, managersHolidays));
managers.Add(new Manager(200 + managers.Count, "Maria", 9, 1, managersHolidays));
Manager mechManager = managers.Find(m => m.ID == 200);
Manager engManager = managers.Find(m => m.ID == 201);
for (int i = 0; i < managers.Count; i++)
{
    employees.Add(managers[i]);
}

List<Mechanic> mechanics = new();
mechanics.Add(new Mechanic(500 + mechanics.Count, "Pablo", 1, 1, executorsHolidays));
mechanics.Add(new Mechanic(500 + mechanics.Count, "Luis", 2, 1, executorsHolidays));
mechanics.Add(new Mechanic(500 + mechanics.Count, "Jose", 3, 1, executorsHolidays));
for (int i = 0; i < mechanics.Count; i++)
{
    employees.Add(mechanics[i]);
}

List<Engineer> engineers = new();
engineers.Add(new Engineer(300 + engineers.Count, "Luisa", 5, 1, executorsHolidays));
engineers.Add(new Engineer(300 + engineers.Count, "Franco", 6, 1, executorsHolidays));
engineers.Add(new ArchitectEngineer(300 + engineers.Count, "Ana", 7, 1, executorsHolidays));
engineers.Add(new ArchitectEngineer(300 + engineers.Count, "Lola", 8, 1, executorsHolidays));
for (int i = 0; i < engineers.Count; i++)
{
    employees.Add(engineers[i]);
}

Console.WriteLine(director.ToString());
Console.WriteLine();
Console.WriteLine(mechManager.ToString());
Console.WriteLine();
Console.WriteLine(engManager.ToString());
Console.WriteLine();
foreach (Manager manager in managers)
{
    director.AddSubordinate(manager);
}
director.GainYearOfExperience();
foreach (Mechanic mechanic in mechanics)
{
    mechManager.AddSubordinate(mechanic);
}
foreach (Engineer engineer in engineers)
{
    engManager.AddSubordinate(engineer);
}
Console.WriteLine();
Console.WriteLine("Salaries of all employees:");
for (int i = 0; i < employees.Count; i++)
{
    Console.WriteLine($"{employees[i].ID}: {employees[i].Name} - {employees[i].Position} - {employees[i].Salary}");
}
Console.WriteLine();
int holidays = employees.Find(e => e.Position.Contains("Engineer")).HolidaysPerYear;
Console.WriteLine($"Engineers have {holidays} holidays per year");
Console.WriteLine();
Console.WriteLine($"Director {director.ID}: {director.Name} has {director.SubordinatesAmount()} subordinates");
Console.WriteLine(); 
Console.WriteLine($"Manager {mechManager.ID}: {mechManager.Name} has {mechManager.SubordinatesAmount()} subordinates");
Console.WriteLine();
Console.WriteLine($"Manager {engManager.ID}: {engManager.Name} has {engManager.SubordinatesAmount()} subordinates");
Console.WriteLine();
Console.WriteLine(director.ToString());
Console.WriteLine();
Console.WriteLine(mechManager.ToString());
Console.WriteLine();
Console.WriteLine(engManager.ToString());
Console.WriteLine();
