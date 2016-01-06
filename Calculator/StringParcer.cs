using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringParcer : IDoOperations
    {
        public void checkForNumber(string incomingExpression)
        {
           // if(
        }
        public string DoOperations(string incomingExpression)
        {
            if (incomingExpression.Contains("*"))
            {
                string multiOut;
                string multiReturn;
                MathClass mathClass = new MathClass();
                multiOut = Regex.Match(incomingExpression, @"[0-9]*['\*'][0-9]*").ToString();
                multiReturn = mathClass.Multiply(multiOut);
                incomingExpression = Regex.Replace(incomingExpression, @"[0-9]*['\*'][0-9]*", multiReturn).ToString();
                return incomingExpression;
            }
            else if (incomingExpression.Contains("/"))
            {
                string divOut, divReturn;
                MathClass mathClass = new MathClass();
                divOut = Regex.Match(incomingExpression, @"[0-9]*['\*'][0-9]*").ToString();
                divReturn = mathClass.Subtract(divOut);
                incomingExpression = Regex.Replace(incomingExpression, @"[0-9]*['\/'][0-9]*", divReturn).ToString();
                return incomingExpression;
            }
            else if (incomingExpression.Contains("+"))
            {
                string addOut, addReturn;
                MathClass mathClass = new MathClass();
                addOut = Regex.Match(incomingExpression, @"[0-9]*['\+'][0-9]*").ToString();
                addReturn = mathClass.Add(addOut);
                incomingExpression = Regex.Replace(incomingExpression, @"[0-9]*['\+'][0-9]*", addReturn).ToString();
                return incomingExpression;
            }
            else if (incomingExpression.Contains("-"))
            {
                string subOut, subReturn;
                MathClass mathClass = new MathClass();
                subOut = Regex.Match(incomingExpression, @"[0-9]*['\+'][0-9]*").ToString();
                subReturn = mathClass.Subtract(subOut);
                incomingExpression = Regex.Replace(incomingExpression, @"[0-9]*['\*'][0-9]*", subReturn).ToString();
                return incomingExpression;
            }
            else
                throw new NotImplementedException("invalid input");
        }
    }
}
