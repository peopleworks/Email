using MailKit.Security;
using MimeKit;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ComboComponent.Text == "NetClient")
            {
                SendEmail();
            } else
            {
                SendEmailMailKit();
            }
        }

        public void SendEmail()
        {
            string cSender = txtFrom.Text; 
            string cTo = txtTo.Text;

            string cUser = txtUserName.Text; 
            string cPassWord = txtPassWord.Text; 

            string cClientHost = txtServer.Text; 

            // Authenticate
            MailMessage mail = new MailMessage(cSender, cTo);
            NetworkCredential NetworkCred = new NetworkCredential(cUser, cPassWord);

            // Client
            SmtpClient client = new SmtpClient()
            {
                Port = int.Parse(txtPort.Text),
                EnableSsl = ckEnableSSL.Checked,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = ckUseDefaultCredentials.Checked,
                Credentials = NetworkCred,
                Host = cClientHost
            };

            // Mail
            mail.IsBodyHtml = true;
            mail.Subject = "Puedo Enviar correo";


            var file = File.ReadAllText(@"C:\Max\APP ATM\Email\Email-responsive.html");

            mail.Body = file.Trim();

        
            try
            {
                client.Send(mail);
            } catch(Exception ex)
            {
                listErrorBox.Items.Add(ex.Message.Trim());

                MessageBox.Show(ex.Message.Trim());
            }
        }


        public async void SendEmailMailKit()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("CLAPP", txtFrom.Text));
            message.To.Add(new MailboxAddress("A", txtTo.Text));
            message.Subject = "Puedo Enviar correo";

            message.Body = new TextPart("plain")
            {
                Text =
                    @"Hey,

                    Este es un mensaje enviado MailKit.

                    Vamos a usarlo de ahora en adelante... Siiii 💪😁

                    -- Yo.
"
            };


            using(var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await  client.ConnectAsync(txtServer.Text, int.Parse(txtPort.Text), SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(txtUserName.Text, txtPassWord.Text);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
