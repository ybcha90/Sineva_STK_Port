using Sineva_STK_Port.Management;

namespace Sineva_STK_Port
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            DBManager dbManager = new DBManager();
            dbManager.SelectAll("Alarm");
            InitializeComponent();

        }
    }
}