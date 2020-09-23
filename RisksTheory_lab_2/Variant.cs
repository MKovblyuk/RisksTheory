using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisksThery_Lab_2
{
    //class represents a variant of the company
    class Variant
    {
        public double probSuccess;
        public double probFail;
        public double incomeSuccess;
        public double incomeFail;

        public Variant()
        {
            probSuccess = 0;
            probFail = 0;
            incomeSuccess = 0;
            incomeFail = 0;
        }
        public Variant(double probS,double probF,double incomeS, double incomeF)
        {
            probSuccess = probS;
            probFail = probF;
            incomeSuccess = incomeS;
            incomeFail = incomeF;
        }
    }
}
