using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperWheelsCompany
{
    public class Sales
    {
        public List<VehiclesSold> VehiclesSold {  get; set; } = new List<VehiclesSold>();
        public int[] Units {  get; set; }
        public string Month { get; set; }
        public Sales() {
            Units = new int[30];
            Units[0] = 1;
            for (int i = 1; i < Units.Length; i++)
            {
                Units[i] = Units[i - 1] + (i * 2);
            }
            for(int i = 1; i <= 30; i++)
            {
                if(i % 5 == 0)
                {
                    VehiclesSold.Add(new VehiclesSold { Units = Units[i - 1], CompanyType = new Corporate() });
                }
                else
                {
                    VehiclesSold.Add(new VehiclesSold { Units = Units[i - 1], CompanyType = new Retail() });
                }
            }
        }
    }
}