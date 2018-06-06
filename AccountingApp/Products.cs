using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    static class Products
    {
        private static  GestiuneDBEntities db;
        private static AutoCompleteStringCollection autoComplete;
        public static void EditProducts(BindingSource articoleBindingSource,DataGridView gv)
        {
            db = new GestiuneDBEntities();
            db.Articole.Load();
            articoleBindingSource.DataSource = db.Articole.Local.ToBindingList();


            //String sugestiv = "select * from Articole where ";

        }
        static public void SaveAndCloseProducts()
        {
            if (db != null)
            {
                db.SaveChanges();
                db.Dispose();
                db = null;
            }

        }
        public static void UpdateSupplierNameColumn(DataGridView dataGVProducts)
        {
            using (var db = new GestiuneDBEntities())
            {
                db.Furnizori.Load();
                int suppliersColumnIndex = 8;
                foreach (DataGridViewRow row in dataGVProducts.Rows)
                {
                    //gets the suppliers Id from each cell in FurnizoriId
                    var supplierId = row.Cells[suppliersColumnIndex - 1].Value;
                    if (supplierId != null)
                    {
                        //if the supplierId is equal with the id in Furnizori
                        var supplierName = db.Furnizori.Local.FirstOrDefault(a => a.FurnizorID.Equals(supplierId));
                        if (supplierName != null)
                        {
                            row.Cells[suppliersColumnIndex].Value = supplierName.Denumire.ToString();
                            
                        }
                    }
                }
            }
        }
        public static void Suggest(DataGridView dataGVProducts, DataGridViewEditingControlShowingEventArgs e)
        {
            using (var db = new GestiuneDBEntities())
            {
                db.Furnizori.Load();
                var suppliersName = from Furnizori in db.Furnizori.Local select Furnizori.Denumire;
                autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(suppliersName.ToArray());
                if (dataGVProducts.CurrentCell.ColumnIndex == 8)
                {
                    TextBox txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txt.AutoCompleteCustomSource = autoComplete;
                    }
                }
            }
        }
        public static void SaveChanges()
        {
            if (db != null)
                db.SaveChanges();
        }
    }
}
