using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string parseResultSummary;
            string stringFirst = "24";
            int intFirst;

            bool success = int.TryParse(stringFirst, out intFirst);

            parseResultSummary = success
                                    ? "was successfully parsed"
                                    : "was not successfully parsed";

            Console.WriteLine(stringFirst + "  " + parseResultSummary);


            string stringSecond = "vt750";
            int intSecond;

            success = int.TryParse(stringSecond, out intSecond);
            parseResultSummary = success
                                   ? "was successfully parsed"
                                   : "was not successfully parsed";

            Console.WriteLine(stringSecond + "  " + parseResultSummary);

            Console.ReadLine();


        }
    }
}
