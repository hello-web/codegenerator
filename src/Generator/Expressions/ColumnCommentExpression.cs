using iCodeGenerator.DatabaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace iCodeGenerator.Generator.Expressions
{
   
    public class ColumnCommentExpression : Expression
    {
        /// <summary>
        /// 
        /// </summary>
        private const string _columnName = "COLUMN.COMMENT";
        public override void Interpret(Context context)
        {
            Column column = (Column)Parameter;
            if(column.Comments!= null)
            {
                context.Output = Regex.Replace(context.Input, Context.StartDelimeter + _columnName + Context.EndingDelimiter, column.Comments);
            }
           
            context.Input = context.Output;
        }
    }
}
