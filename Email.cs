using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;

namespace Travelling_SalesMan_Problem
{
    class Email
    {
        public void SendEmail(string Reciever, string body)
        {
            string FinalBody = "*******Home Delivery Management System********** \n You are directed to follow following mentioned route while delivering orders. \n" + body + "\nReport Back to OI/C Delivery after delivery";
            try
            {
                MailMessage mail = new MailMessage("hamzaaaa090@gmail.com", Reciever, "Route of Delivery", FinalBody);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587; //465
                client.Credentials = new System.Net.NetworkCredential("hamzaaaa090@gmail.com", "hamza@12345");
                client.EnableSsl = true;
                client.Send(mail);
                Console.WriteLine("Email Send Successfully");
            }
            catch(Exception e)
            {
                new ShortestPath().NoInternet();
            }
        }
    }
}
