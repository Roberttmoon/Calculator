using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MathClass
    {
        public string Multiply(string incExpression)
        {
            string[] multiStrings = incExpression.Split('*');
            float multiReslut = float.Parse(multiStrings[0]) * float.Parse(multiStrings[1]);
            string reslutNumber = multiReslut.ToString();
            return reslutNumber;
        }
        public string Divide(string incExpression)
        {
            string[] divString = incExpression.Split('/');
            if (divString[1] == "0")
                return "DivBy0";
            else
            {
                float divReslut = float.Parse(divString[0]) / float.Parse(divString[1]);
                string reslutNumber = divReslut.ToString();
                return reslutNumber;
            }
        }
        public string Add(string incExpression)
        {
            string[] addString = incExpression.Split('+');
            float addReslut = float.Parse(addString[0]) + float.Parse(addString[1]);
            string reslutNumber = addReslut.ToString();
            return reslutNumber;
        }
        public string Subtract(string incExpression)
        {
            string[] subtractString = incExpression.Split('-');
            float subReslut = float.Parse(subtractString[0]) - float.Parse(subtractString[1]);
            string reslutNumber = subReslut.ToString();
            return reslutNumber;
        }
    }
}
