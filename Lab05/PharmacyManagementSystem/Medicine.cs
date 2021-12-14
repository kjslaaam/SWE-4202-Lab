using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    public class Medicine
    {
        public string ID;
        public string Name;
        public int Stock;
        public double Price;
        public string GetInfo()
        {
            return ID + " " + Name+ " " + Convert.ToString(Stock); 
        }
    }
}
