using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisksThery_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // delegate for risk assessment functions
        delegate double Action(Variant obj);


        private bool checkIncomeSuccess()
        {
            if (Double.Parse(txtAIncomeSucc.Text) < 0)
                return false;
            if (Double.Parse(txtBIncomeSucc.Text) < 0)
                return false;
            if(Double.Parse(txtCIncomeSucc.Text) < 0)
                return false;

            return true;
        }

        private bool checkProbability()
        {
            // check variant A
            if (Double.Parse(txtAProbSucc.Text) < 0 || Double.Parse(txtAProbSucc.Text) > 1)
                return false;
            if (Double.Parse(txtAProbFail.Text) < 0 || Double.Parse(txtAProbFail.Text) > 1)
                return false;

            // check variant B
            if (Double.Parse(txtBProbSucc.Text) < 0 || Double.Parse(txtBProbSucc.Text) > 1)
                return false;
            if (Double.Parse(txtBProbFail.Text) < 0 || Double.Parse(txtBProbFail.Text) > 1)
                return false;

            // check variant C
            if (Double.Parse(txtCProbSucc.Text) < 0 || Double.Parse(txtCProbSucc.Text) > 1)
                return false;
            if (Double.Parse(txtCProbFail.Text) < 0 || Double.Parse(txtCProbFail.Text) > 1)
                return false;

            return true;
        }

        private bool checkTextBoxes()
        {
            // check all text boxes
            foreach (Control elem in Controls)
            {
                if(elem.GetType() == typeof(TextBox))
                {
                    double temp;
                    if (!Double.TryParse(elem.Text, out temp))
                        return false;
                }
            }

            // if all data is double then need to check bounds of probability
            if (checkProbability() == false)
                return false;

            // if all data is double then need to check success income on negative numbers
            return checkIncomeSuccess();
        }

        private double mathExpectation(Variant obj)
        {
            return obj.incomeSuccess * obj.probSuccess + obj.incomeFail * obj.probFail;
        }

        private double variation(Variant obj)
        {
            double mathExpect = mathExpectation(obj);
            double firstTerm = (obj.incomeSuccess - mathExpect) * (obj.incomeSuccess - mathExpect) * obj.probSuccess;
            double secondTerm = (obj.incomeFail - mathExpect) * (obj.incomeFail - mathExpect) * obj.probFail;

            return firstTerm + secondTerm;
        }

        private double variationCoeff(Variant obj)
        {
            return standartDeviation(obj)/mathExpectation(obj);
        }

        private double semiSquareVariation(Variant obj)
        {
            if (obj.incomeFail < 0)
            {
                double mathExpect = mathExpectation(obj);
                return Math.Sqrt((obj.incomeFail - mathExpect) * (obj.incomeFail - mathExpect) * obj.probFail);

            }

            return 0;
        }
        
        private double standartDeviation(Variant obj)
        {
            return Math.Sqrt(variation(obj));
        }

        private double coeffSemiVar(Variant obj)
        {
            return semiSquareVariation(obj) / mathExpectation(obj);
        }

        private double probabilityLosses(Variant obj)
        {
            if (obj.incomeFail <= 0)
                return obj.probFail;

            return 0;
        }

        private double expectedLosses(Variant obj)
        {
            if (obj.incomeFail <= 0)
                return obj.incomeFail * obj.probFail;

            return 0;
        }


        // return info about first variant
        private Variant getA()
        {
            Variant obj = new Variant();
            obj.probSuccess = Convert.ToDouble(txtAProbSucc.Text);
            obj.probFail = Convert.ToDouble(txtAProbFail.Text);
            obj.incomeSuccess = Convert.ToDouble(txtAIncomeSucc.Text);
            obj.incomeFail = Convert.ToDouble(txtAIncomeFail.Text);

            return obj;
        }

        // return info about second variant
        private Variant getB()
        {
            Variant obj = new Variant();
            obj.probSuccess = Convert.ToDouble(txtBProbSucc.Text);
            obj.probFail = Convert.ToDouble(txtBProbFail.Text);
            obj.incomeSuccess = Convert.ToDouble(txtBIncomeSucc.Text);
            obj.incomeFail = Convert.ToDouble(txtBIncomeFail.Text);

            return obj;
        }

        // return info about third variant
        private Variant getC()
        {
            Variant obj = new Variant();
            obj.probSuccess = Convert.ToDouble(txtCProbSucc.Text);
            obj.probFail = Convert.ToDouble(txtCProbFail.Text);
            obj.incomeSuccess = Convert.ToDouble(txtCIncomeSucc.Text);
            obj.incomeFail = Convert.ToDouble(txtCIncomeFail.Text);

            return obj;
        }

        // show results and recommendation
        private void showResults(Action action, double resultA, double resultB, double resultC)
        {
            lblResultA.Text = resultA.ToString();
            lblResultB.Text = resultB.ToString();
            lblResultC.Text = resultC.ToString();

            double min = Math.Min(resultA, Math.Min(resultB, resultC));
            double max = Math.Max(resultA, Math.Max(resultB, resultC));

            // showing recomendation
            String recommend = "";

            if(action == mathExpectation)
            {
                if (max == resultA)
                    recommend += "перший варіант, ";
                if (max == resultB)
                    recommend += "другий варіант, ";
                if (max == resultC)
                    recommend += "третій варіант ";
            }
            else
            {
                if (min == resultA)
                    recommend += "перший варіант, ";
                if (min == resultB)
                    recommend += "другий варіант, ";
                if (min == resultC)
                    recommend += "третій варіант ";
            }

            lblRecommend.Text = "Рекомендація:\n" + recommend;

        }

        // check radio buttons and
        // return delegate on checked function
        private Action getFunction()
        {
            if (rbtStandDeviation.Checked)
            {
                return standartDeviation;
            }
            if (rbtLosesProb.Checked)
            {
                return probabilityLosses;
            }
            if (rbtLosessExpect.Checked)
            {
                return expectedLosses;
            }
            if (rbtSemiSquare.Checked)
            {
                return semiSquareVariation;
            }
            if (rbtVariationCoeff.Checked)
            {
                return variationCoeff;
            }
            if (rbtSemiVarCoeff.Checked)
            {
                return coeffSemiVar;
            }
            if (rbtMathExpect.Checked)
            {
                return mathExpectation;
            }

            return variation;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                // creating objects about companies(variants)
                Variant A = getA();
                Variant B = getB();
                Variant C = getC();

                // creating delegate
                Action action = getFunction();

                // showing results of checked function
                showResults(action, action(A), action(B), action(C));
            }
            else
            {
                MessageBox.Show("Incorrect data!");
            }
        }
    }
}
