namespace Sineva_STK_Port
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserPW = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEng = new System.Windows.Forms.RadioButton();
            this.rBtnChn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(64, 28);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(123, 23);
            this.txtUserID.TabIndex = 2;
            // 
            // txtUserPW
            // 
            this.txtUserPW.Location = new System.Drawing.Point(289, 28);
            this.txtUserPW.Name = "txtUserPW";
            this.txtUserPW.Size = new System.Drawing.Size(123, 23);
            this.txtUserPW.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 156);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 52);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnEng);
            this.groupBox1.Controls.Add(this.rBtnChn);
            this.groupBox1.Location = new System.Drawing.Point(31, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language: ";
            // 
            // rbtnEng
            // 
            this.rbtnEng.AutoSize = true;
            this.rbtnEng.Checked = true;
            this.rbtnEng.Location = new System.Drawing.Point(62, 28);
            this.rbtnEng.Name = "rbtnEng";
            this.rbtnEng.Size = new System.Drawing.Size(48, 19);
            this.rbtnEng.TabIndex = 10;
            this.rbtnEng.TabStop = true;
            this.rbtnEng.Text = "ENG";
            this.rbtnEng.UseVisualStyleBackColor = true;
            // 
            // rBtnChn
            // 
            this.rBtnChn.AutoSize = true;
            this.rBtnChn.Location = new System.Drawing.Point(201, 28);
            this.rBtnChn.Name = "rBtnChn";
            this.rBtnChn.Size = new System.Drawing.Size(51, 19);
            this.rBtnChn.TabIndex = 9;
            this.rBtnChn.Text = "CHN";
            this.rBtnChn.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtUserPW);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Log In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserID;
        private TextBox txtUserPW;
        private Button btnOK;
        private Button btnCancel;
        private GroupBox groupBox1;
        private RadioButton rbtnEng;
        private RadioButton rBtnChn;
    }
}