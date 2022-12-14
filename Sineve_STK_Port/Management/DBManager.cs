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

    //=============================================================================================================== Port.DB
        #region 
        public DataTable GetPortDataBase(string strSQL)
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

        public List<string> GetListFromPortDB(string strSQL, string col)
        {
            List<string> listBtnName = new List<string>();
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
                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            listBtnName.Add(row[col].ToString());
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

        public DataTable GetUserByUserID(string strUserId)
        {
            string strSQL = string.Format(@"select * from User where ID = '{0}'", strUserId);
            return GetPortDataBase(strSQL);
        }

        public List<string> GetBtnNameByGroupId(string groupID)
        {
            string strSQL = string.Format(@"select BtnName from MenuGroup where GroupID = '{0}' and Enabled = 1", groupID);
            return GetListFromPortDB(strSQL, "BtnName");
        }

        public DataTable GetPortInfo()
        {
            string strSQL = string.Format(@"select * from PortConfig");
            return GetPortDataBase(strSQL);
        }

        public DataTable GetMessageDefine()
        {
            string strSQL = string.Format(@"select * from MessageDefine");
            return GetPortDataBase(strSQL);
        }

        public DataTable GetBtnTextTable()
        {
            string strSQL = string.Format(@"select * from MessageDefine");
            return GetPortDataBase(strSQL);
        }

        public (Dictionary<string, string>?, Dictionary<string, string>?) GetTextLanguage()
        {
            try
            {
                Dictionary<string, string> dictEngText = new Dictionary<string, string>();
                Dictionary<string, string> dictChnText = new Dictionary<string, string>();
                DataTable dt = new DataTable();

                string strSQLEng = string.Format(@"select Name,ENG from Language");
                string strSQLChn = string.Format(@"select Name,CHN from Language");
                
                dt = GetPortDataBase(strSQLEng);
                if(dt != null && dt.Rows.Count > 0)
                {
                    dictEngText = dt.AsEnumerable().ToDictionary(p => p[0].ToString(), p => p[1].ToString());
                    dt.Clear();
                }

                dt = GetPortDataBase(strSQLChn);
                if(dt != null && dt.Rows.Count > 0)
                {
                    dictChnText = dt.AsEnumerable().ToDictionary(p => p[0].ToString(), p => p[1].ToString());
                }

                return (dictEngText, dictChnText);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (null, null);
            }
        }

        public DataTable GetTextLanaguage()
        {
            string strSQL = string.Format(@"select * from Language");
            return GetPortDataBase(strSQL);
        }

        //GetCurrentAlarm
        public DataTable GetCurrentAlarm()
        {
            string strSQL = string.Format(@"select AlarmID,AlarmCode,AlarmText,SetTime from Alarm");
            return GetPortDataBase(strSQL);
        }
        #endregion

    //=============================================================================================================== History.DB
        #region
        public DataTable GetHistoryDataBase(string strSQL)
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

        public bool InsertHistoryDataBase(List<string> sqlList)
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

                        foreach (string sql in sqlList)
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
        #endregion
    }
}
