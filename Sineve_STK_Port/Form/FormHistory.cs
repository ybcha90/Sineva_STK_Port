using Sineva_STK_Port.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sineva_STK_Port
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        private void Btn_CarrierSearch_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager();
            gridCarrierHistory.DataSource = dbManager.GetHistoryDataBase("select * from CarrierHistory");
        }
    }
}
