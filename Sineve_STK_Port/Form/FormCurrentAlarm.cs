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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            GetAlarmData(); 
        }
        private void GetAlarmData()
        {
            DataTable GetAlarminfo = DBManager.Instance.GetCurrentAlarm();
            DGView_CurrentAlarm.DataSource = GetAlarminfo;
            //return Portinfo;
        }

        private void Btn_AlarmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void Form_Paint(object sender, PaintEventArgs e)
        //{
        //    Rectangle tang = this.ClientRectangle;                  //获取窗口矩形 为了下面得到窗口的宽高
        //    Graphics g3 = e.Graphics;
        //    Color c3 = Color.FromArgb(46, 204, 113);
        //    Pen p3 = new Pen(c3);
        //    g3.DrawLine(p3, 0, 0, 0, tang.Height - 1);              //在（0，0）和（tang.Width - 1, 0）这两点间画一条直线
        //    g3.DrawLine(p3, 0, tang.Height - 1, tang.Width - 1, tang.Height - 1);   //注意必须减1 不然显示不出来  因为 如果假设窗口的高度是3像素 我们知道（0，0）位置代表 窗口最左上角的像素点  那么最左下角的像素点应该是（0，2） 而不是（0，3） 因为0，1，2 已经三个像素点了
        //    g3.DrawLine(p3, tang.Width - 1, tang.Height - 1, tang.Width - 1, 0);
        //    g3.DrawLine(p3, tang.Width - 1, 0, 0, 0);
        //}

        //private void DGV_Paint(object sender, PaintEventArgs e)
        //{
        //    Rectangle borderRectangle = ((System.Windows.Forms.Control)sender).ClientRectangle;
        //    ControlPaint.DrawBorder(e.Graphics, borderRectangle,
        //                          Color.Black, 2, ButtonBorderStyle.Outset,
        //                          Color.Black, 2, ButtonBorderStyle.Outset,
        //                          Color.Black, 2, ButtonBorderStyle.Outset,
        //                          Color.Black, 2, ButtonBorderStyle.Outset);
        //}
    }
}
