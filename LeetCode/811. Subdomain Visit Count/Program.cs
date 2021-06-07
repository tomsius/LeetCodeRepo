using System;
using System.Collections.Generic;

namespace _811._Subdomain_Visit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = { "9001 discuss.leetcode.com" };
            Console.WriteLine(String.Join(", ", SubdomainVisits(input1)));

            string[] input2 = { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            Console.WriteLine(String.Join(", ", SubdomainVisits(input2)));
        }

        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            IList<string> subdomains = new List<string>();
            Dictionary<string, int> subdomainVisits = new Dictionary<string, int>();

            foreach (var countPair in cpdomains)
            {
                string[] countPairDomain = countPair.Split(' ');

                int startIndex = 0;
                while (startIndex != -1)
                {
                    string subdomainName = startIndex == 0 ? countPairDomain[1] : countPairDomain[1].Substring(startIndex + 1);
                    int subdomainVisitCount = int.Parse(countPairDomain[0]);

                    if (subdomainVisits.ContainsKey(subdomainName))
                    {
                        subdomainVisits[subdomainName] += subdomainVisitCount;
                    }
                    else
                    {
                        subdomainVisits[subdomainName] = subdomainVisitCount;
                    }

                    startIndex = countPairDomain[1].IndexOf('.', startIndex + 1);
                }
            }

            foreach (var kvp in subdomainVisits)
            {
                subdomains.Add(kvp.Value + " " + kvp.Key);
            }

            return subdomains;
        }
    }
}
