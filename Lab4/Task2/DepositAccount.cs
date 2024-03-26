namespace Lab4_2
{
    internal class SavingsAccount(int number, decimal balance, string currency, double minDepositPerMonth)
        : Account(number, balance, currency)
    {
        private double interestRate;
        private double minDepositPerMonth = minDepositPerMonth;
        private readonly decimal minBalance;
        private int maxWithdrawalsPerMonth;
        private int withdrawalsThisMonth = 0;
        private decimal monthlyMaintenanceFee;

        internal double InterestRate
        {
            get => interestRate;
            set => interestRate = value;
        }
        internal double MinDepositPerMonth
        {
            get => minDepositPerMonth;
            set => minDepositPerMonth = value;
        }
        internal int MaxWithdrawalsPerMonth
        {
            get => maxWithdrawalsPerMonth;
            init => maxWithdrawalsPerMonth = value;
        }
        internal decimal MonthlyMaintenanceFee
        {
            get => monthlyMaintenanceFee;
            init => monthlyMaintenanceFee = value;
        }
        internal decimal MinBalance
        {
            get => minBalance;
            init => minBalance = value;
        }
        internal int WithdrawalsThisMonth
        {
            get => withdrawalsThisMonth;
            set { if (value < maxWithdrawalsPerMonth) withdrawalsThisMonth = value; } // під час зняття грошей робити ++WithdrawalsThisMonth (треба перевірити)
        }
    }
}
