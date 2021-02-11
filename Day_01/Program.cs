using System;
using System.Collections.Generic;
using System.IO;
using Utility_Library;

namespace Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ExpensesData = File.ReadAllLines(@"D:\Users\U.6076325\source\repos\Advent_of_Code_2020\Data Input\201201 Input.txt");

            WorkingEnvioroment enviromentData = new WorkingEnvioroment();

            enviromentData = enviromentData.EnviromentInfo();

            Console.WriteLine($"OsVersion : {enviromentData.OsVersion}");
            Console.WriteLine($"CurrentDirectory : {enviromentData.CurrentDirectory}");
            Console.WriteLine($"MachineName : {enviromentData.MachineName}");
            Console.WriteLine($"UserDomainName : {enviromentData.UserDomainName}");
            Console.WriteLine($"UserName : {enviromentData.UserName}");


            //Set Target Expense
            int targetExpense = 2020;

            //Convert ExpensesData to Integer List of Expenses
            var expenses = new List<int>();
            foreach (string expense in ExpensesData)
            {
                try
                {
                    expenses.Add(Int32.Parse(expense));
                }
                catch
                {
                    Console.WriteLine($"{expense} is not an integer");
                }
            }

            //Part one
            Console.WriteLine($"PART ONE\n");
            for (int pass1 = 0; pass1 < expenses.Count - 1; ++pass1)
            {
                for (int pass2 = pass1 + 1; pass2 < expenses.Count; ++pass2)
                {
                    int expensesSum = expenses[pass1] + expenses[pass2];

                    if (expensesSum == targetExpense)
                    {
                        Console.WriteLine($"Sum Calculation  {expenses[pass1]} + {expenses[pass2]} = {expensesSum}\n");

                        int expensesMultiplier = expenses[pass1] * expenses[pass2];
                        Console.WriteLine($"Multiplier Calculation  {expenses[pass1]} x {expenses[pass2]} = {expensesMultiplier}");
                    }

                }

            }
            Console.WriteLine("\n ---------------------- ");

            //Part two
            Console.WriteLine($"PART TWO\n");
            for (int pass1 = 0; pass1 < expenses.Count - 1; ++pass1)
            {
                for (int pass2 = pass1 + 1; pass2 < expenses.Count; ++pass2)
                {
                    for (int pass3 = pass2 + 1; pass3 < expenses.Count; ++pass3)
                    {
                        int expensesSum = expenses[pass1] + expenses[pass2] + expenses[pass3];

                        if (expensesSum == targetExpense)
                        {
                            Console.WriteLine($"Sum Calculation  {expenses[pass1]} + {expenses[pass2]} + {expenses[pass3]} = {expensesSum}\n");

                            int expensesMultiplier = expenses[pass1] * expenses[pass2] * expenses[pass3];
                            Console.WriteLine($"Multiplier Calculation  {expenses[pass1]} x {expenses[pass2]} x {expenses[pass3]} = {expensesMultiplier}");
                        }
                    }

                }

            }
            Console.WriteLine("\n ---------------------- ");

            Console.WriteLine("FINISHED!");

            Console.ReadLine();
        }
    }
}
