using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperWheelsCompany
{
    public class Company
    {
        public string Name = "Super Wheels Company";
        public List<Sales> sales { get; set; } = new List<Sales>();

        public void VehiclesSoldEachMonth()
        {
            int totalCount = 0;
            foreach(Sales s in sales)
            {
                Console.WriteLine($"Month: {s.Month}");
                int count = 0;
                foreach (var c in s.VehiclesSold)
                {
                    count += c.Units;
                }
                Console.WriteLine($"Sold count: {count}");
            }
        }

        public void VehiclesSoldToRetailCustomers()
        {
            int count = 0;
            foreach (var c in sales[0].VehiclesSold)
            {
                if(c.CompanyType is Retail)
                    count += c.Units;
            }
            Console.WriteLine($"Vehicles sold to Retail: {count}");
        }

        public void VehiclesSoldToCorporateCustomers()
        {
            int count = 0;
            foreach (Sales s in sales)
            {
                foreach (var c in s.VehiclesSold)
                {
                    if (c.CompanyType is Corporate)
                        count += c.Units;
                }
                Console.WriteLine($"Vehicles sold to Corporate: {count}");
            }
        }

        public int VehiclesSoldFromAugust15ToSep15()
        {
            int count = 0;
            for(int i = 15; i <= 30; i++)
            {
                count += sales[4].Units[i - 1];
            }
            for (int i = 1; i <= 15; i++)
            {
                count += sales[5].Units[i - 1];
            }
            return count;
        }
    }
}