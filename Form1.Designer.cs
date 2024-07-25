
namespace AppSys_Alpha
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnViewIn = new System.Windows.Forms.Button();
            this.btnViewVir = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(63, 296);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(139, 75);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "View All Appointments";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnViewIn
            // 
            this.btnViewIn.Location = new System.Drawing.Point(225, 296);
            this.btnViewIn.Name = "btnViewIn";
            this.btnViewIn.Size = new System.Drawing.Size(139, 75);
            this.btnViewIn.TabIndex = 1;
            this.btnViewIn.Text = "View In Person Appointments";
            this.btnViewIn.UseVisualStyleBackColor = true;
            this.btnViewIn.Click += new System.EventHandler(this.btnViewIn_Click);
            // 
            // btnViewVir
            // 
            this.btnViewVir.Location = new System.Drawing.Point(385, 296);
            this.btnViewVir.Name = "btnViewVir";
            this.btnViewVir.Size = new System.Drawing.Size(139, 75);
            this.btnViewVir.TabIndex = 2;
            this.btnViewVir.Text = "View Virtual Appointments";
            this.btnViewVir.UseVisualStyleBackColor = true;
            this.btnViewVir.Click += new System.EventHandler(this.btnViewVir_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(121, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Sunderland Area NHS Trust";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(476, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateApp
            // 
            this.btnCreateApp.Location = new System.Drawing.Point(63, 191);
            this.btnCreateApp.Name = "btnCreateApp";
            this.btnCreateApp.Size = new System.Drawing.Size(139, 78);
            this.btnCreateApp.TabIndex = 5;
            this.btnCreateApp.Text = "Create New Appointment";
            this.btnCreateApp.UseVisualStyleBackColor = true;
            this.btnCreateApp.Click += new System.EventHandler(this.btnCreateApp_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.btnCreateApp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnViewVir);
            this.Controls.Add(this.btnViewIn);
            this.Controls.Add(this.btnViewAll);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnViewIn;
        private System.Windows.Forms.Button btnViewVir;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateApp;
    }
}

