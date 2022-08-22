using Sineva_STK_Port.Management;
using System.Data;

namespace Sineva_STK_Port
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager();
            //gridAlarmHistory.DataSource = dbManager.GetHistoryDataBase("select * from AlarmHistory");
        }

        private void Btn_History_Click(object sender, EventArgs e)
        {
            FormHistory historyForm = new FormHistory();
            historyForm.FormBorderStyle = FormBorderStyle.None;
            historyForm.TopLevel = false;
            this.panelMain.Controls.Add(historyForm);//将子窗体载入panel
            historyForm.Show();
        }
    }
}