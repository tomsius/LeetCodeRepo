using System;
using System.Collections.Generic;

namespace _1773._Count_Items_Matching_a_Rule
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IList<string>> input1 = new List<IList<string>>
            {
                new List<string>
                {
                    "phone",
                    "blue",
                    "pixel"
                },
                new List<string>
                {
                    "computer",
                    "silver",
                    "lenovo"
                },
                new List<string>
                {
                    "phone",
                    "gold",
                    "iphone"
                }
            };
            string ruleKey1 = "color";
            string ruleValue1 = "silver";
            Console.WriteLine(CountMatches1(input1, ruleKey1, ruleValue1));

            IList<IList<string>> input2 = new List<IList<string>>
            {
                new List<string>
                {
                    "phone",
                    "blue",
                    "pixel"
                },
                new List<string>
                {
                    "computer",
                    "silver",
                    "phone"
                },
                new List<string>
                {
                    "phone",
                    "gold",
                    "iphone"
                }
            };
            string ruleKey2 = "type";
            string ruleValue2 = "phone";
            Console.WriteLine(CountMatches1(input2, ruleKey2, ruleValue2));
        }

        public static int CountMatches1(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int output = 0;

            foreach (var item in items)
            {
                switch (ruleKey)
                {
                    case "type":
                        if (item[0] == ruleValue)
                        {
                            output++;
                        }

                        break;
                    case "color":
                        if (item[1] == ruleValue)
                        {
                            output++;
                        }

                        break;
                    case "name":
                        if (item[2] == ruleValue)
                        {
                            output++;
                        }

                        break;
                    default:
                        break;
                }
            }

            return output;
        }

        public static int CountMatches2(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int output = 0;

            foreach (var item in items)
            {
                if (IsMatch(item, ruleKey, ruleValue))
                {
                    output++;
                }
            }

            return output;
        }

        public static bool IsMatch(IList<string> item, string ruleKey, string ruleValue)
        {
            switch (ruleKey)
            {
                case "type":
                    return item[0] == ruleValue;
                case "color":
                    return item[1] == ruleValue;
                case "name":
                    return item[2] == ruleValue;
                default:
                    return false;
            }
        }
    }
}
