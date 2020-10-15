using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisksTheory_lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Utility(double x)
        {
            return 0.01 * x * x;
        }

        public double Expected_Utility(double x1,double p,double x2)
        {
            return p * Utility(x1) + (1 - p) * Utility(x2);
        }

        /// <summary>
        /// Determines which job to choose
        /// </summary>
        /// <param name="expUtil_1"> expected utility of the first job</param>
        /// <param name="expUtil_2"> expected utility of the second job</param>
        /// <param name="expUtil_3"> expected utility of the third job</param>
        /// <returns> recommendation string</returns>
        public String Choose_Job(double expUtil_1,double expUtil_2,double expUtil_3)
        {
            double max = Math.Max(expUtil_1, Math.Max(expUtil_2, expUtil_3));

            // creating a result string
            String result = "";
            if (max == expUtil_1) {
                result = "Better choose first job";
            }
            if (max == expUtil_2) {
                if (result != "")
                    result += " or second job";
                else
                    result = "Better choose second job";
            }
            if (max == expUtil_3)
            {
                if (result != "")
                    result += " or third job";
                else
                    result = "Better choose third job";
            }

            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double expUtil_1 = Expected_Utility(Convert.ToDouble(txtX1_1.Text), Convert.ToDouble(txtP_1.Text), Convert.ToDouble(txtX2_1.Text));
                double expUtil_2 = Expected_Utility(Convert.ToDouble(txtX1_2.Text), Convert.ToDouble(txtP_2.Text), Convert.ToDouble(txtX2_2.Text));
                double expUtil_3 = Expected_Utility(Convert.ToDouble(txtX1_3.Text), Convert.ToDouble(txtP_3.Text), Convert.ToDouble(txtX2_3.Text));

                lblRec.Text = Choose_Job(expUtil_1, expUtil_2, expUtil_3);
            }
            catch(FormatException)
            {
                MessageBox.Show("Incorrect data");
            }
        }
    }
}
