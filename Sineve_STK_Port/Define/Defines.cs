using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Define
{
    internal class Defines
    {

    }

    public class DB_MESSAGE_DEFINE
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string EngName { get; set; }
        public string ChnName { get; set; }
        public string Button { get; set; }
        public string Icon { get; set; }
        public string TEXT { get; set; }

        public DB_MESSAGE_DEFINE() { }

        public static DB_MESSAGE_DEFINE Create_DB_MESSAGE_DEFINE(DataRow row)
        {
            DB_MESSAGE_DEFINE messageDefine = new DB_MESSAGE_DEFINE();
            messageDefine.ID = row["ID"].ToString();
            messageDefine.Title = row["Title"].ToString();
            messageDefine.EngName = row["EngName"].ToString();
            messageDefine.ChnName = row["ChnName"].ToString();
            messageDefine.Button = row["Button"].ToString();
            messageDefine.Icon = row["Icon"].ToString();
            return messageDefine;
        }
    }
}
