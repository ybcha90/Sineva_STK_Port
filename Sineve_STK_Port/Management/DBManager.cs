using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Sineva_STK_Port.Management
{
    public class DBManager
    {
        string strConnectPortDB = System.Configuration.ConfigurationManager.ConnectionStrings["PortManager"].ToString();
        string strConnectHistoryDB = System.Configuration.ConfigurationManager.ConnectionStrings["HistoryManager"].ToString();


        public DataTable GetPortDataBase(String strSQL)
        {
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectPortDB))
            {
                SQLiteCommand ObjCommand = null;
                SQLiteDataAdapter ObjDataAdapter = null;

                DataTable dataTable = null;
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
                    //ObjDataAdapter.Dispose();
                    //ObjCommand.Dispose();
                    objConnection.Close();
                }
            }
        }

        public DataTable GetHistoryDataBase(String strSQL)
        {
            using (SQLiteConnection objConnection = new SQLiteConnection(strConnectHistoryDB))
            {
                SQLiteCommand ObjCommand = null;
                SQLiteDataAdapter ObjDataAdapter = null;

                DataTable dataTable = null;
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
                    ObjDataAdapter.Dispose();
                    ObjCommand.Dispose();
                    objConnection.Close();
                }
            }
        }
    }
}
