using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan.cs
{
    public partial class E_mail : Form
    {
        public E_mail(DataGridView data)
        {
            InitializeComponent();
            DataGrid = data;
        }
        DataGridView DataGrid;

        private void btnSenden_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            try
            {
                //Email konfigurationen 
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("modul318bedlhuwy@gmx.ch");
                mail.To.Add(new MailAddress(toEmail));
                mail.Subject = "Fahrplan";
                mail.Body = "Please check the following connections ";
                mail.Body += email.GetTableFromDataGrid(toEmail, DataGrid);
                mail.IsBodyHtml = true;
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Host = "mail.gmx.net";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("modul318bedlhuwy@gmx.ch", "9241beat");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sends Successfully!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.Close();
        }
        //Abfangen der Mail Adresse
        public string toEmail
        {
            get { return tbxToMail.Text; }
        }


    }
}
