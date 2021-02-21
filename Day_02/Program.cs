using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Utility_Library;


namespace Day_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize Global Variables & get variable info
            Globals globalVariables = new Globals();
            globalVariables = globalVariables.GetGlobalVariables();

            // check know environment and global variables initialized ok
            if (globalVariables.Failed)
            {
                Console.WriteLine($"Environment not found - Initialization Failed");
                Console.ReadLine();
                return;
            }

            //read data file
            string[] passwordData = File.ReadAllLines($"{globalVariables.DataPath}201202 Input.txt");


            //Part one

            // initialize password policy list
            List<PasswordPolicy> passwordPolicyList = new List<PasswordPolicy>();

            //populate list with password policy's
            foreach (string line in passwordData)
            {
                // split line of password data into individual parts
                string[] part = line.Split('-', ' ', ':', ';');

                // add each part to property fields of password list
                passwordPolicyList.Add(new PasswordPolicy
                {
                    Lowest = Int32.Parse(part[0]),
                    Highest = Int32.Parse(part[1]),
                    Contains = part[2],
                    Password = part[4]
                });
            }

            int validCount = 0;
            Console.WriteLine($"PART 1\n");

            //check for valid password policies
            foreach (PasswordPolicy policy in passwordPolicyList)
            {
                char ch = Convert.ToChar(policy.Contains);
                policy.ContainsCount = policy.Password.Count(p => p == ch);

                if (policy.ContainsCount >= policy.Lowest && policy.ContainsCount <= policy.Highest)
                {
                    validCount++;
                    policy.P1IsValid = true;
                    Console.WriteLine($"{policy.Contains} is in the password: {policy.Password} - {policy.ContainsCount} times.");
                }
            }

            Console.WriteLine($"\nThere are {validCount} valid password policy's.\n");


            //Part two

            Console.WriteLine("\n ---------------------- ");

            Console.WriteLine("FINISHED!");

            Console.ReadLine();
        }
    }
}
