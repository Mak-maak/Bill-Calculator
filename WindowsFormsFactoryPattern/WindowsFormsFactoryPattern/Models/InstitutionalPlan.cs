using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFactoryPattern
{
    class InstitutionalPlan : Plan
    {
        public override void getRate()
        {
            rate = 5.50;
        }
    }
}
