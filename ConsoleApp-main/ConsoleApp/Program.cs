using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace ConsoleApp
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DataReader();
            //zmiana na data.csv
            reader.ImportAndPrintData("data.csv");
        }
    }
}
