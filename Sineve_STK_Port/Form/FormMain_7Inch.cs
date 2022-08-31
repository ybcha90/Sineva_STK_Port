using Sineva_STK_Port.Management;

namespace Sineva_STK_Port
{
    public partial class FormMain_7Inch : Form
    {
        public FormMain_7Inch()
        {
            InitializeComponent();
        }

        private void FormMain_7Inchi_Load(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager();
            //gridAlarmHistory.DataSource = dbManager.GetHistoryDataBase("select * from AlarmHistory");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        //private void Btn_History_Click(object sender, EventArgs e)
        //{
        //    FormHistory historyForm = new FormHistory();
        //    historyForm.FormBorderStyle = FormBorderStyle.None;
        //    historyForm.TopLevel = false;
        //    this.panelMain.Controls.Add(historyForm);//将子窗体载入panel
        //    historyForm.Show();
        //}
    }
}