namespace Lab4_2
{
    internal class Account(int number, decimal balance, string currency)
    {
        private int number = number;
        private decimal balance = balance;
        private bool isBlocked = false;
        private string currency = currency;

        internal int Number
        {
            get => number;
            init => number = value;
        }
        internal decimal Balance
        {
            get => balance;
            set => balance = value;
        }
        internal bool IsBlocked 
        { 
            get => isBlocked; 
            set => isBlocked = value; 
        }
        internal string Currency
        {
            get => currency;
            init => currency = value.ToUpper();
        }

        internal void Block()
        {
            isBlocked = true;
        }
        internal void Unblock()
        {
            isBlocked = false;
        }
    }
}
