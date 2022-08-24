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

        DBManager dbManager = new DBManager();
        public FormHistory()
        {
            InitializeComponent();

        }
        private void dataGridView(DataGridView dataGridView)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.RowTemplate.ReadOnly = true;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Carrier Log 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CarrierSearch_Click(object sender, EventArgs e)
        {
            dataGridView(gridCarrierHistory);

            string strSQL = string.Format(@"select * from CarrierHistory 
                                               where InstallTime between '{0}' and '{1}'
                                               and RemovedTime between '{0}' and '{1}'
                                               and CarrierID like '%{2}%'",
                 CarrierStartDateTimePicker.Value, CarrierEndDateTimePicker.Value, txtCarrierID.Text);

            DataTable dt = dbManager.GetHistoryDataBase(strSQL);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridCarrierHistory.DataSource = dt;

            gridCarrierHistory.Columns["CarrierID"].Width = 120;
            gridCarrierHistory.Columns["CarrierLoc"].Width = 120;
            gridCarrierHistory.Columns["CarrierState"].Width = 120;
            gridCarrierHistory.Columns["InstallTime"].Width = 200;
            gridCarrierHistory.Columns["RemovedTime"].Width = 200;
        }
        /// <summary>
        /// System Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SystemLogSearch_Click(object sender, EventArgs e)
        {
            dataGridView(gridSystemHistory);

            string strSQL = string.Format(@"select * from SystemLog 
                                               where DateTime between '{0}' and '{1}'
                                               and Type like '%{2}%'
                                               and Information like '%{3}%'",
            SystemStartDateTimePicker.Value, SystemEndDateTimePicker.Value, txtSystemLogType.Text, txtSystemLogInfo.Text);

            DataTable dt = dbManager.GetHistoryDataBase(strSQL);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridSystemHistory.DataSource = dt;

            gridSystemHistory.Columns["DateTime"].Width = 200;
            gridSystemHistory.Columns["Type"].Width = 200;
            gridSystemHistory.Columns["Information"].Width = 300;
        }
        /// <summary>
        /// Alarm History
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AlarmSearch_Click(object sender, EventArgs e)
        {
            dataGridView(gridAlarmHistory);
            string strSQL = string.Format(@"select * from AlarmHistory 
                                               where SetTime between '{0}' and '{1}'
                                               and ClearTime between '{0}' and '{1}'
                                               and ID like '%{2}%'
                                               and AlarmText like '%{3}%'
                                               and CarrierID like '%{4}%'",
            AlarmStartDateTimePicker.Value, AlarmEndDateTimePicker.Value, txtAlarmID.Text, 
            txtAlarmText.Text, txtAlarmCarrierID.Text);

            DataTable dt = dbManager.GetHistoryDataBase(strSQL);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridAlarmHistory.DataSource = dt;

            gridAlarmHistory.Columns["SetTime"].Width = 160;
            gridAlarmHistory.Columns["ClearTime"].Width = 160;
        }

        /// <summary>
        /// PIO Hand Shaking Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_PIOSearch_Click(object sender, EventArgs e)
        {
            dataGridView(gridPIOHistory);
            string strSQL = string.Format(@"select * from PIOHandShakingLog 
                                               where DateTime between '{0}' and '{1}'
                                               and CarrierID like '%{2}%'
                                               and Signal like '%{3}%'",
            PIOStartDateTimePicker.Value, PIOEndDateTimePicker.Value, txtPIOCarrierID.Text, txtPIOSignal.Text);

            DataTable dt = dbManager.GetHistoryDataBase(strSQL);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridPIOHistory.DataSource = dt;

            gridPIOHistory.Columns["DateTime"].Width = 200;
        }
            
        /// <summary>
        /// Operator Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OperSearch_Click(object sender, EventArgs e)
        {
            dataGridView(gridOperHistory);
            string strSQL = string.Format(@"select * from OperatorLog 
                                               where DateTime between '{0}' and '{1}'
                                               and UserID like '%{2}%'
                                               and Information like '%{3}%'",
            OperStartDateTimePicker.Value, OperEndDateTimePicker.Value, txtOperUserID.Text, txtOperInfo.Text);

            DataTable dt = dbManager.GetHistoryDataBase(strSQL);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridOperHistory.DataSource = dt;

            gridOperHistory.Columns["DateTime"].Width = 200;
            gridOperHistory.Columns["Information"].Width = 400;
        }

        /// <summary>
        /// SCS Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SCSSearch_Click(object sender, EventArgs e)
        {
            dataGridView(gridSCSHistory);
            string strSQL = string.Format(@"select * from SCSLog 
                                               where DateTime between '{0}' and '{1}'
                                               and Information like '%{2}%'",
            SCSStartDateTimePicker.Value, SCSEndDateTimePicker.Value, txtSCSLogInfo.Text);

            DataTable dt = dbManager.GetHistoryDataBase(strSQL);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridSCSHistory.DataSource = dt;

            gridSCSHistory.Columns["DateTime"].Width = 200;
            gridSCSHistory.Columns["Information"].Width = 400;
        }
    }
}
