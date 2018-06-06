namespace AccountingApp
{
    partial class Adauga_Angajat
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
            this.groupBoxEmployeeStatus = new System.Windows.Forms.GroupBox();
            this._radioEmployeeHoliday = new System.Windows.Forms.RadioButton();
            this._radioEmployeeInactive = new System.Windows.Forms.RadioButton();
            this._radioEmployeeActive = new System.Windows.Forms.RadioButton();
            this.groupBoxEmployeeFnc = new System.Windows.Forms.GroupBox();
            this._radioEmployeeDesk = new System.Windows.Forms.RadioButton();
            this._radioEmployeeAgent = new System.Windows.Forms.RadioButton();
            this._radioEmployeePersonnel = new System.Windows.Forms.RadioButton();
            this._txtEmployeeId = new System.Windows.Forms.TextBox();
            this._txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEmployeeStatus.SuspendLayout();
            this.groupBoxEmployeeFnc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeStatus
            // 
            this.groupBoxEmployeeStatus.Controls.Add(this._radioEmployeeHoliday);
            this.groupBoxEmployeeStatus.Controls.Add(this._radioEmployeeInactive);
            this.groupBoxEmployeeStatus.Controls.Add(this._radioEmployeeActive);
            this.groupBoxEmployeeStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEmployeeStatus.Location = new System.Drawing.Point(612, 29);
            this.groupBoxEmployeeStatus.Name = "groupBoxEmployeeStatus";
            this.groupBoxEmployeeStatus.Size = new System.Drawing.Size(283, 62);
            this.groupBoxEmployeeStatus.TabIndex = 8;
            this.groupBoxEmployeeStatus.TabStop = false;
            this.groupBoxEmployeeStatus.Text = "Status:";
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
            // groupBoxEmployeeFnc
            // 
            this.groupBoxEmployeeFnc.Controls.Add(this._radioEmployeeDesk);
            this.groupBoxEmployeeFnc.Controls.Add(this._radioEmployeeAgent);
            this.groupBoxEmployeeFnc.Controls.Add(this._radioEmployeePersonnel);
            this.groupBoxEmployeeFnc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEmployeeFnc.Location = new System.Drawing.Point(359, 29);
            this.groupBoxEmployeeFnc.Name = "groupBoxEmployeeFnc";
            this.groupBoxEmployeeFnc.Size = new System.Drawing.Size(247, 62);
            this.groupBoxEmployeeFnc.TabIndex = 9;
            this.groupBoxEmployeeFnc.TabStop = false;
            this.groupBoxEmployeeFnc.Text = "Functie:";
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
            // 
            // _txtEmployeeId
            // 
            this._txtEmployeeId.Location = new System.Drawing.Point(147, 68);
            this._txtEmployeeId.Name = "_txtEmployeeId";
            this._txtEmployeeId.Size = new System.Drawing.Size(200, 20);
            this._txtEmployeeId.TabIndex = 6;
            // 
            // _txtEmployeeName
            // 
            this._txtEmployeeName.Location = new System.Drawing.Point(147, 39);
            this._txtEmployeeName.Name = "_txtEmployeeName";
            this._txtEmployeeName.Size = new System.Drawing.Size(200, 20);
            this._txtEmployeeName.TabIndex = 7;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeId.Location = new System.Drawing.Point(35, 68);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(105, 23);
            this.lblEmployeeId.TabIndex = 4;
            this.lblEmployeeId.Text = "ID Angajat:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeName.Location = new System.Drawing.Point(35, 37);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(72, 23);
            this.lblEmployeeName.TabIndex = 5;
            this.lblEmployeeName.Text = "Nume: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Articole:";
            // 
            // Adauga_Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxEmployeeStatus);
            this.Controls.Add(this.groupBoxEmployeeFnc);
            this.Controls.Add(this._txtEmployeeId);
            this.Controls.Add(this._txtEmployeeName);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblEmployeeName);
            this.Name = "Adauga_Angajat";
            this.Text = "Adauga Angajat";
            this.groupBoxEmployeeStatus.ResumeLayout(false);
            this.groupBoxEmployeeStatus.PerformLayout();
            this.groupBoxEmployeeFnc.ResumeLayout(false);
            this.groupBoxEmployeeFnc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployeeStatus;
        private System.Windows.Forms.RadioButton _radioEmployeeHoliday;
        private System.Windows.Forms.RadioButton _radioEmployeeInactive;
        private System.Windows.Forms.RadioButton _radioEmployeeActive;
        private System.Windows.Forms.GroupBox groupBoxEmployeeFnc;
        private System.Windows.Forms.RadioButton _radioEmployeeDesk;
        private System.Windows.Forms.RadioButton _radioEmployeeAgent;
        private System.Windows.Forms.RadioButton _radioEmployeePersonnel;
        private System.Windows.Forms.TextBox _txtEmployeeId;
        private System.Windows.Forms.TextBox _txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label1;
    }
}