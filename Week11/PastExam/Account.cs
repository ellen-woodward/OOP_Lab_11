using System;
namespace PastExam
{
    abstract class Account
    {
        #region properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public DateTime InterestDate { get; set; }

        #endregion properties

        #region constructors

        public Account(string firstName, string lastName, decimal balance, DateTime interestDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            InterestDate = interestDate;
        }

        public Account() { }

        public Account(string firstName, string lastName) :this(firstName, lastName, 0, DateTime.Now) { }

        #endregion constructors

        public decimal Deposit(decimal amount)
        {
            return Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            return Balance -= amount;
        }

        public abstract int CalculateInterest();
    }
}

