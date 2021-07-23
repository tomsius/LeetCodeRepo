using System;
using System.Collections.Generic;
using System.Text;

namespace _917._Reverse_Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ab-cd";
            Console.WriteLine(ReverseOnlyLetters1(s1));
            Console.WriteLine(ReverseOnlyLetters2(s1));
            Console.WriteLine(ReverseOnlyLetters3(s1));
            Console.WriteLine(ReverseOnlyLetters4(s1));

            string s2 = "a-bC-dEf-ghIj";
            Console.WriteLine(ReverseOnlyLetters1(s2));
            Console.WriteLine(ReverseOnlyLetters2(s2));
            Console.WriteLine(ReverseOnlyLetters3(s2));
            Console.WriteLine(ReverseOnlyLetters4(s2));

            string s3 = "Test1ng-Leet=code-Q!";
            Console.WriteLine(ReverseOnlyLetters1(s3));
            Console.WriteLine(ReverseOnlyLetters2(s3));
            Console.WriteLine(ReverseOnlyLetters3(s3));
            Console.WriteLine(ReverseOnlyLetters4(s3));

            string s4 = "";
            Console.WriteLine(ReverseOnlyLetters1(s4));
            Console.WriteLine(ReverseOnlyLetters2(s4));
            Console.WriteLine(ReverseOnlyLetters3(s4));
            Console.WriteLine(ReverseOnlyLetters4(s4));
        }

        public static string ReverseOnlyLetters1(string s)
        {
            if (s.Length == 0)
            {
                return s;
            }

            char[] reversedCharacters = new char[s.Length];
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (char.IsLetter(s[start]) && char.IsLetter(s[end]))
                {
                    reversedCharacters[start] = s[end];
                    reversedCharacters[end] = s[start];
                    start++;
                    end--;

                    continue;
                }

                if (!char.IsLetter(s[start]))
                {
                    reversedCharacters[start] = s[start];
                    start++;

                    continue;
                }

                if (!char.IsLetter(s[end]))
                {
                    reversedCharacters[end] = s[end];
                    end--;

                    continue;
                }
            }

            if (reversedCharacters[start] == '\0')
            {
                reversedCharacters[start] = s[start];
            }

            return new string(reversedCharacters);
        }

        public static string ReverseOnlyLetters2(string s)
        {
            char[] characters = s.ToCharArray(); ;
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!char.IsLetter(characters[start]))
                {
                    start++;
                }
                else if (!char.IsLetter(characters[end]))
                {
                    end--;
                }
                else
                {
                    char temp = characters[start];
                    characters[start] = characters[end];
                    characters[end] = temp;
                    start++;
                    end--;
                }
            }

            return new string(characters);
        }

        public static string ReverseOnlyLetters3(string s)
        {
            Stack<char> letters = new Stack<char>(s.Length);

            foreach (var character in s)
            {
                if (char.IsLetter(character))
                {
                    letters.Push(character);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var character in s)
            {
                if (char.IsLetter(character))
                {
                    sb.Append(letters.Pop());
                }
                else
                {
                    sb.Append(character);
                }
            }

            return sb.ToString();
        }

        public static string ReverseOnlyLetters4(string s)
        {
            StringBuilder sb = new StringBuilder();
            int end = s.Length - 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    while (!char.IsLetter(s[end]))
                    {
                        end--;
                    }

                    sb.Append(s[end]);
                    end--;
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
