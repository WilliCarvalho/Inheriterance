using System;
using Inheriterance.Entities;
using System.Collections.Generic;

namespace Inheriterance
{
    class Program
    {     

        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} Data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if(ch == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else if(ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(employees, name, anualIncome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach(TaxPayer payer in list)
            {
                Console.WriteLine($"{payer.Name}: ${payer.Tax()}");
                sum += payer.Tax();
            }

            Console.WriteLine($"TOTAL TAXES: ${sum}");
        }
    }
}
