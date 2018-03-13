using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace iCodeGenerator.DatabaseStructure.Oracle
{
    public class CommentStrategyOracle : CommentStrategy
    {
        public CommentStrategyOracle(string connection, Table table) : base(connection, table)
        {

        }

        public override void FillColumnComments()
        {
            string sql = @"select c.COLUMN_NAME columnName, c.COMMENTS  From user_col_comments c where c.TABLE_NAME = '" + this._table.Name + "'";
            IEnumerable<CommentProperties> items;
            using (IDbConnection con = new OracleConnection(this._connection))
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
