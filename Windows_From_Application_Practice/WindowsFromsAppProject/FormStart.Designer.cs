
namespace WindowsFromsAppProject
{
    partial class FormStart
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnGrad = new System.Windows.Forms.RadioButton();
            this.rbtnUnderGrad = new System.Windows.Forms.RadioButton();
            this.dtpDateOFBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPriview = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDateOFBirth = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsernameOutput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPriview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.btnShow);
            this.pnlInfo.Controls.Add(this.panel2);
            this.pnlInfo.Controls.Add(this.dtpDateOFBirth);
            this.pnlInfo.Controls.Add(this.cmbDepartment);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.txtPassword);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.txtUsername);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(320, 420);
            this.pnlInfo.TabIndex = 0;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(228, 306);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnGrad);
            this.panel2.Controls.Add(this.rbtnUnderGrad);
            this.panel2.Location = new System.Drawing.Point(128, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 43);
            this.panel2.TabIndex = 1;
            // 
            // rbtnGrad
            // 
            this.rbtnGrad.AutoSize = true;
            this.rbtnGrad.Location = new System.Drawing.Point(3, 23);
            this.rbtnGrad.Name = "rbtnGrad";
            this.rbtnGrad.Size = new System.Drawing.Size(69, 17);
            this.rbtnGrad.TabIndex = 15;
            this.rbtnGrad.TabStop = true;
            this.rbtnGrad.Text = "Graduate";
            this.rbtnGrad.UseVisualStyleBackColor = true;
            // 
            // rbtnUnderGrad
            // 
            this.rbtnUnderGrad.AutoSize = true;
            this.rbtnUnderGrad.Location = new System.Drawing.Point(3, 3);
            this.rbtnUnderGrad.Name = "rbtnUnderGrad";
            this.rbtnUnderGrad.Size = new System.Drawing.Size(101, 17);
            this.rbtnUnderGrad.TabIndex = 14;
            this.rbtnUnderGrad.TabStop = true;
            this.rbtnUnderGrad.Text = "Under Graduate";
            this.rbtnUnderGrad.UseVisualStyleBackColor = true;
            // 
            // dtpDateOFBirth
            // 
            this.dtpDateOFBirth.CustomFormat = "dd-MM-yyyy";
            this.dtpDateOFBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOFBirth.Location = new System.Drawing.Point(133, 145);
            this.dtpDateOFBirth.Name = "dtpDateOFBirth";
            this.dtpDateOFBirth.Size = new System.Drawing.Size(172, 20);
            this.dtpDateOFBirth.TabIndex = 13;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "EEE",
            "CSE",
            "PE",
            "BBA",
            "ENG"});
            this.cmbDepartment.Location = new System.Drawing.Point(128, 179);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(176, 21);
            this.cmbDepartment.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Program";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";
            // 
            // pnlPriview
            // 
            this.pnlPriview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPriview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPriview.Controls.Add(this.btnClear);
            this.pnlPriview.Controls.Add(this.lblProgram);
            this.pnlPriview.Controls.Add(this.lblDepartment);
            this.pnlPriview.Controls.Add(this.lblDateOFBirth);
            this.pnlPriview.Controls.Add(this.lblPassword);
            this.pnlPriview.Controls.Add(this.label7);
            this.pnlPriview.Controls.Add(this.label8);
            this.pnlPriview.Controls.Add(this.label9);
            this.pnlPriview.Controls.Add(this.label10);
            this.pnlPriview.Controls.Add(this.txtUsernameOutput);
            this.pnlPriview.Controls.Add(this.label11);
            this.pnlPriview.Controls.Add(this.label12);
            this.pnlPriview.Location = new System.Drawing.Point(352, 12);
            this.pnlPriview.Name = "pnlPriview";
            this.pnlPriview.Size = new System.Drawing.Size(320, 420);
            this.pnlPriview.TabIndex = 1;
            this.pnlPriview.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(229, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(154, 215);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(75, 22);
            this.lblProgram.TabIndex = 15;
            this.lblProgram.Text = "oProgram";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(154, 179);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(98, 22);
            this.lblDepartment.TabIndex = 14;
            this.lblDepartment.Text = "oDepartment";
            // 
            // lblDateOFBirth
            // 
            this.lblDateOFBirth.AutoSize = true;
            this.lblDateOFBirth.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOFBirth.Location = new System.Drawing.Point(154, 145);
            this.lblDateOFBirth.Name = "lblDateOFBirth";
            this.lblDateOFBirth.Size = new System.Drawing.Size(110, 22);
            this.lblDateOFBirth.TabIndex = 13;
            this.lblDateOFBirth.Text = "oDate of Birth";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(154, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 22);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "oPassword";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Program";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Date of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Password";
            // 
            // txtUsernameOutput
            // 
            this.txtUsernameOutput.Location = new System.Drawing.Point(128, 71);
            this.txtUsernameOutput.Name = "txtUsernameOutput";
            this.txtUsernameOutput.Size = new System.Drawing.Size(177, 20);
            this.txtUsernameOutput.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(70, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 37);
            this.label12.TabIndex = 0;
            this.label12.Text = "Preview";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnlPriview);
            this.Controls.Add(this.pnlInfo);
            this.Name = "FormStart";
            this.Text = "Start";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPriview.ResumeLayout(false);
            this.pnlPriview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DateTimePicker dtpDateOFBirth;
        private System.Windows.Forms.RadioButton rbtnGrad;
        private System.Windows.Forms.RadioButton rbtnUnderGrad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPriview;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsernameOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDateOFBirth;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
    }
}