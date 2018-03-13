using iCodeGenerator.GenericDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeGenerator.DatabaseStructure
{
   public  class CommentStrategy
    {
        protected string _connection;

        protected Table _table;


        public CommentStrategy(string connection, Table table)
        {
            this._connection = connection;
            this._table = table;
        }

        public virtual void FillColumnComments()
        {

        }
    }
}
