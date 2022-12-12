using System;
namespace PastExam
{
    internal class CurrentAccount:Account
    {
        private const decimal INTEREST_RATE = 0.03m;

        public CurrentAccount(string firstName, string lastName, decimal balance, DateTime interestDate, string accountNumber)
            : base(firstName, lastName, balance, interestDate, accountNumber){}

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

