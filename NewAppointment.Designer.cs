namespace AppSys_Alpha
{
    partial class NewAppointment
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.tbDoctorid = new System.Windows.Forms.TextBox();
            this.mcalDate = new System.Windows.Forms.MonthCalendar();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbPatientName = new System.Windows.Forms.Label();
            this.lbDoctorId = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbDurationMins = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbAppType = new System.Windows.Forms.Label();
            this.tbRoomAllo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNurseReq = new System.Windows.Forms.CheckBox();
            this.lbNurseId = new System.Windows.Forms.Label();
            this.tbNurseId = new System.Windows.Forms.TextBox();
            this.cbVideoCall = new System.Windows.Forms.CheckBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gpbVirtual = new System.Windows.Forms.GroupBox();
            this.gpbInperson = new System.Windows.Forms.GroupBox();
            this.cbVirtual = new System.Windows.Forms.CheckBox();
            this.cbInperson = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.gbApp = new System.Windows.Forms.GroupBox();
            this.gbAppDate = new System.Windows.Forms.GroupBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.gpbVirtual.SuspendLayout();
            this.gpbInperson.SuspendLayout();
            this.gbApp.SuspendLayout();
            this.gbAppDate.SuspendLayout();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 28);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 23);
            this.tbId.TabIndex = 0;
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(100, 66);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(100, 23);
            this.tbPatientName.TabIndex = 0;
            // 
            // tbDoctorid
            // 
            this.tbDoctorid.Location = new System.Drawing.Point(100, 107);
            this.tbDoctorid.Name = "tbDoctorid";
            this.tbDoctorid.Size = new System.Drawing.Size(100, 23);
            this.tbDoctorid.TabIndex = 1;
            // 
            // mcalDate
            // 
            this.mcalDate.Location = new System.Drawing.Point(10, 50);
            this.mcalDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.mcalDate.Name = "mcalDate";
            this.mcalDate.ShowToday = false;
            this.mcalDate.ShowTodayCircle = false;
            this.mcalDate.TabIndex = 2;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(100, 228);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(59, 23);
            this.dtpTime.TabIndex = 5;
            this.dtpTime.Value = new System.DateTime(2023, 1, 15, 0, 0, 0, 0);
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(100, 188);
            this.numDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(39, 23);
            this.numDuration.TabIndex = 6;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(100, 148);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(100, 23);
            this.tbTelephone.TabIndex = 7;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(73, 31);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 15);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "ID:";
            // 
            // lbPatientName
            // 
            this.lbPatientName.AutoSize = true;
            this.lbPatientName.Location = new System.Drawing.Point(12, 69);
            this.lbPatientName.Name = "lbPatientName";
            this.lbPatientName.Size = new System.Drawing.Size(82, 15);
            this.lbPatientName.TabIndex = 9;
            this.lbPatientName.Text = "Patient Name:";
            // 
            // lbDoctorId
            // 
            this.lbDoctorId.AutoSize = true;
            this.lbDoctorId.Location = new System.Drawing.Point(34, 107);
            this.lbDoctorId.Name = "lbDoctorId";
            this.lbDoctorId.Size = new System.Drawing.Size(60, 15);
            this.lbDoctorId.TabIndex = 10;
            this.lbDoctorId.Text = "Doctor ID:";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Location = new System.Drawing.Point(30, 148);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(64, 15);
            this.lbTelephone.TabIndex = 11;
            this.lbTelephone.Text = "Telephone:";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Location = new System.Drawing.Point(38, 190);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(56, 15);
            this.lbDuration.TabIndex = 12;
            this.lbDuration.Text = "Duration:";
            // 
            // lbDurationMins
            // 
            this.lbDurationMins.AutoSize = true;
            this.lbDurationMins.Location = new System.Drawing.Point(145, 190);
            this.lbDurationMins.Name = "lbDurationMins";
            this.lbDurationMins.Size = new System.Drawing.Size(50, 15);
            this.lbDurationMins.TabIndex = 13;
            this.lbDurationMins.Text = "minutes";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(58, 228);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(36, 15);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "Time:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(72, 26);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(108, 15);
            this.lbDate.TabIndex = 15;
            this.lbDate.Text = "Appointment Date:";
            // 
            // lbAppType
            // 
            this.lbAppType.AutoSize = true;
            this.lbAppType.Location = new System.Drawing.Point(6, 31);
            this.lbAppType.Name = "lbAppType";
            this.lbAppType.Size = new System.Drawing.Size(108, 15);
            this.lbAppType.TabIndex = 17;
            this.lbAppType.Text = "Appointment Type:";
            // 
            // tbRoomAllo
            // 
            this.tbRoomAllo.Location = new System.Drawing.Point(110, 30);
            this.tbRoomAllo.Name = "tbRoomAllo";
            this.tbRoomAllo.Size = new System.Drawing.Size(100, 23);
            this.tbRoomAllo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Room Allocated:";
            // 
            // cbNurseReq
            // 
            this.cbNurseReq.AutoSize = true;
            this.cbNurseReq.Location = new System.Drawing.Point(9, 75);
            this.cbNurseReq.Name = "cbNurseReq";
            this.cbNurseReq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbNurseReq.Size = new System.Drawing.Size(107, 19);
            this.cbNurseReq.TabIndex = 20;
            this.cbNurseReq.Text = "Nurse Required";
            this.cbNurseReq.UseVisualStyleBackColor = true;
            this.cbNurseReq.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbNurseReq_MouseUp);
            // 
            // lbNurseId
            // 
            this.lbNurseId.AutoSize = true;
            this.lbNurseId.Location = new System.Drawing.Point(38, 119);
            this.lbNurseId.Name = "lbNurseId";
            this.lbNurseId.Size = new System.Drawing.Size(55, 15);
            this.lbNurseId.TabIndex = 21;
            this.lbNurseId.Text = "Nurse ID:";
            this.lbNurseId.Visible = false;
            // 
            // tbNurseId
            // 
            this.tbNurseId.Location = new System.Drawing.Point(99, 116);
            this.tbNurseId.Name = "tbNurseId";
            this.tbNurseId.Size = new System.Drawing.Size(100, 23);
            this.tbNurseId.TabIndex = 22;
            this.tbNurseId.Visible = false;
            // 
            // cbVideoCall
            // 
            this.cbVideoCall.AutoSize = true;
            this.cbVideoCall.Location = new System.Drawing.Point(18, 28);
            this.cbVideoCall.Name = "cbVideoCall";
            this.cbVideoCall.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbVideoCall.Size = new System.Drawing.Size(79, 19);
            this.cbVideoCall.TabIndex = 23;
            this.cbVideoCall.Text = "Video Call";
            this.cbVideoCall.UseVisualStyleBackColor = true;
            this.cbVideoCall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbVideoCall_MouseUp);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(94, 53);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 23);
            this.tbEmail.TabIndex = 24;
            this.tbEmail.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(4, 56);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(84, 15);
            this.lbEmail.TabIndex = 25;
            this.lbEmail.Text = "Email Address:";
            this.lbEmail.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(549, 442);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 66);
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gpbVirtual
            // 
            this.gpbVirtual.Controls.Add(this.tbEmail);
            this.gpbVirtual.Controls.Add(this.cbVideoCall);
            this.gpbVirtual.Controls.Add(this.lbEmail);
            this.gpbVirtual.Location = new System.Drawing.Point(24, 77);
            this.gpbVirtual.Name = "gpbVirtual";
            this.gpbVirtual.Size = new System.Drawing.Size(230, 100);
            this.gpbVirtual.TabIndex = 27;
            this.gpbVirtual.TabStop = false;
            this.gpbVirtual.Text = "Virtual Appointment";
            this.gpbVirtual.Visible = false;
            // 
            // gpbInperson
            // 
            this.gpbInperson.Controls.Add(this.tbRoomAllo);
            this.gpbInperson.Controls.Add(this.label1);
            this.gpbInperson.Controls.Add(this.cbNurseReq);
            this.gpbInperson.Controls.Add(this.tbNurseId);
            this.gpbInperson.Controls.Add(this.lbNurseId);
            this.gpbInperson.Location = new System.Drawing.Point(23, 77);
            this.gpbInperson.Name = "gpbInperson";
            this.gpbInperson.Size = new System.Drawing.Size(266, 157);
            this.gpbInperson.TabIndex = 28;
            this.gpbInperson.TabStop = false;
            this.gpbInperson.Text = "Inperson Appointment";
            this.gpbInperson.Visible = false;
            // 
            // cbVirtual
            // 
            this.cbVirtual.AutoSize = true;
            this.cbVirtual.Location = new System.Drawing.Point(120, 18);
            this.cbVirtual.Name = "cbVirtual";
            this.cbVirtual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbVirtual.Size = new System.Drawing.Size(134, 19);
            this.cbVirtual.TabIndex = 29;
            this.cbVirtual.Text = "Virtual Appointment";
            this.cbVirtual.UseVisualStyleBackColor = true;
            this.cbVirtual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbVirtual_MouseUp);
            // 
            // cbInperson
            // 
            this.cbInperson.AutoSize = true;
            this.cbInperson.Location = new System.Drawing.Point(120, 43);
            this.cbInperson.Name = "cbInperson";
            this.cbInperson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbInperson.Size = new System.Drawing.Size(146, 19);
            this.cbInperson.TabIndex = 30;
            this.cbInperson.Text = "Inperson Appointment";
            this.cbInperson.UseVisualStyleBackColor = true;
            this.cbInperson.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbInperson_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(727, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 66);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 37);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Sunderland Area NHS Trust";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTitle.Location = new System.Drawing.Point(267, 112);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(281, 28);
            this.lblSubTitle.TabIndex = 33;
            this.lblSubTitle.Text = "New Appointment Information";
            // 
            // gbApp
            // 
            this.gbApp.Controls.Add(this.lbId);
            this.gbApp.Controls.Add(this.tbId);
            this.gbApp.Controls.Add(this.tbPatientName);
            this.gbApp.Controls.Add(this.tbDoctorid);
            this.gbApp.Controls.Add(this.dtpTime);
            this.gbApp.Controls.Add(this.numDuration);
            this.gbApp.Controls.Add(this.tbTelephone);
            this.gbApp.Controls.Add(this.lbPatientName);
            this.gbApp.Controls.Add(this.lbDoctorId);
            this.gbApp.Controls.Add(this.lbTelephone);
            this.gbApp.Controls.Add(this.lbDuration);
            this.gbApp.Controls.Add(this.lbTime);
            this.gbApp.Controls.Add(this.lbDurationMins);
            this.gbApp.Location = new System.Drawing.Point(12, 162);
            this.gbApp.Name = "gbApp";
            this.gbApp.Size = new System.Drawing.Size(224, 264);
            this.gbApp.TabIndex = 34;
            this.gbApp.TabStop = false;
            this.gbApp.Text = "Basic Info";
            // 
            // gbAppDate
            // 
            this.gbAppDate.Controls.Add(this.lbDate);
            this.gbAppDate.Controls.Add(this.mcalDate);
            this.gbAppDate.Location = new System.Drawing.Point(267, 162);
            this.gbAppDate.Name = "gbAppDate";
            this.gbAppDate.Size = new System.Drawing.Size(250, 225);
            this.gbAppDate.TabIndex = 35;
            this.gbAppDate.TabStop = false;
            this.gbAppDate.Text = "Date Select";
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.lbAppType);
            this.gbType.Controls.Add(this.gpbVirtual);
            this.gbType.Controls.Add(this.gpbInperson);
            this.gbType.Controls.Add(this.cbVirtual);
            this.gbType.Controls.Add(this.cbInperson);
            this.gbType.Location = new System.Drawing.Point(543, 162);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(313, 242);
            this.gbType.TabIndex = 36;
            this.gbType.TabStop = false;
            this.gbType.Text = "Appointment Select";
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 520);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.gbAppDate);
            this.Controls.Add(this.gbApp);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Name = "NewAppointment";
            this.Text = "NewAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.gpbVirtual.ResumeLayout(false);
            this.gpbVirtual.PerformLayout();
            this.gpbInperson.ResumeLayout(false);
            this.gpbInperson.PerformLayout();
            this.gbApp.ResumeLayout(false);
            this.gbApp.PerformLayout();
            this.gbAppDate.ResumeLayout(false);
            this.gbAppDate.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.TextBox tbDoctorid;
        private System.Windows.Forms.MonthCalendar mcalDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPatientName;
        private System.Windows.Forms.Label lbDoctorId;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbDurationMins;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbAppType;
        private System.Windows.Forms.TextBox tbRoomAllo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNurseReq;
        private System.Windows.Forms.Label lbNurseId;
        private System.Windows.Forms.TextBox tbNurseId;
        private System.Windows.Forms.CheckBox cbVideoCall;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gpbVirtual;
        private System.Windows.Forms.GroupBox gpbInperson;
        private System.Windows.Forms.CheckBox cbVirtual;
        private System.Windows.Forms.CheckBox cbInperson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox gbApp;
        private System.Windows.Forms.GroupBox gbAppDate;
        private System.Windows.Forms.GroupBox gbType;
    }
}