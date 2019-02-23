using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFactoryPattern
{
    abstract class Plan
    {
        protected double rate;
        abstract public void getRate();

        public void calculateBill(int units, string planType)
        {
            MessageBox.Show("Aziz\nBill Amount : "+units * rate, planType);
        }
    }   
}
