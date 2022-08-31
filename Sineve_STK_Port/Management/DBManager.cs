using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;

namespace Sineva_STK_Port.Management
{
    public class DBManager
    {
        #region Singleton
        private static volatile DBManager instance;
        private static object syncRoot = new object();

        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DBManager();
                    }
                }
                return instance;
            }
        }
        #endregion

        string strConnectPortDB = System.Configuration.ConfigurationManager.ConnectionStrings["PortManager"].ToString();
        string strConnectHistoryDB = System.Configuration.ConfigurationManager.ConnectionStrings["HistoryManager"].ToString();

        public DataTable GetPortDataBase(String strSQL)
        {
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectPortDB))
            {
                SQLiteCommand ObjCommand;
                SQLiteDataAdapter ObjDataAdapter;

                DataTable dataTable;
                try
                {
                    ObjCommand = new SQLiteCommand(strSQL, objConnection);
                    ObjCommand.CommandType = CommandType.Text;

                    objConnection.Open();

                    dataTable = new DataTable();
                    ObjDataAdapter = new SQLiteDataAdapter(ObjCommand);

                    ObjDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new DataTable();
                }
                finally
                {
                    if (objConnection.State == ConnectionState.Open)
                    {
                        objConnection.Close();
                    }
                }
            }
        }

        public DataTable GetHistoryDataBase(String strSQL)
        {
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectHistoryDB))
            {
                SQLiteCommand ObjCommand;
                SQLiteDataAdapter ObjDataAdapter;

                DataTable dataTable;
                try
                {
                    ObjCommand = new SQLiteCommand(strSQL, objConnection);
                    ObjCommand.CommandType = CommandType.Text;

                    objConnection.Open();

                    dataTable = new DataTable();
                    ObjDataAdapter = new SQLiteDataAdapter(ObjCommand);

                    ObjDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new DataTable();
                }
                finally
                {
                    if (objConnection.State == ConnectionState.Open)
                    {
                        objConnection.Close();
                    }
                }
            }
        }

        public bool InsertHistoryDataBase(List<String> sqlList)
        {
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectHistoryDB))
            {
                objConnection.Open();
                using (SQLiteTransaction tran = objConnection.BeginTransaction())
                {
                    try
                    {
                        SQLiteCommand ObjCommand = objConnection.CreateCommand();
                        ObjCommand.Transaction = tran;
                        ObjCommand.CommandType = CommandType.Text;

                        foreach(string sql in sqlList)
                        {
                            ObjCommand.CommandText = sql;
                            ObjCommand.ExecuteNonQuery();
                        }
                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                        {
                            objConnection.Close();
                        }
                    }
                }
            }
        }

        public DataTable GetUserByUserID(String strUserId)
        {
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectPortDB))
            {
                SQLiteCommand ObjCommand;
                SQLiteDataAdapter ObjDataAdapter;

                DataTable dataTable;
                try
                {
                    string strSQL = string.Format(@"select * from User where ID = '{0}'", strUserId);
                    ObjCommand = new SQLiteCommand(strSQL, objConnection);
                    ObjCommand.CommandType = CommandType.Text;

                    objConnection.Open();

                    dataTable = new DataTable();
                    ObjDataAdapter = new SQLiteDataAdapter(ObjCommand);

                    ObjDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new DataTable();
                }
                finally
                {
                    if (objConnection.State == ConnectionState.Open)
                    {
                        objConnection.Close();
                    }
                }
            }
        }

        public List<string> GetBtnNameByGroupId(String groupID)
        {
            List<string> listBtnName = new List<string>();
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectPortDB))
            {
                SQLiteCommand ObjCommand;
                SQLiteDataAdapter ObjDataAdapter;

                DataTable dataTable;
                try
                {
                    string strSQL = string.Format(@"select BtnName from MenuGroup where GroupID = '{0}' and Enabled = 1", groupID);
                    ObjCommand = new SQLiteCommand(strSQL, objConnection);
                    ObjCommand.CommandType = CommandType.Text;

                    objConnection.Open();

                    dataTable = new DataTable();
                    ObjDataAdapter = new SQLiteDataAdapter(ObjCommand);

                    ObjDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            listBtnName.Add(row["BtnName"].ToString());
                        }
                    }

                    return listBtnName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return listBtnName;
                }
                finally
                {
                    if (objConnection.State == ConnectionState.Open)
                    {
                        objConnection.Close();
                    }
                }
            }
        }

        public DataTable GetPortInfo()
        {
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectPortDB))
            {
                SQLiteCommand ObjCommand;
                SQLiteDataAdapter ObjDataAdapter;

                DataTable dataTable;
                try
                {
                    string strSQL = string.Format(@"select * from PortConfig");
                    ObjCommand = new SQLiteCommand(strSQL, objConnection);
                    ObjCommand.CommandType = CommandType.Text;

                    objConnection.Open();

                    dataTable = new DataTable();
                    ObjDataAdapter = new SQLiteDataAdapter(ObjCommand);

                    ObjDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new DataTable();
                }
                finally
                {
                    if (objConnection.State == ConnectionState.Open)
                    {
                        objConnection.Close();
                    }
                }
            }
        }
    }
}
