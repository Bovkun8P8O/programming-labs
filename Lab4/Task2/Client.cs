namespace Lab4_2
{
    internal class Client
    {
        private List<Account> accounts;
                
        internal Client()
        {
            accounts = new();
        }
        
        internal void AddAccount(int number, decimal balance, string currency) 
        {
            accounts.Add(new Account(number, balance, currency));
        }
        internal void AddAccount(int number, decimal balance, string currency, decimal creditLimit)
        {
            accounts.Add(new CreditAccount(number, balance, currency, creditLimit));
        }
        internal void AddAccount(int number, decimal balance, string currency, double minDepositPerMonth)
        {
            accounts.Add(new SavingsAccount(number, balance, currency, minDepositPerMonth));
        }
        internal void RemoveAccount(int number)
        {
            accounts.Remove(FindAccount(number));
        }
        internal void RemoveAccountAt(int index)
        {
            accounts.RemoveAt(index);
        }
        internal void RemoveAllAccounts()
        {
            accounts.Clear();
        }

        internal void BlockAccount(int number)
        {
            FindAccount(number).Block();
            Console.WriteLine($"Account {number} blocked.");
        }
        internal void UnblockAccount(int number)
        {
            FindAccount(number).Unblock();
            Console.WriteLine($"Account {number} unblocked.");
        }

        internal Account FindAccount(int number)
        {
            if (accounts.Find(account => account.Number == number) == null)
            {
                throw new ArgumentNullException($"Account not found ({number}).");
            }
            else return accounts.Find(account => account.Number == number);
        }

        internal void SortPerNumber()
        {
            accounts.Sort((account1, account2) => account1.Number.CompareTo(account2.Number));
        }
        internal void SortPerNumberDescending()
        {
            accounts.Sort((account1, account2) => account2.Number.CompareTo(account1.Number));
        }
        internal void SortPerBalance()
        {
            accounts.Sort((account1, account2) => account1.Balance.CompareTo(account2.Balance));
        }
        internal void SortPerBalanceDescending()
        {
            accounts.Sort((account1, account2) => account2.Balance.CompareTo(account1.Balance));
        }

        internal decimal TotalBalance()
        {
            return accounts.Sum(account => account.Balance);
        }
        internal decimal TotalPositiveBalance()
        {
            return accounts.Where(account => account.Balance > 0).Sum(account => account.Balance);
        }
        internal decimal TotalNegativeBalance()
        {
            return accounts.Where(account => account.Balance < 0).Sum(account => account.Balance);
        }

        public override string ToString()
        {
            string result = "";
            foreach (Account account in accounts)
            {
                result += account.Number + " - " + account.GetType().Name + " - " + account.Balance + " " + account.Currency + "\n";
            }
            return result;
        }

        internal void Deposit(int number, decimal amount)
        {
            FindAccount(number).Balance += amount;
        }
        internal void Withdraw(int number, decimal amount)
        {
            FindAccount(number).Balance -= amount;
        }
        internal void Transfer(int fromNumber, int toNumber, decimal amount)
        {
            FindAccount(fromNumber).Balance -= amount;
            FindAccount(toNumber).Balance += amount;
        }
    }
}
