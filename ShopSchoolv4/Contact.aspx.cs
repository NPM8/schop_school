using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopSchoolv4
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            MailAddress fromAddress = new MailAddress("nnnp.dawid@gmail.com", "From Name");
            MailAddress toAddress = new MailAddress("nnnp.dawid@gmail.com", "To Name");
            const string fromPassword = "Tsart3_Frat";
            const string subject = "Temat new";
            string body = txtDescription.Text;
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
                try
                {
                    
                } catch (System.Net.Mail.SmtpException ex) { Console.Write("Error!"); }
            }
        }
    }
}