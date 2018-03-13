using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeGenerator.DatabaseStructure.SQLServer
{
    public class CommentStrategySQLServer : CommentStrategy
    {
        public CommentStrategySQLServer(string connection, Table table) : base(connection, table)
        {
        }

        public override void FillColumnComments()
        {
            string sql = @"SELECT
A.name AS table_name,
B.name AS column_name columnName,
C.value AS column_description Comments
FROM sys.tables A
INNER JOIN sys.columns B ON B.object_id = A.object_id
LEFT JOIN sys.extended_properties C ON C.major_id = B.object_id AND C.minor_id = B.column_id
WHERE A.name = '" + this._table.Name + "'";
            IEnumerable<CommentProperties> items;
            using (IDbConnection con = new SqlConnection(this._connection))
            {
                con.Open();
                items = con.Query<CommentProperties>(sql);
            }

            ColumnCollection collections = this._table.Columns;
            for (var i = 0; i < collections.Count; i++)
            {
                var currentColumn = collections[i];
                var matcheComment = items.FirstOrDefault(m => m.ColumnName == currentColumn.Name);
                if (matcheComment != null)
                {
                    currentColumn.Comments = matcheComment.Comments;
                }
            }

        }
    }
}
