using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class AdminAccountingAppForm : Form
    {
        GestiuneDBEntities db;
        public AdminAccountingAppForm()
        {
            InitializeComponent();
        }
        private void btnSaveSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers.SaveChanges();
        }

        private void txtSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchSuppliers.Text.ToString()))
            {
                Suppliers.ShowSuppliers(dataGVSuppliers);
            }
            else
                Suppliers.SearchSuppliers(txtSearchSuppliers.Text, dataGVSuppliers);
        }
        private void adminTabControl_TabIndexChanged(object sender, EventArgs e)
        {
            Employees.SaveAndCloseEmployees();
            Products.SaveAndCloseProducts();
            Suppliers.SaveAndCloseSuppliers();
            switch (adminTabControl.SelectedTab.Name)
            {
                case "tabEmployees":
                    Employees.EditEmployees(angajatiBindingSource);
                    break;
                case "tabItems":
                    Products.EditProducts(articoleBindingSource,dataGVProducts);
                    Products.UpdateSupplierNameColumn(dataGVProducts);
                    break;
                case "tabFurnizori":
                   Suppliers.EditSuppliers(furnizoriBindingSource);
                    break;
                default:
                    MessageBox.Show("Eroare la tab","Error",MessageBoxButtons.OK);
                    break;
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adauga_Angajat adauga_Angajat = new Adauga_Angajat();
            adauga_Angajat.Show();
        }

        private void dataGVProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            Products.SaveChanges();
        }
        private void dataGVProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Products.Suggest(dataGVProducts,e);      

        }
    }
}
