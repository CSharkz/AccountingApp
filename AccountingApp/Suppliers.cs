using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    static class Suppliers
    {
        private static GestiuneDBEntities db;
        public static void EditSuppliers(BindingSource furnizoriBindingSource)
        {
            db = new GestiuneDBEntities();
            db.Furnizori.Load();
            furnizoriBindingSource.DataSource = db.Furnizori.Local.ToBindingList();

        }
    
            static public void SearchSuppliers(string txtSearchSuppliers,DataGridView dataGridView)
        {
           using (var db=new GestiuneDBEntities())
            {
                var search=db.Furnizori.Where(s => s.Denumire.StartsWith(txtSearchSuppliers));
                dataGridView.DataSource = search.ToList();
            }
        }
        static public void SaveChanges()
        {
            if (db != null)
                db.SaveChanges();
        }
        static public void SaveAndCloseSuppliers()
        {
            if (db != null)
            {
                db.SaveChanges();
                db.Dispose();
                db = null;
            }

        }
        static public void ShowSuppliers(DataGridView dataGridView)
        {
            using (var db = new GestiuneDBEntities())
            {
                db.Furnizori.Load();
                var fur = from Furnizori in db.Furnizori.Local select Furnizori;
                dataGridView.DataSource = fur.ToList();
            }
        }
    }
}
