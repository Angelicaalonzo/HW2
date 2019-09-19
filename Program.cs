//Angelica Alonzo
using System;

namespace Homework2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            tDate.earliestDate = "1/1/1900";
            tDate.latestDate = "12/31/2100";

            tDate d1 = new tDate(12,15,1990);
            tDate d2 = new tDate ("12/15/1990");
            tDate d3 = new tDate("15/12/1990");
            tDate d4 = new tDate("11/11/1118");


            
            d1.showDate('E');
            d1.showDate('U');

            d2.showDate('E');
            d2.showDate('U');

            d3.showDate('E');
            d3.showDate('U');

            d4.showDate('E');
            d4.showDate('U');


        }

    }
}
