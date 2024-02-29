using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperWheelsCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Sales s1 = new Sales { Month = "April" };
            Sales s2 = new Sales { Month = "May" };
            Sales s3 = new Sales { Month = "June" };
            Sales s4 = new Sales { Month = "July" };
            Sales s5 = new Sales { Month = "August" };
            Sales s6 = new Sales { Month = "September" };

            company.sales = new List<Sales> { s1, s2, s3, s4, s5, s6 };
            Console.WriteLine($"Company Name {company.Name}");
            Console.WriteLine($"Number of vehicles sold each month");
            company.VehiclesSoldEachMonth();
            Console.WriteLine("Number of vehicles sold to Retail : ");
            company.VehiclesSoldToRetailCustomers();
            Console.WriteLine("Number of vehicles sold to Corporate : ");
            company.VehiclesSoldToCorporateCustomers();

            Console.WriteLine($"Vehicles sold from August 15 to Sep 15 : {company.VehiclesSoldFromAugust15ToSep15()}"); 
        }
    }
}
