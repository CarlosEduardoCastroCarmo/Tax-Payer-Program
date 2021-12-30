using System;
using System.Collections.Generic;
using TaxPayerCourse.Entities;
using System.Globalization;

namespace TaxPayerCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayer = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payers #{i} data: ");
                Console.Write("Individual or company: ");
                char taxType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (taxType == 'I' || taxType == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healthEpediture = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayer.Add(new Individual(name, anualIcome, healthEpediture));
                }
                else
                {
                    Console.Write("Numbers of employees: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine());

                    taxPayer.Add(new Company(name, anualIcome, numberOfEmployee));
                }
            }

            double sum = 0;

            Console.WriteLine();

            foreach (TaxPayer tp in taxPayer)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp);

                sum += tax;
            }

            Console.WriteLine($"Total Taxes: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
