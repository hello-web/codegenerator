using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeGenerator.DatabaseStructure.Oracle
{
  public  class CommentStrategyOracle:CommentStrategy
    {
        public CommentStrategyOracle(string connection, Table table):base(connection, table)
        {

        }

        public override void FillColumnComments()
        {
            base.FillColumnComments();
        }
    }
}
