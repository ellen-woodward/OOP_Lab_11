using PastExam;

CurrentAccount ca1 = new CurrentAccount("John", "Duffy", 1000, DateTime.Now.AddYears(-2), "12345");
CurrentAccount ca2 = new CurrentAccount("Jane", "Duffy", 7000, DateTime.Now.AddYears(-3), "67890");

SavingsAccount sa1 = new SavingsAccount("John", "Smith", 3000, DateTime.Now.AddYears(-4), "13579");
SavingsAccount sa2 = new SavingsAccount("Jane", "Smith", 4000, DateTime.Now.AddYears(-5), "24680");


Console.WriteLine(ca1);
Console.WriteLine(ca2);
Console.WriteLine(sa1);
Console.WriteLine(sa2);

Console.ReadLine();