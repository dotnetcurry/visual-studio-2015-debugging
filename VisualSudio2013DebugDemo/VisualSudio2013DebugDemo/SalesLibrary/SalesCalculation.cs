using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class SalesCalculation
    {
        public double SalesNetProfit(double COGS,double Expenses,double ActualSales)
        {
            return ActualSales - (COGS + Expenses);
        }
        NorthwindDataContext dataContext = new NorthwindDataContext();
        public List<Customer> FetchCustomer()
        {
            var customers = dataContext.Customers.ToList();
            return customers;
        }
    }
}
