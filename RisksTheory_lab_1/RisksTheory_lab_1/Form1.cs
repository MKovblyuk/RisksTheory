using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisksTheory_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        
        private bool check_Decisions()
        {
            // check indexes in all comboboxes
            if (cmbForest_Rain.SelectedIndex < 0 || cmbForest_Sun.SelectedIndex < 0 ||
                cmbHome_Rain.SelectedIndex < 0 || cmbHome_Sun.SelectedIndex < 0)
                return false;
            else return true;
        }

        private float utility_Calculation(float probability_1, int utility_1, int utility_2)
        {
            return probability_1 * utility_1 + (100 - probability_1) * utility_2;
        }

        private void hscrSun_Probability_Scroll(object sender, ScrollEventArgs e)
        {
            // showind probability in labels
            lblSun_Probability.Text = hscrSun_Probability.Value.ToString() + " %";
            lblRain_Probability.Text = (100 - hscrSun_Probability.Value).ToString() + " %";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (check_Decisions())
            {
                // for further reduction create temporary variables
                // * 2 to get the right coefficients (0,2,4,6,8)
                // forest_r(rain)u(utility)
                int forest_ru = cmbForest_Rain.SelectedIndex * 2;
                int forest_su = cmbForest_Sun.SelectedIndex * 2;
                int home_ru = cmbHome_Rain.SelectedIndex * 2;
                int home_su = cmbHome_Sun.SelectedIndex * 2;

                float sun_probability = hscrSun_Probability.Value;

                // utility calculation
                float forest_utility = utility_Calculation(sun_probability, forest_su, forest_ru);
                float home_utility = utility_Calculation(sun_probability, home_su, home_ru);

                // showing utility
                lblForest_Utility.Text = forest_utility.ToString();
                lblHome_Utility.Text = home_utility.ToString();

                // showing decision
                if (forest_utility > home_utility)
                    lblDecision_Result.Text = "Вирушаємо до лісу !";
                else if(forest_utility == home_utility)
                    lblDecision_Result.Text = "Підкиньте монету :)";
                else
                    lblDecision_Result.Text = "Залишаємося вдома !";
            }
            else
                MessageBox.Show("Заповніть корисність рішеннь !");
        }
    }
}
