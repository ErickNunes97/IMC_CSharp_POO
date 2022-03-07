using System;
using System.Collections.Generic;
using System.Text;

namespace IMC
{
    class Calc
    {
        private float calc;
        private string status;

       

        public Calc(float height, float weight)
        {
            calc = weight / (height * height);
            

            if (calc < 18.5)
            {
                status = "Under weight";
            }

            if (calc >= 18.5 && calc <= 24.9)
            {
                status = "Normal weight";
            }

            if (calc >= 25 && calc <= 29.9)
            {
                status = "Overweight";
            }

            if (calc >= 30 && calc <= 34.9)
            {
                status = "Obesity 1";
            }

            if (calc >= 35 && calc <= 39.9)
            {
                status = "Obesity 2";
            }

            if (calc >= 40 && calc > 40)
            {
                status = "Obesity 3";
            }

        }

        public double getCalc()
        {
            return calc;
        }

        public String getStatus()
        {
            return status;
        }

    }
}
