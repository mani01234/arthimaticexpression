using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluationexpress
{
    class StringExpression
    {
      double  result;
        Mani.Parser.MathParser pars = new Mani.Parser.MathParser();
        public double MExpression()
        {
           result= pars.Parse("1+2-3");

         

            return result;

        }
        public double ParenthisExpress()
        {
            result = pars.Parse("3(7+3)");



            return result;

        }

    }
}
