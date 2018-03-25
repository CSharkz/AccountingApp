namespace AccountingApp
{
    partial class AdminAccountingAppForm
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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.seeEmployeeTab = new System.Windows.Forms.TabPage();
            this.editDeleteEmployeeTab = new System.Windows.Forms.TabPage();
            this.seeItemsTab = new System.Windows.Forms.TabPage();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this._txtEmployeeName = new System.Windows.Forms.TextBox();
            this._txtEmployeeId = new System.Windows.Forms.TextBox();
            this._radioEmployeeAgent = new System.Windows.Forms.RadioButton();
            this._radioEmployeeDesk = new System.Windows.Forms.RadioButton();
            this._radioEmployeePersonnel = new System.Windows.Forms.RadioButton();
            this._radioEmployeeActive = new System.Windows.Forms.RadioButton();
            this._radioEmployeeHoliday = new System.Windows.Forms.RadioButton();
            this._radioEmployeeInactive = new System.Windows.Forms.RadioButton();
            this.groupBoxEmployeeFnc = new System.Windows.Forms.GroupBox();
            this.groupBoxEmployeeStatus = new System.Windows.Forms.GroupBox();
            this.adminTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxEmployeeFnc.SuspendLayout();
            this.groupBoxEmployeeStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.tabPage1);
            this.adminTabControl.Controls.Add(this.seeEmployeeTab);
            this.adminTabControl.Controls.Add(this.editDeleteEmployeeTab);
            this.adminTabControl.Controls.Add(this.seeItemsTab);
            this.adminTabControl.Location = new System.Drawing.Point(-2, 1);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(886, 362);
            this.adminTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxEmployeeStatus);
            this.tabPage1.Controls.Add(this.groupBoxEmployeeFnc);
            this.tabPage1.Controls.Add(this._txtEmployeeId);
            this.tabPage1.Controls.Add(this._txtEmployeeName);
            this.tabPage1.Controls.Add(this.lblEmployeeId);
            this.tabPage1.Controls.Add(this.lblEmployeeName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adauga Angajat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 14);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(72, 23);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Nume: ";
            // 
            // seeEmployeeTab
            // 
            this.seeEmployeeTab.Location = new System.Drawing.Point(4, 22);
            this.seeEmployeeTab.Name = "seeEmployeeTab";
            this.seeEmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.seeEmployeeTab.Size = new System.Drawing.Size(581, 336);
            this.seeEmployeeTab.TabIndex = 1;
            this.seeEmployeeTab.Text = "Vezi Angajati";
            this.seeEmployeeTab.UseVisualStyleBackColor = true;
            // 
            // editDeleteEmployeeTab
            // 
            this.editDeleteEmployeeTab.Location = new System.Drawing.Point(4, 22);
            this.editDeleteEmployeeTab.Name = "editDeleteEmployeeTab";
            this.editDeleteEmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.editDeleteEmployeeTab.Size = new System.Drawing.Size(581, 336);
            this.editDeleteEmployeeTab.TabIndex = 2;
            this.editDeleteEmployeeTab.Text = "Modifica/Sterge Angajat";
            this.editDeleteEmployeeTab.UseVisualStyleBackColor = true;
            // 
            // seeItemsTab
            // 
            this.seeItemsTab.Location = new System.Drawing.Point(4, 22);
            this.seeItemsTab.Name = "seeItemsTab";
            this.seeItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.seeItemsTab.Size = new System.Drawing.Size(581, 336);
            this.seeItemsTab.TabIndex = 3;
            this.seeItemsTab.Text = "Vezi Articole";
            this.seeItemsTab.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeId.Location = new System.Drawing.Point(10, 45);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(105, 23);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "ID Angajat:";
            // 
            // _txtEmployeeName
            // 
            this._txtEmployeeName.Location = new System.Drawing.Point(122, 16);
            this._txtEmployeeName.Name = "_txtEmployeeName";
            this._txtEmployeeName.Size = new System.Drawing.Size(200, 20);
            this._txtEmployeeName.TabIndex = 1;
            // 
            // _txtEmployeeId
            // 
            this._txtEmployeeId.Location = new System.Drawing.Point(122, 45);
            this._txtEmployeeId.Name = "_txtEmployeeId";
            this._txtEmployeeId.Size = new System.Drawing.Size(200, 20);
            this._txtEmployeeId.TabIndex = 1;
            // 
            // _radioEmployeeAgent
            // 
            this._radioEmployeeAgent.AutoSize = true;
            this._radioEmployeeAgent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._radioEmployeeAgent.Location = new System.Drawing.Point(6, 33);
            this._radioEmployeeAgent.Name = "_radioEmployeeAgent";
            this._radioEmployeeAgent.Size = new System.Drawing.Size(72, 25);
            this._radioEmployeeAgent.TabIndex = 2;
            this._radioEmployeeAgent.TabStop = true;
            this._radioEmployeeAgent.Text = "Agent";
            this._radioEmployeeAgent.UseVisualStyleBackColor = true;
            this._radioEmployeeAgent.CheckedChanged += new System.EventHandler(this._radioEmployeeAgent_CheckedChanged);
            // 
            // _radioEmployeeDesk
            // 
            this._radioEmployeeDesk.AutoSize = true;
            this._radioEmployeeDesk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._radioEmployeeDesk.Location = new System.Drawing.Point(82, 33);
            this._radioEmployeeDesk.Name = "_radioEmployeeDesk";
            this._radioEmployeeDesk.Size = new System.Drawing.Size(69, 25);
            this._radioEmployeeDesk.TabIndex = 2;
            this._radioEmployeeDesk.TabStop = true;
            this._radioEmployeeDesk.Text = "Birou";
            this._radioEmployeeDesk.UseVisualStyleBackColor = true;
            this._radioEmployeeDesk.CheckedChanged += new System.EventHandler(this._radioEmployeeDesk_CheckedChanged);
            // 
            // _radioEmployeePersonnel
            // 
            this._radioEmployeePersonnel.AutoSize = true;
            this._radioEmployeePersonnel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._radioEmployeePersonnel.Location = new System.Drawing.Point(156, 33);
            this._radioEmployeePersonnel.Name = "_radioEmployeePersonnel";
            this._radioEmployeePersonnel.Size = new System.Drawing.Size(92, 25);
            this._radioEmployeePersonnel.TabIndex = 2;
            this._radioEmployeePersonnel.TabStop = true;
            this._radioEmployeePersonnel.Text = "Personal";
            this._radioEmployeePersonnel.UseVisualStyleBackColor = true;
            this._radioEmployeePersonnel.CheckedChanged += new System.EventHandler(this._radioEmployeePersonnel_CheckedChanged);
            // 
            // _radioEmployeeActive
            // 
            this._radioEmployeeActive.AutoSize = true;
            this._radioEmployeeActive.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._radioEmployeeActive.Location = new System.Drawing.Point(6, 33);
            this._radioEmployeeActive.Name = "_radioEmployeeActive";
            this._radioEmployeeActive.Size = new System.Drawing.Size(68, 25);
            this._radioEmployeeActive.TabIndex = 2;
            this._radioEmployeeActive.TabStop = true;
            this._radioEmployeeActive.Text = "Activ";
            this._radioEmployeeActive.UseVisualStyleBackColor = true;
            // 
            // _radioEmployeeHoliday
            // 
            this._radioEmployeeHoliday.AutoSize = true;
            this._radioEmployeeHoliday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._radioEmployeeHoliday.Location = new System.Drawing.Point(86, 33);
            this._radioEmployeeHoliday.Name = "_radioEmployeeHoliday";
            this._radioEmployeeHoliday.Size = new System.Drawing.Size(100, 25);
            this._radioEmployeeHoliday.TabIndex = 2;
            this._radioEmployeeHoliday.TabStop = true;
            this._radioEmployeeHoliday.Text = "Concediu";
            this._radioEmployeeHoliday.UseVisualStyleBackColor = true;
            // 
            // _radioEmployeeInactive
            // 
            this._radioEmployeeInactive.AutoSize = true;
            this._radioEmployeeInactive.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._radioEmployeeInactive.Location = new System.Drawing.Point(194, 33);
            this._radioEmployeeInactive.Name = "_radioEmployeeInactive";
            this._radioEmployeeInactive.Size = new System.Drawing.Size(78, 25);
            this._radioEmployeeInactive.TabIndex = 2;
            this._radioEmployeeInactive.TabStop = true;
            this._radioEmployeeInactive.Text = "Inactiv";
            this._radioEmployeeInactive.UseVisualStyleBackColor = true;
            // 
            // groupBoxEmployeeFnc
            // 
            this.groupBoxEmployeeFnc.Controls.Add(this._radioEmployeeDesk);
            this.groupBoxEmployeeFnc.Controls.Add(this._radioEmployeeAgent);
            this.groupBoxEmployeeFnc.Controls.Add(this._radioEmployeePersonnel);
            this.groupBoxEmployeeFnc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEmployeeFnc.Location = new System.Drawing.Point(334, 6);
            this.groupBoxEmployeeFnc.Name = "groupBoxEmployeeFnc";
            this.groupBoxEmployeeFnc.Size = new System.Drawing.Size(247, 62);
            this.groupBoxEmployeeFnc.TabIndex = 3;
            this.groupBoxEmployeeFnc.TabStop = false;
            this.groupBoxEmployeeFnc.Text = "Functie:";
            // 
            // groupBoxEmployeeStatus
            // 
            this.groupBoxEmployeeStatus.Controls.Add(this._radioEmployeeHoliday);
            this.groupBoxEmployeeStatus.Controls.Add(this._radioEmployeeInactive);
            this.groupBoxEmployeeStatus.Controls.Add(this._radioEmployeeActive);
            this.groupBoxEmployeeStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEmployeeStatus.Location = new System.Drawing.Point(587, 6);
            this.groupBoxEmployeeStatus.Name = "groupBoxEmployeeStatus";
            this.groupBoxEmployeeStatus.Size = new System.Drawing.Size(283, 62);
            this.groupBoxEmployeeStatus.TabIndex = 3;
            this.groupBoxEmployeeStatus.TabStop = false;
            this.groupBoxEmployeeStatus.Text = "Functie:";
            // 
            // AdminAccountingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.adminTabControl);
            this.Name = "AdminAccountingAppForm";
            this.Text = "Accounting App - ADMIN";
            this.Load += new System.EventHandler(this.AdminAccountingAppForm_Load);
            this.adminTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxEmployeeFnc.ResumeLayout(false);
            this.groupBoxEmployeeFnc.PerformLayout();
            this.groupBoxEmployeeStatus.ResumeLayout(false);
            this.groupBoxEmployeeStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage seeEmployeeTab;
        private System.Windows.Forms.TabPage editDeleteEmployeeTab;
        private System.Windows.Forms.TabPage seeItemsTab;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.RadioButton _radioEmployeeInactive;
        private System.Windows.Forms.RadioButton _radioEmployeeHoliday;
        private System.Windows.Forms.RadioButton _radioEmployeePersonnel;
        private System.Windows.Forms.RadioButton _radioEmployeeActive;
        private System.Windows.Forms.RadioButton _radioEmployeeDesk;
        private System.Windows.Forms.RadioButton _radioEmployeeAgent;
        private System.Windows.Forms.TextBox _txtEmployeeId;
        private System.Windows.Forms.TextBox _txtEmployeeName;
        private System.Windows.Forms.GroupBox groupBoxEmployeeFnc;
        private System.Windows.Forms.GroupBox groupBoxEmployeeStatus;
    }
}