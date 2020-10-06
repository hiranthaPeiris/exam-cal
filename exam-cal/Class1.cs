using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_cal
{
    class Class1 
    {
        CalculatorWindow calwind;
        string currentVal = "0";
        private double total = 0.0;
        private OPERATOR currentOp = OPERATOR.NULL;
        private enum OPERATOR
        {
            NULL,
            EQUL,
            ADD,
            SUB,
            MPY,
            DIV
        }

        public Class1(CalculatorWindow cal)
        {
            calwind = cal;
        }

        public void insesrtDigit(string val)
        {
            if (currentVal == "0")
                currentVal = val;
            else
                currentVal += val;
            calwind.onValueChange(currentVal);
        }

        public void InsertOp(OPERATOR op)
        {
           
        }
    }
}
