namespace Lab5
{
    internal interface IManager : IEmployee
    {
        List<IExecutor> Subordinates { get; }
        void Dismiss(IExecutor executor);
        void AddSubordinate(IExecutor executor); 
        void RemoveSubordinate(IExecutor executor);
        int SubordinatesAmount();
    }
}
