using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculatorUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesLibrary.SalesCalculation calci = new SalesLibrary.SalesCalculation();
            double netProfit = calci.SalesNetProfit(2000, 4000, 15000);
            Console.WriteLine("Sales Net Profit is - $ {0}", netProfit);
            List<SalesLibrary.Customer> customers = calci.FetchCustomer();
            Console.ReadKey();
        }
    }
}
