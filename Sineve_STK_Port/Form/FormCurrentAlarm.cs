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
    public partial class FormCurrentAlarm : Form
    {
        public FormCurrentAlarm()
        {
            InitializeComponent();
        }

        private void FormCurrentAlarm_Load(object sender, EventArgs e)
        {
            //DataTable Portinfo = DBManager.Instance.GetCurrentAlarm();
        }
    }
}
