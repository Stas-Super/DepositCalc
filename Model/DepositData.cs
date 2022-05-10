using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalc.Model
{
    internal class DepositData
    {
        public int Months { get; set; }
        public double Sum { get; set; }
        public bool IsMonthly { get; set; }
        public bool IsBody { get; set; }
    }
}
