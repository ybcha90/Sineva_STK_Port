﻿namespace Sineva_STK_Port
{
    partial class FormCurrentAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGView_CurrentAlarm = new System.Windows.Forms.DataGridView();
            this.Btn_AlarmExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_CurrentAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // dGView_CurrentAlarm
            // 
            this.dGView_CurrentAlarm.AllowUserToAddRows = false;
            this.dGView_CurrentAlarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGView_CurrentAlarm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGView_CurrentAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView_CurrentAlarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGView_CurrentAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView_CurrentAlarm.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGView_CurrentAlarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGView_CurrentAlarm.GridColor = System.Drawing.SystemColors.Control;
            this.dGView_CurrentAlarm.Location = new System.Drawing.Point(0, 0);
            this.dGView_CurrentAlarm.Name = "dGView_CurrentAlarm";
            this.dGView_CurrentAlarm.ReadOnly = true;
            this.dGView_CurrentAlarm.RowHeadersVisible = false;
            this.dGView_CurrentAlarm.RowTemplate.Height = 25;
            this.dGView_CurrentAlarm.Size = new System.Drawing.Size(454, 190);
            this.dGView_CurrentAlarm.TabIndex = 0;
            // 
            // Btn_AlarmExit
            // 
            this.Btn_AlarmExit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_AlarmExit.Location = new System.Drawing.Point(166, 196);
            this.Btn_AlarmExit.Name = "Btn_AlarmExit";
            this.Btn_AlarmExit.Size = new System.Drawing.Size(115, 55);
            this.Btn_AlarmExit.TabIndex = 1;
            this.Btn_AlarmExit.Text = "Exit";
            this.Btn_AlarmExit.UseVisualStyleBackColor = true;
            this.Btn_AlarmExit.Click += new System.EventHandler(this.Btn_AlarmExit_Click);
            // 
            // FormCurrentAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 255);
            this.Controls.Add(this.Btn_AlarmExit);
            this.Controls.Add(this.dGView_CurrentAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCurrentAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.FormCurrentAlarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGView_CurrentAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dGView_CurrentAlarm;
        private Button Btn_AlarmExit;
    }
}