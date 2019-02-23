using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // global variable plan
        string selectPlan = "DomesticPlan";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectPlan = "DomesticPlan"; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectPlan = "CommercialPlan";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectPlan = "InstitutionalPlan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // instantiate PlaneFactory
            PlanFactory planeFactory = new PlanFactory();

            // instantiate Plan to get back the plan type
            Plan plan = planeFactory.getPlan(this.selectPlan);

            // invoke getRate and calculate bill
            plan.getRate();
            plan.calculateBill(Convert.ToInt32(txtUnits.Text),this.selectPlan);
        }
    }
}