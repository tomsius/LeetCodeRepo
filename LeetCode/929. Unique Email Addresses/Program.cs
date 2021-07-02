using System;
using System.Collections.Generic;
using System.Text;

namespace _929._Unique_Email_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails1 = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            Console.WriteLine(NumUniqueEmails(emails1));

            string[] emails2 = { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" };
            Console.WriteLine(NumUniqueEmails(emails2));
        }

        public static int NumUniqueEmails(string[] emails)
        {
            HashSet<string> uniqueEmails = new HashSet<string>(emails.Length);

            foreach (var email in emails)
            {
                string normalizedEmail = NormalizeEmail(email);
                uniqueEmails.Add(normalizedEmail);
            }

            return uniqueEmails.Count;
        }

        private static string NormalizeEmail(string email)
        {
            StringBuilder sb = new StringBuilder(email);
            int etaIndex = email.IndexOf('@');

            for (int i = 0; i < etaIndex; i++)
            {
                if (sb[i] == '.')
                {
                    sb.Remove(i, 1);
                    i--;
                    continue;
                }

                if (sb[i] == '+')
                {
                    etaIndex = sb.ToString().IndexOf('@');
                    sb.Remove(i, etaIndex - i);
                    break;
                }
            }

            return sb.ToString();
        }
    }
}
