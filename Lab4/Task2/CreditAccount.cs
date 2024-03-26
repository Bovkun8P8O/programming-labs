namespace Lab4_2
{
    internal class CreditAccount(int number, decimal balance, string currency, decimal creditLimit) 
        : Account(number, balance, currency)
    {
        private decimal creditLimit = creditLimit;
        private decimal creditDebt;        
        private int gracePeriod; // пільговий період
        private decimal interestRate; // відсоткова ставка

        internal decimal CreditLimit
        {
            get => creditLimit;
            set => creditLimit = value;
        }
        internal decimal CreditDebt
        {
            get => creditDebt;
            set => creditDebt = value;
        }
        internal int GracePeriod
        {
            get => gracePeriod;
            set => gracePeriod = value;
        }
        internal decimal InterestRate
        {
            get => interestRate;
            set => interestRate = value;
        }
    }
}
