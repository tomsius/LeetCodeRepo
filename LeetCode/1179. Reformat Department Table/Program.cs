using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1179.Reformat_Department_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Department table:
                +------+---------+-------+
                | id   | revenue | month |
                +------+---------+-------+
                | 1    | 8000    | Jan   |
                | 2    | 9000    | Jan   |
                | 3    | 10000   | Feb   |
                | 1    | 7000    | Feb   |
                | 1    | 6000    | Mar   |
                +------+---------+-------+

                Result table:
                +------+-------------+-------------+-------------+-----+-------------+
                | id   | Jan_Revenue | Feb_Revenue | Mar_Revenue | ... | Dec_Revenue |
                +------+-------------+-------------+-------------+-----+-------------+
                | 1    | 8000        | 7000        | 6000        | ... | null        |
                | 2    | 9000        | null        | null        | ... | null        |
                | 3    | null        | 10000       | null        | ... | null        |
                +------+-------------+-------------+-------------+-----+-------------+

            SELECT id, 
            MAX(CASE WHEN month='Jan' THEN revenue END) AS 'Jan_Revenue',
            MAX(CASE WHEN month='Feb' THEN revenue END) AS 'Feb_Revenue',
            MAX(CASE WHEN month='Mar' THEN revenue END) AS 'Mar_Revenue',
            MAX(CASE WHEN month='Apr' THEN revenue END) AS 'Apr_Revenue',
            MAX(CASE WHEN month='May' THEN revenue END) AS 'May_Revenue',
            MAX(CASE WHEN month='Jun' THEN revenue END) AS 'Jun_Revenue',
            MAX(CASE WHEN month='Jul' THEN revenue END) AS 'Jul_Revenue',
            MAX(CASE WHEN month='Aug' THEN revenue END) AS 'Aug_Revenue',
            MAX(CASE WHEN month='Sep' THEN revenue END) AS 'Sep_Revenue',
            MAX(CASE WHEN month='Oct' THEN revenue END) AS 'Oct_Revenue',
            MAX(CASE WHEN month='Nov' THEN revenue END) AS 'Nov_Revenue',
            MAX(CASE WHEN month='Dec' THEN revenue END) AS 'Dec_Revenue'
            FROM Department
            GROUP BY id;
             */
        }
    }
}
