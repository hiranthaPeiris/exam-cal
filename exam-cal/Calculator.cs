using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_cal
{
    class Calculator
    {
        CalculatorWindow calwin;
        string currentVal = "0";
        double total = 0.0;
        private OPERATORS currentOp = OPERATORS.NULL;

        public enum OPERATORS
        {
            NULL,
            ADD,
            MPY,
            SUB,
            DIV,
            EQL
        }
       
        public Calculator(CalculatorWindow calWindow)
        {
            calwin = calWindow;
            calwin.onValueChange(currentVal);
        }

        public void onInsertValue(string value)
        {
            if (currentVal == "0")
                currentVal = value;
            else
                currentVal += value;

            calwin.onValueChange(currentVal);
        }
        public void onInsertOperator(OPERATORS op)
        {
            double rst;
            Double.TryParse(currentVal, out rst);
            currentVal = "0";

            if (currentOp == OPERATORS.NULL)
            {
                total += rst;
                currentOp = op;
                calwin.onValueChange("");
                return;
            }
            switch (currentOp)
            {
                case OPERATORS.ADD:
                    total += rst;
                    break;
                case OPERATORS.MPY:
                    total *= rst;
                    break;
                case OPERATORS.DIV:
                    total /= rst;
                    break;
                case OPERATORS.SUB:
                    total -= rst;
                    break;      
                default:
                    break;
            }
            currentOp = op;
            calwin.onValueChange(total.ToString());
        }
        public void onClear()
        {
            currentVal = "0";
            total = 0.0;
            currentOp = OPERATORS.NULL;
            calwin.onValueChange(currentVal);
        }
    }
}
