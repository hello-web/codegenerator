using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace iCodeGenerator.Generator.Expressions
{
    public class TextRemoveExpression : Expression
    {
        private string _replaceText;


        public TextRemoveExpression(string replaceText)
        {
            _replaceText = replaceText;
        }

        public override void Interpret(Context context)
        {
            Regex regex = new Regex(_replaceText);
            context.Output = regex.Replace(context.Input, "");
        }
    }
}
