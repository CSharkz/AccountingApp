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
    static class Employees
    {
        private static GestiuneDBEntities db;
        public static void EditEmployees(BindingSource angajatiBindingSource)
        {
            db = new GestiuneDBEntities();
            db.Angajati.Load();
            angajatiBindingSource.DataSource = db.Angajati.Local.ToBindingList();

        }
        static public void SaveAndCloseEmployees()
        {
            if (db != null)
            {
                db.SaveChanges();
                db.Dispose();
                db = null;
            }

        }
    }
}
