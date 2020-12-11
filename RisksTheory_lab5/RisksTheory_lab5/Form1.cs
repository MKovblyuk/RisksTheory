using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisksTheory_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private bool checkProbability()
        {
            return Convert.ToDouble(txtP1.Text) + Convert.ToDouble(txtP2.Text) +
                Convert.ToDouble(txtP3.Text) + Convert.ToDouble(txtP4.Text) +
                Convert.ToDouble(txtP5.Text) == 1;
        }
        private bool checkTextBoxes()
        {
            // check all text boxes
            foreach (Control elem in Controls)
            {
                if (elem.GetType() == typeof(TextBox))
                {
                    double temp;
                    if (!Double.TryParse(elem.Text, out temp))
                        return false;
                }
            }

            // if all data is double then need to check bounds of probability
            return checkProbability();
        }


        public int MinExpValue(double[][] states, double[] p)
        {
            List<double> solutions = new List<double>();
            for (int i = 0; i < states.Length; i++)
            {
                double sv = 0;
                for (int j = 0; j < states[i].Length; j++)
                { 
                    sv += p[j] * Math.Pow(states[i][j] - p[j] * states[i][j],2);
                }
                solutions.Add(sv);
            }

            return solutions.IndexOf(solutions.Min()) + 1;
        }

        public int Bayes(double[][] states, double[] p)
        {
            List<double> solutions = new List<double>();
            for(int i = 0;i < states.Length; i++)
            {
                double bi = 0;
                for(int j = 0;j < states[i].Length; j++)
                {
                    bi += p[j] * states[i][j];
                }
                solutions.Add(bi);
            }

            return solutions.IndexOf(solutions.Max()) + 1;
        }

        public double[][] GetStatesOfEconEnvironment()
        {
            double[][] states = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                states[i] = new double[5];
            }

            states[0][0] = Convert.ToDouble(txtX1_Th1.Text);
            states[0][1] = Convert.ToDouble(txtX1_Th2.Text);
            states[0][2] = Convert.ToDouble(txtX1_Th3.Text);
            states[0][3] = Convert.ToDouble(txtX1_Th4.Text);
            states[0][4] = Convert.ToDouble(txtX1_Th5.Text);

            states[1][0] = Convert.ToDouble(txtX2_Th1.Text);
            states[1][1] = Convert.ToDouble(txtX2_Th2.Text);
            states[1][2] = Convert.ToDouble(txtX2_Th3.Text);
            states[1][3] = Convert.ToDouble(txtX2_Th4.Text);
            states[1][4] = Convert.ToDouble(txtX2_Th5.Text);

            states[2][0] = Convert.ToDouble(txtX3_Th1.Text);
            states[2][1] = Convert.ToDouble(txtX3_Th2.Text);
            states[2][2] = Convert.ToDouble(txtX3_Th3.Text);
            states[2][3] = Convert.ToDouble(txtX3_Th4.Text);
            states[2][4] = Convert.ToDouble(txtX3_Th5.Text);

            states[3][0] = Convert.ToDouble(txtX4_Th1.Text);
            states[3][1] = Convert.ToDouble(txtX4_Th2.Text);
            states[3][2] = Convert.ToDouble(txtX4_Th3.Text);
            states[3][3] = Convert.ToDouble(txtX4_Th4.Text);
            states[3][4] = Convert.ToDouble(txtX4_Th5.Text);

            return states;
        }

        public double[] GetProbabilities()
        {
            return new double[]
            {
                Convert.ToDouble(txtP1.Text),
                Convert.ToDouble(txtP2.Text),
                Convert.ToDouble(txtP3.Text),
                Convert.ToDouble(txtP4.Text),
                Convert.ToDouble(txtP5.Text),
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                int optimalVariant = rbtBayes.Checked ? Bayes(GetStatesOfEconEnvironment(), GetProbabilities()) :
                    MinExpValue(GetStatesOfEconEnvironment(), GetProbabilities());
                lblOptimalVariant.Text = "Optimal variant: " + optimalVariant.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect data");
            }
        }
    }
}
