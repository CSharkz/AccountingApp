using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Net;
using System.Text.RegularExpressions;

namespace AccountingApp
{
    public static class Login
    {

        private static string hashString = "p455w0rd3ncrypt10n";

        /* Static Boolean method to validate credentials from Login Form */
        public static bool ValidateCredentials(string username, string password)
        {
            bool loginSuccessfully = false;
            //If string null
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please provide a Username and Password!", "Warning");
                return false;
            }
            
            using (var db = new GestiuneDBEntities())
            {
               // string ecryptedPassword = EncryptPassword(password, hashString);
                var loginAttempt = db.Credentials.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (loginAttempt != null) loginSuccessfully = true;
            }

            if (loginSuccessfully == true) return true;
            else
            {
                MessageBox.Show("Username sau parola incorecte", "Warning", MessageBoxButtons.OK);
            }
            return false;
        }

        /* Static boolean method to register new user from Login Form*/
        public static bool RegisterNewUser(int userID, string username, string password, string email)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Va rugam completati toate campurile!", "Warning", MessageBoxButtons.OK);
                return false;
            }

            using (var db = new GestiuneDBEntities())
            {
                var idFound = db.Angajati.FirstOrDefault(b => b.AngajatID == userID);
                var idDuplicate = db.Credentials.FirstOrDefault(c => c.AngajatID == userID);
                var usernameFound = db.Credentials.FirstOrDefault(a => a.Username == username);
                if (idFound != null)
                {
                    if (idDuplicate == null)
                    {
                        if (IsMailValid(email))
                        {
                            if (usernameFound == null)
                            {
                                Credentials credential = new Credentials();
                                credential.Username = username;
                                credential.Password = EncryptPassword(password, hashString);
                                credential.AngajatID = userID;
                                credential.Email = email;

                                db.Entry(credential).State = EntityState.Added;
                                db.Credentials.Add(credential);
                                db.SaveChanges();
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Username-ul introdus exista deja. Incercati unul nou", "Warning", MessageBoxButtons.OK);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Emailul introdus nu este valid. Incercati din nou", "Warning", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exista deja un utilizator inregistrat cu acest Cod unic", "Warning", MessageBoxButtons.OK);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Cod unic inexistent. Contactati administratorul pentru o cheie valida.", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
        }

        public static bool RecoverPassword(string email)
        {
            if (IsMailValid(email))
            {
                using (var db = new GestiuneDBEntities())
                {
                    var emailAttempt = db.Credentials.FirstOrDefault(a => a.Email == email);
                    if (emailAttempt != null)
                    {
                        return SendMail(DecryptPassword(emailAttempt.Password, hashString), emailAttempt.Email, emailAttempt.Username);
                    }
                    else
                    {
                        MessageBox.Show("Nu exista niciun cont cu acest email", "Warning", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Emailul introdus nu este valid. Incercati din nou.", "Warning", MessageBoxButtons.OK);
                return false;
            }
        }

        private static bool SendMail(string pass, string mailTo, string username)
        {
            if (!string.IsNullOrEmpty(pass))
            {
                try
                {
                    MailMessage mailMsg = new MailMessage("pwdrec.accapp@gmail.com", mailTo);
                    mailMsg.Subject = "Recuperare parola";
                    mailMsg.Body = string.Format("Salutare {0}, <br /><br /> Parola ta este {1}. <br /><br /> Multumesc.", username, pass);
                    mailMsg.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential networkCredential = new NetworkCredential();
                    networkCredential.UserName = "pwdrec.accapp@gmail.com";
                    networkCredential.Password = "grupa&semigrupa1";
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = networkCredential;
                    smtp.Port = 587;
                    smtp.Send(mailMsg);
                    return true;
                }
                catch
                {
                    MessageBox.Show("S-a produs o eroare la transmiterea mailului cu parola", "Warning", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Parola este inexistenta", "Warning", MessageBoxButtons.OK);
                return false;
            }
        }

        private static bool IsMailValid(string mail)
        {
            try
            {
                MailAddress m = new MailAddress(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static string EncryptPassword(string pass, string hash)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(pass);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private static string DecryptPassword(string encryptedPass, string hash)
        {
            //Regex.Replace(encryptedPass, @"\s+", "");
            byte[] data = Convert.FromBase64String(encryptedPass);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
