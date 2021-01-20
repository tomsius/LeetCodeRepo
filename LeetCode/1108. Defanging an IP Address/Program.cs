using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1108.Defanging_an_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            string address1 = "1.1.1.1";
            Console.WriteLine(DefangIPaddr(address1));
            Console.WriteLine(DefangIPaddr2(address1));
            Console.WriteLine(DefangIPaddr3(address1));

            string address2 = "255.100.50.0";
            Console.WriteLine(DefangIPaddr(address2));
            Console.WriteLine(DefangIPaddr2(address2));
            Console.WriteLine(DefangIPaddr3(address2));

            Console.ReadLine();
        }

        public static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        public static string DefangIPaddr2(string address)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < address.Length; i++)
            {
                if (!address[i].Equals('.'))
                {
                    sb.Append(address[i]);
                }
                else
                {
                    sb.Append("[.]");
                }
            }

            return sb.ToString();
        }

        public static string DefangIPaddr3(string address)
        {
            char[] addressArray = new char[address.Length + 6];
            int index = 0;

            for (int i = 0; i < address.Length; i++)
            {
                if (!address[i].Equals('.'))
                {
                    addressArray[index++] = address[i];
                }
                else
                {
                    addressArray[index++] = '[';
                    addressArray[index++] = '.';
                    addressArray[index++] = ']';
                }
            }

            return new string(addressArray);
        }
    }
}
