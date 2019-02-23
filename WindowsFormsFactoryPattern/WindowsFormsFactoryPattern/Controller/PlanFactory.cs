using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFactoryPattern
{
    class PlanFactory
    {
        public Plan getPlan(string arg)
        {
            if (string.Equals(arg, "DomesticPlan", StringComparison.OrdinalIgnoreCase))
                return new DomesticPlan();

            else if (string.Equals(arg, "CommercialPlan", StringComparison.OrdinalIgnoreCase))
                return new CommercialPlan();

            else if (string.Equals(arg, "InstitutionalPlan", StringComparison.OrdinalIgnoreCase))
                return new InstitutionalPlan();
            
            return null;
        }
    }
}
