namespace Sineva_STK_Port
{
    partial class FormHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.TabHistory = new System.Windows.Forms.TabControl();
            this.tabPageCarrierLog = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridCarrierHistory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_CarrierSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TabHistory.SuspendLayout();
            this.tabPageCarrierLog.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrierHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabHistory
            // 
            this.TabHistory.Controls.Add(this.tabPageCarrierLog);
            this.TabHistory.Controls.Add(this.tabPage2);
            this.TabHistory.Controls.Add(this.tabPage3);
            this.TabHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHistory.ItemSize = new System.Drawing.Size(100, 50);
            this.TabHistory.Location = new System.Drawing.Point(0, 0);
            this.TabHistory.Name = "TabHistory";
            this.TabHistory.SelectedIndex = 0;
            this.TabHistory.Size = new System.Drawing.Size(1072, 741);
            this.TabHistory.TabIndex = 0;
            // 
            // tabPageCarrierLog
            // 
            this.tabPageCarrierLog.Controls.Add(this.panel2);
            this.tabPageCarrierLog.Controls.Add(this.panel1);
            this.tabPageCarrierLog.Location = new System.Drawing.Point(4, 54);
            this.tabPageCarrierLog.Name = "tabPageCarrierLog";
            this.tabPageCarrierLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCarrierLog.Size = new System.Drawing.Size(1064, 683);
            this.tabPageCarrierLog.TabIndex = 0;
            this.tabPageCarrierLog.Text = "tabPage1";
            this.tabPageCarrierLog.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCarrierHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 677);
            this.panel2.TabIndex = 1;
            // 
            // gridCarrierHistory
            // 
            this.gridCarrierHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarrierHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCarrierHistory.Location = new System.Drawing.Point(0, 0);
            this.gridCarrierHistory.Name = "gridCarrierHistory";
            this.gridCarrierHistory.RowTemplate.Height = 25;
            this.gridCarrierHistory.Size = new System.Drawing.Size(835, 677);
            this.gridCarrierHistory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_CarrierSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(838, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 677);
            this.panel1.TabIndex = 0;
            // 
            // Btn_CarrierSearch
            // 
            this.Btn_CarrierSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_CarrierSearch.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CarrierSearch.Image")));
            this.Btn_CarrierSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CarrierSearch.Location = new System.Drawing.Point(28, 301);
            this.Btn_CarrierSearch.Name = "Btn_CarrierSearch";
            this.Btn_CarrierSearch.Size = new System.Drawing.Size(167, 77);
            this.Btn_CarrierSearch.TabIndex = 6;
            this.Btn_CarrierSearch.Text = "Search";
            this.Btn_CarrierSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CarrierSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_CarrierSearch.UseVisualStyleBackColor = true;
            this.Btn_CarrierSearch.Click += new System.EventHandler(this.Btn_CarrierSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carrier ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date / Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date / Time:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 132);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1064, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 677);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(841, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 677);
            this.panel4.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1064, 713);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 741);
            this.Controls.Add(this.TabHistory);
            this.Name = "FormHistory";
            this.Text = "Form1";
            this.TabHistory.ResumeLayout(false);
            this.tabPageCarrierLog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrierHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabHistory;
        private TabPage tabPageCarrierLog;
        private TabPage tabPage2;
        private Panel panel2;
        private Panel panel1;
        private TabPage tabPage3;
        private Panel panel3;
        private Panel panel4;
        private DataGridView gridCarrierHistory;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button Btn_CarrierSearch;
    }
}