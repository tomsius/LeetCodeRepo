using System.Collections.Generic;

namespace _937._Reorder_Data_in_Log_Files
{
    public class LogComparer : IComparer<string>
    {
        public int Compare(string log1, string log2)
        {
            // split into [identifier, content]
            string[] split1 = log1.Split(' ', 2);
            string[] split2 = log2.Split(' ', 2);

            bool isDigit1 = char.IsDigit(split1[1][0]);
            bool isDigit2 = char.IsDigit(split2[1][0]);

            // both letter logs
            if (!isDigit1 && !isDigit2)
            {
                int cmp = split1[1].CompareTo(split2[1]);

                // different content
                if (cmp != 0)
                {
                    return cmp;
                }

                // same content, compare identifiers
                return split1[0].CompareTo(split2[0]);
            }

            // only log1 is letter content
            if (!isDigit1 && isDigit2)
            {
                return -1;
            }
            // only log2 is letter content
            else if (isDigit1 && !isDigit2)
            {
                return 1;
            }
            // both logs are digit contents
            else
            {
                return 0;
            }
        }
    }
}
