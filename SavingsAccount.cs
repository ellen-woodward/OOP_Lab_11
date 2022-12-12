using System;
namespace PastExam
{
    internal class SavingsAccount : Account
    {
        private const decimal INTEREST_RATE = 0.06m;

        public SavingsAccount(string firstName, string lastName, decimal balance, DateTime interestDate, string accountNumber)
            : base(firstName, lastName, balance, interestDate, accountNumber) { }

        public override void CalculateInterest()
        {
            DateTime allowedDate = DateTime.Now.AddYears(-1);
            if (allowedDate >= InterestDate)
            {
                Balance = Balance + (Balance * INTEREST_RATE);
                InterestDate = DateTime.Now;
            }
        }
    }
}



