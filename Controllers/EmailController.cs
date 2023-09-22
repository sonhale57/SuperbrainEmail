using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hangfire.Storage;
using Hangfire;

namespace SuperbrainEmail.Controllers
{
    public class EmailController : Controller
    {
        private readonly EmailService _emailService;
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }
        public EmailController()
        {
            _emailService = new EmailService();
        }

        
    }
    public class JobSendmails
    {
        public void Execute(MyJobData jobData,string to,string subject,string body)
        {
            // Thực hiện công việc của bạn ở đây
            EmailService emailService = new EmailService();
            emailService.SendEmail(to,subject,body);
        }
    }

    public class MyJobData
    {
        public string Title { get; set; }
    }

    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                // Tạo một đối tượng SmtpClient
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Cổng SMTP của máy chủ email
                    Credentials = new NetworkCredential("superbrain.noreply@gmail.com", "rhewihyggxsizliv"),
                    EnableSsl = true, // Kích hoạt SSL (nếu máy chủ hỗ trợ)
                };

                // Tạo một đối tượng MailMessage
                MailMessage mailMessage = new MailMessage("superbrain.noreply@gmail.com", to)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true, // Nếu bạn muốn sử dụng HTML trong nội dung email
                };

                // Gửi email
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi gửi email
                throw ex;
            }
        }
    }
}
