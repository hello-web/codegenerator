using iCodeGenerator.DatabaseStructure.Oracle;
using iCodeGenerator.GenericDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeGenerator.DatabaseStructure
{
  public  class CommentFactory
    {
        public static CommentStrategy GetStrategy(DataProviderType dataProviderType, string connection, Table table)
        {
            return new CommentStrategyOracle(connection, table);
        }
    }
}
