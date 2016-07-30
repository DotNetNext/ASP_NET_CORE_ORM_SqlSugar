using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugar
{
    public class DataTable
    {
        public DataColumnCollection Columns { get; }

        public DataRowCollection Rows { get; }
    }
    public class DataColumn
    {
        public string ColumnName { get; internal set; }
        public object DataType { get; internal set; }
    }
    public class DataColumnCollection : IEnumerable, ICollection
    {
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        //
        // 摘要:
        //     获取该集合的 System.Collections.IEnumerator。
        //
        // 返回结果:
        //     该集合的 System.Collections.IEnumerator。
        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }

    public class DataRowCollection : IEnumerable, ICollection
    {
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        //
        // 摘要:
        //     获取该集合的 System.Collections.IEnumerator。
        //
        // 返回结果:
        //     该集合的 System.Collections.IEnumerator。
        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }

    public class DataRow
    {
        private object[] arr = new object[100];
        public object this[string name]
        {
            get
            {
                return null;
            }
            set
            {

            }
        }
    }


    public class SqlDataAdapter
    {
        private SqlCommand command;
        private string sql;
        private SqlConnection _sqlConnection;

        public SqlDataAdapter(SqlCommand command)
        {
            this.command = command;
        }

        public SqlDataAdapter(string sql, SqlConnection _sqlConnection)
        {
            this.sql = sql;
            this._sqlConnection = _sqlConnection;
        }

        public SqlCommand SelectCommand { get; internal set; }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
