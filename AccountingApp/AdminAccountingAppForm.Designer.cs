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
            this.components = new System.ComponentModel.Container();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.dataGVEmployees = new System.Windows.Forms.DataGridView();
            this.angajatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funtieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.dataGVProducts = new System.Windows.Forms.DataGridView();
            this.articolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIntrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valabilitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Furnizor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.tabFurnizori = new System.Windows.Forms.TabPage();
            this.dataGVSuppliers = new System.Windows.Forms.DataGridView();
            this.furnizorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveSuppliers = new System.Windows.Forms.Button();
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.lblSearchSuppliers = new System.Windows.Forms.Label();
            this.angajatiarticoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTabControl.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articoleBindingSource)).BeginInit();
            this.tabFurnizori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiarticoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.tabEmployees);
            this.adminTabControl.Controls.Add(this.tabItems);
            this.adminTabControl.Controls.Add(this.tabFurnizori);
            this.adminTabControl.Location = new System.Drawing.Point(-2, 1);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(886, 424);
            this.adminTabControl.TabIndex = 0;
            this.adminTabControl.SelectedIndexChanged += new System.EventHandler(this.adminTabControl_TabIndexChanged);
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.dataGVEmployees);
            this.tabEmployees.Controls.Add(this.btnDeleteEmployee);
            this.tabEmployees.Controls.Add(this.btnUpdateEmployee);
            this.tabEmployees.Controls.Add(this.btnAddEmployee);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(878, 398);
            this.tabEmployees.TabIndex = 1;
            this.tabEmployees.Text = "Vezi Angajati";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // dataGVEmployees
            // 
            this.dataGVEmployees.AllowUserToAddRows = false;
            this.dataGVEmployees.AllowUserToDeleteRows = false;
            this.dataGVEmployees.AutoGenerateColumns = false;
            this.dataGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.angajatIDDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.funtieDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGVEmployees.DataSource = this.angajatiBindingSource;
            this.dataGVEmployees.Location = new System.Drawing.Point(169, 33);
            this.dataGVEmployees.Name = "dataGVEmployees";
            this.dataGVEmployees.ReadOnly = true;
            this.dataGVEmployees.Size = new System.Drawing.Size(605, 150);
            this.dataGVEmployees.TabIndex = 5;
            // 
            // angajatIDDataGridViewTextBoxColumn
            // 
            this.angajatIDDataGridViewTextBoxColumn.DataPropertyName = "AngajatID";
            this.angajatIDDataGridViewTextBoxColumn.HeaderText = "AngajatID";
            this.angajatIDDataGridViewTextBoxColumn.Name = "angajatIDDataGridViewTextBoxColumn";
            this.angajatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funtieDataGridViewTextBoxColumn
            // 
            this.funtieDataGridViewTextBoxColumn.DataPropertyName = "Funtie";
            this.funtieDataGridViewTextBoxColumn.HeaderText = "Funtie";
            this.funtieDataGridViewTextBoxColumn.Name = "funtieDataGridViewTextBoxColumn";
            this.funtieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataSource = typeof(AccountingApp.Angajati);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(21, 138);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(127, 23);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "Sterge Angajat";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(21, 85);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateEmployee.TabIndex = 3;
            this.btnUpdateEmployee.Text = "Modifica Angajat";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(21, 33);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(127, 23);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Adauga Angajat";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.dataGVProducts);
            this.tabItems.Controls.Add(this.btnSaveProducts);
            this.tabItems.Location = new System.Drawing.Point(4, 22);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(878, 398);
            this.tabItems.TabIndex = 3;
            this.tabItems.Text = "Articole";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // dataGVProducts
            // 
            this.dataGVProducts.AutoGenerateColumns = false;
            this.dataGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articolIDDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn1,
            this.dataIntrareDataGridViewTextBoxColumn,
            this.valabilitateDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.canitateDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.furnizorIDDataGridViewTextBoxColumn1,
            this.Furnizor});
            this.dataGVProducts.DataSource = this.articoleBindingSource;
            this.dataGVProducts.Location = new System.Drawing.Point(3, 64);
            this.dataGVProducts.Name = "dataGVProducts";
            this.dataGVProducts.Size = new System.Drawing.Size(867, 166);
            this.dataGVProducts.TabIndex = 2;
            this.dataGVProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGVProducts_EditingControlShowing);
            // 
            // articolIDDataGridViewTextBoxColumn
            // 
            this.articolIDDataGridViewTextBoxColumn.DataPropertyName = "ArticolID";
            this.articolIDDataGridViewTextBoxColumn.HeaderText = "ArticolID";
            this.articolIDDataGridViewTextBoxColumn.Name = "articolIDDataGridViewTextBoxColumn";
            // 
            // denumireDataGridViewTextBoxColumn1
            // 
            this.denumireDataGridViewTextBoxColumn1.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn1.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn1.Name = "denumireDataGridViewTextBoxColumn1";
            // 
            // dataIntrareDataGridViewTextBoxColumn
            // 
            this.dataIntrareDataGridViewTextBoxColumn.DataPropertyName = "DataIntrare";
            this.dataIntrareDataGridViewTextBoxColumn.HeaderText = "Data Achizitie";
            this.dataIntrareDataGridViewTextBoxColumn.Name = "dataIntrareDataGridViewTextBoxColumn";
            // 
            // valabilitateDataGridViewTextBoxColumn
            // 
            this.valabilitateDataGridViewTextBoxColumn.DataPropertyName = "Valabilitate";
            this.valabilitateDataGridViewTextBoxColumn.HeaderText = "Valabilitate";
            this.valabilitateDataGridViewTextBoxColumn.Name = "valabilitateDataGridViewTextBoxColumn";
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            // 
            // canitateDataGridViewTextBoxColumn
            // 
            this.canitateDataGridViewTextBoxColumn.DataPropertyName = "Canitate";
            this.canitateDataGridViewTextBoxColumn.HeaderText = "Canitate";
            this.canitateDataGridViewTextBoxColumn.Name = "canitateDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // furnizorIDDataGridViewTextBoxColumn1
            // 
            this.furnizorIDDataGridViewTextBoxColumn1.DataPropertyName = "FurnizorID";
            this.furnizorIDDataGridViewTextBoxColumn1.HeaderText = "FurnizorID";
            this.furnizorIDDataGridViewTextBoxColumn1.Name = "furnizorIDDataGridViewTextBoxColumn1";
            this.furnizorIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Furnizor
            // 
            this.Furnizor.HeaderText = "Furnizori";
            this.Furnizor.Name = "Furnizor";
            // 
            // articoleBindingSource
            // 
            this.articoleBindingSource.DataSource = typeof(AccountingApp.Articole);
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Location = new System.Drawing.Point(31, 6);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(115, 52);
            this.btnSaveProducts.TabIndex = 1;
            this.btnSaveProducts.Text = "Salveaza";
            this.btnSaveProducts.UseVisualStyleBackColor = true;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // tabFurnizori
            // 
            this.tabFurnizori.Controls.Add(this.dataGVSuppliers);
            this.tabFurnizori.Controls.Add(this.btnSaveSuppliers);
            this.tabFurnizori.Controls.Add(this.txtSearchSuppliers);
            this.tabFurnizori.Controls.Add(this.lblSearchSuppliers);
            this.tabFurnizori.Location = new System.Drawing.Point(4, 22);
            this.tabFurnizori.Name = "tabFurnizori";
            this.tabFurnizori.Padding = new System.Windows.Forms.Padding(3);
            this.tabFurnizori.Size = new System.Drawing.Size(878, 398);
            this.tabFurnizori.TabIndex = 4;
            this.tabFurnizori.Text = "Furnizori";
            this.tabFurnizori.UseVisualStyleBackColor = true;
            // 
            // dataGVSuppliers
            // 
            this.dataGVSuppliers.AutoGenerateColumns = false;
            this.dataGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnizorIDDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.cUIDataGridViewTextBoxColumn,
            this.localitateDataGridViewTextBoxColumn,
            this.judetDataGridViewTextBoxColumn});
            this.dataGVSuppliers.DataSource = this.furnizoriBindingSource;
            this.dataGVSuppliers.Location = new System.Drawing.Point(18, 60);
            this.dataGVSuppliers.Name = "dataGVSuppliers";
            this.dataGVSuppliers.Size = new System.Drawing.Size(821, 212);
            this.dataGVSuppliers.TabIndex = 9;
            this.dataGVSuppliers.TabIndexChanged += new System.EventHandler(this.adminTabControl_TabIndexChanged);
            // 
            // furnizorIDDataGridViewTextBoxColumn
            // 
            this.furnizorIDDataGridViewTextBoxColumn.DataPropertyName = "FurnizorID";
            this.furnizorIDDataGridViewTextBoxColumn.HeaderText = "FurnizorID";
            this.furnizorIDDataGridViewTextBoxColumn.Name = "furnizorIDDataGridViewTextBoxColumn";
            this.furnizorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.furnizorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            // 
            // cUIDataGridViewTextBoxColumn
            // 
            this.cUIDataGridViewTextBoxColumn.DataPropertyName = "CUI";
            this.cUIDataGridViewTextBoxColumn.HeaderText = "CUI";
            this.cUIDataGridViewTextBoxColumn.Name = "cUIDataGridViewTextBoxColumn";
            // 
            // localitateDataGridViewTextBoxColumn
            // 
            this.localitateDataGridViewTextBoxColumn.DataPropertyName = "Localitate";
            this.localitateDataGridViewTextBoxColumn.HeaderText = "Localitate";
            this.localitateDataGridViewTextBoxColumn.Name = "localitateDataGridViewTextBoxColumn";
            // 
            // judetDataGridViewTextBoxColumn
            // 
            this.judetDataGridViewTextBoxColumn.DataPropertyName = "Judet";
            this.judetDataGridViewTextBoxColumn.HeaderText = "Judet";
            this.judetDataGridViewTextBoxColumn.Name = "judetDataGridViewTextBoxColumn";
            // 
            // furnizoriBindingSource
            // 
            this.furnizoriBindingSource.DataSource = typeof(AccountingApp.Furnizori);
            // 
            // btnSaveSuppliers
            // 
            this.btnSaveSuppliers.Location = new System.Drawing.Point(327, 34);
            this.btnSaveSuppliers.Name = "btnSaveSuppliers";
            this.btnSaveSuppliers.Size = new System.Drawing.Size(88, 23);
            this.btnSaveSuppliers.TabIndex = 8;
            this.btnSaveSuppliers.Text = "Salveaza";
            this.btnSaveSuppliers.UseVisualStyleBackColor = true;
            this.btnSaveSuppliers.Click += new System.EventHandler(this.btnSaveSuppliers_Click);
            // 
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.Location = new System.Drawing.Point(110, 34);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(201, 20);
            this.txtSearchSuppliers.TabIndex = 7;
            this.txtSearchSuppliers.TextChanged += new System.EventHandler(this.txtSearchSuppliers_TextChanged);
            // 
            // lblSearchSuppliers
            // 
            this.lblSearchSuppliers.AutoSize = true;
            this.lblSearchSuppliers.Location = new System.Drawing.Point(15, 34);
            this.lblSearchSuppliers.Name = "lblSearchSuppliers";
            this.lblSearchSuppliers.Size = new System.Drawing.Size(80, 13);
            this.lblSearchSuppliers.TabIndex = 6;
            this.lblSearchSuppliers.Text = "Cauta Furnizori:";
            // 
            // angajatiarticoleBindingSource
            // 
            this.angajatiarticoleBindingSource.DataSource = typeof(AccountingApp.Angajati_articole);
            // 
            // AdminAccountingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 437);
            this.Controls.Add(this.adminTabControl);
            this.Name = "AdminAccountingAppForm";
            this.Text = "Accounting App - ADMIN";
            this.adminTabControl.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            this.tabItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articoleBindingSource)).EndInit();
            this.tabFurnizori.ResumeLayout(false);
            this.tabFurnizori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiarticoleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabFurnizori;
        private System.Windows.Forms.Button btnSaveSuppliers;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.Label lblSearchSuppliers;
        private System.Windows.Forms.DataGridView dataGVSuppliers;
        private System.Windows.Forms.BindingSource furnizoriBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveProducts;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dataGVProducts;
        private System.Windows.Forms.BindingSource articoleBindingSource;
        private System.Windows.Forms.DataGridView dataGVEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn angajatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funtieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private System.Windows.Forms.BindingSource angajatiarticoleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn articolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIntrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valabilitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Furnizor;
    }
}