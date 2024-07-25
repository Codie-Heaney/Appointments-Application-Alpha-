namespace AppSys_Alpha
{
    partial class ViewAllAppointmentPage
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
            this.txtAppView = new System.Windows.Forms.TextBox();
            this.cbxAppSelect = new System.Windows.Forms.ComboBox();
            this.btnSelectShow = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAppView
            // 
            this.txtAppView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAppView.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAppView.Location = new System.Drawing.Point(311, 51);
            this.txtAppView.Multiline = true;
            this.txtAppView.Name = "txtAppView";
            this.txtAppView.ReadOnly = true;
            this.txtAppView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAppView.Size = new System.Drawing.Size(303, 332);
            this.txtAppView.TabIndex = 0;
            this.txtAppView.WordWrap = false;
            // 
            // cbxAppSelect
            // 
            this.cbxAppSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAppSelect.FormattingEnabled = true;
            this.cbxAppSelect.Location = new System.Drawing.Point(123, 34);
            this.cbxAppSelect.Name = "cbxAppSelect";
            this.cbxAppSelect.Size = new System.Drawing.Size(121, 23);
            this.cbxAppSelect.TabIndex = 1;
            // 
            // btnSelectShow
            // 
            this.btnSelectShow.Location = new System.Drawing.Point(73, 111);
            this.btnSelectShow.Name = "btnSelectShow";
            this.btnSelectShow.Size = new System.Drawing.Size(100, 23);
            this.btnSelectShow.TabIndex = 2;
            this.btnSelectShow.Text = "Show Selected";
            this.btnSelectShow.UseVisualStyleBackColor = true;
            this.btnSelectShow.Click += new System.EventHandler(this.btnSelectShow_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(73, 140);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 23);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(6, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(111, 19);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Appointment ID:";
            // 
            // grbInput
            // 
            this.grbInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbInput.Controls.Add(this.btnEdit);
            this.grbInput.Controls.Add(this.lblId);
            this.grbInput.Controls.Add(this.cbxAppSelect);
            this.grbInput.Controls.Add(this.btnShowAll);
            this.grbInput.Controls.Add(this.btnSelectShow);
            this.grbInput.Location = new System.Drawing.Point(33, 131);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(257, 187);
            this.grbInput.TabIndex = 5;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(73, 83);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ViewAllAppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.txtAppView);
            this.Name = "ViewAllAppointmentPage";
            this.Text = "View Appointments";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppView;
        private System.Windows.Forms.ComboBox cbxAppSelect;
        private System.Windows.Forms.Button btnSelectShow;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
    }
}