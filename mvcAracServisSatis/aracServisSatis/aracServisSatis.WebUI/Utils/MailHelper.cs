using aracServisSatis.Entities;
using System.Net;
using System.Net.Mail;


namespace aracServisSatis.WebUI.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Musteri musteri)
        {
            SmtpClient smtpClient = new SmtpClient("mail.siteadresi.com",587);
            smtpClient.Credentials = new NetworkCredential("emailKullanıcıad", "emailşifre");
            smtpClient.EnableSsl = false;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("info@siteadi.com");
            message.To.Add("info@siteadi.com");
            message.To.Add("bilgi@siteadi.com");
            message.Subject = "Siteden mesaj geldi.";
            message.Body = $"Mail Bilgileri <hr/> Ad Soyad:  {musteri.Adi }  {musteri.Soyadi } < hr /> İlgilendiği Arac Id : {musteri.AracId}";
            message.IsBodyHtml = true;
            //smtpClient.Send(message);
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();

        }
    }
}
