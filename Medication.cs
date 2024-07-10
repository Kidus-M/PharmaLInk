using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma__link
{
    internal class Medication
    {
        public int MedID { get; set; }
        public string MedName = "";
        public string Manufacturing_Company = "";
        public string Dosage ="";
        public string Description = "";
        public string Perscription = "";
        public string Expiry_Date = "";
        public double Cost { get; set; }
        public int Amount { get; set; }
    }
}
