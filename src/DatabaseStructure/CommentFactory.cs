using iCodeGenerator.DatabaseStructure.Oracle;
using iCodeGenerator.DatabaseStructure.SQLServer;
using iCodeGenerator.GenericDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeGenerator.DatabaseStructure
{
    public class CommentFactory
    {
        public static CommentStrategy GetStrategy(DataProviderType dataProviderType, string connection, Table table)
        {
            if (dataProviderType == DataProviderType.Oracle)
                return new CommentStrategyOracle(connection, table);
            else if( dataProviderType == DataProviderType.SqlClient)
            {
                return new CommentStrategySQLServer(connection, table);
            }
            return new CommentStrategy(connection, table);
        }
    }
}
