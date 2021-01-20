using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1656.Design_an_Ordered_Stream
{
    class OrderedStream
    {
        private string[] stream;
        private int pointer;

        public OrderedStream(int n)
        {
            stream = new string[n];
            pointer = 0;
        }

        public IList<string> Insert(int id, string value)
        {
            IList<string> result = new List<string>();
            stream[id - 1] = value;

            if (pointer == id - 1)
            {
                for (int i = pointer; i < stream.Length; i++)
                {
                    if (stream[i] == null)
                    {
                        break;
                    }
                    result.Add(stream[i]);
                    pointer++;
                }
            }

            return result;
        }
    }
}
