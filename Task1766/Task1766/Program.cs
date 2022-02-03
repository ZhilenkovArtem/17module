using System;

namespace Task1766
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите значение баланса");
                bool flag = double.TryParse(Console.ReadLine(), out double balance);
                if (!flag) continue;

                var salaryAccount = new Account();
                salaryAccount.Balance = balance;

                var ordinaryAccount = new Account();
                ordinaryAccount.Balance = balance;

                var salaryCalculator = new SalaryCalculator();
                salaryCalculator.CalculateInterest(salaryAccount);

                var ordinaryCalculator = new OrdinaryCalculator();
                ordinaryCalculator.CalculateInterest(ordinaryAccount);

                Console.WriteLine($"{salaryAccount.Interest}");
                Console.WriteLine($"{ordinaryAccount.Interest}");
            }
        }
    }
}
