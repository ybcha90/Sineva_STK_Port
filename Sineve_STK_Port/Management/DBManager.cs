using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Sineva_STK_Port.Management
{
    public class DBManager
    {
        private static string s_configPath = @"D:\DB\STK_Port\PORT.db3";
        private static string dbName = $@"Data Source={s_configPath}";
        private SQLiteDataAdapter sqlAdapter;

        public DataSet SelectAll(string table)
        {
            try
            {
                DataSet ds = new DataSet();

                string sql = $"SELECT * FROM {table}";
                sqlAdapter = new SQLiteDataAdapter(sql, dbName);
                sqlAdapter.Fill(ds, table);

                if (ds.Tables.Count > 0) return ds;
                else return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
    }
}
