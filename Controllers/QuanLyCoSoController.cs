using Hangfire;
using Hangfire.Common;
using SuperbrainEmail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperbrainEmail.Controllers
{
    public class ViewModelChiNhanh
    {
        public int id { get; set; }
        public string Ten { get; set; }
        public string Dienthoai { get; set; }
        public string Email { get; set; }
        public string DateExpire { get; set; }
        public string DateTKOnline { get; set; }
        public int SoluongTK { get; set; }
        public int SoluongTKPhatsinh { get; set; }
        public int SoluongTKPhatsinhtruoc { get; set; }

        public double PhiTK { get; set; }
        public double PhiTKPhatsinh { get; set; }
        public double PhiTKPhatsinhtruoc { get; set; }
        public bool StatusPhiTKOnline { get; set; }
        public string TrangthaiPhiTKOnline { get; set; }

    }
    public class QuanLyCoSoController : Controller
    {
        ModelDbContext db = new ModelDbContext();
        private readonly EmailService _emailService;
        public QuanLyCoSoController()
        {
            _emailService = new EmailService();
        }
        // GET: QuanLyCoSo
        public ActionResult Index()
        {
            var conf = db.Configs.OrderByDescending(m=>m.id);
            ViewBag.date = conf.First().Thoigiantinhphi;
            DateTime dateTinhphi= conf.First().Thoigiantinhphi.Value.AddMonths(1);
            DateTime datethangtruoc= conf.First().Thoigiantinhphi.Value;
            ViewBag.thang = dateTinhphi.ToString("MM/yyyy");
            ViewBag.thangtruoc = datethangtruoc.ToString("MM/yyyy");

            var list = new List<ViewModelChiNhanh>();
            foreach ( var item in db.ChiNhanhs.Where(x=>x.enable==true).ToList())
            {
                var cn = new ViewModelChiNhanh()
                {
                    Ten = item.Ten,
                    Dienthoai = item.dienthoai,
                    Email = item.email1,
                    DateExpire = item.DateExpire.ToString("dd/MM/yyyy"),
                    DateTKOnline = item.DateTKOnline.ToString("dd/MM/yyyy"),
                    TrangthaiPhiTKOnline = Checktrangthai_TkOnline(item.id),
                    SoluongTK = Calc_SoluongTK(item.id),
                    SoluongTKPhatsinh = Calc_SoluongTKPhatsinh(item.id),
                    PhiTK = Calc_phiTK(item.id),
                    PhiTKPhatsinh = Calc_PhiTkPhatsinh(item.id),
                    SoluongTKPhatsinhtruoc = Calc_SoluongTKTruoc(item.id),
                    PhiTKPhatsinhtruoc = Calc_phiTKPhatsinhtruoc(item.id)
                };
                list.Add(cn);
            }
            return View(list);

        }
        public ActionResult SendEmails()
        {
            List<string> recipients = new List<string>
            {
                "sonhale57@gmail.com",
                "sonhale57.data@gmail.com",
                "sonhale57.aws@gmail.com",
                "sonhale57.tech@gmail.com",
                "sa.tech@gmail.com",
                "sa.xbv@gmail.com",
                "sa.ows@gmail.com",
                // Thêm các địa chỉ email khác vào danh sách
            };

            foreach (var recipient in recipients)
            {
                //BackgroundJob.Enqueue(() => _emailService.SendEmail(recipient, "Chủ đề của email", "Nội dung của email"));
                var jobData = new MyJobData
                {
                    Title = "Gửi email "+recipient,
                    // Các thông tin khác về công việc
                };

                BackgroundJob.Enqueue<JobSendmails>(x => x.Execute(jobData,recipient,"Chủ đề mail","Nội dung email"));
            }
            return View();
        }
        public string bodyEmail(int id) {
            var cn = db.ChiNhanhs.Find(id);
            var conf = db.Configs.OrderByDescending(m => m.id);
            DateTime dateTinhphi = conf.First().Thoigiantinhphi.Value.AddMonths(1);
            DateTime fr = conf.First().Thoigiantinhphi.Value.AddMonths(-1);
            DateTime to = conf.First().Thoigiantinhphi.Value;
            int sotaikhoan = Calc_SoluongTK(id);
            decimal dongiataikhoan =conf.First().Phitaikhoan;
            decimal thanhtienphitaikhoan = dongiataikhoan * sotaikhoan;

            decimal tongtien = thanhtienphitaikhoan + 5000000;
            //double thue = tongtien * 8;

            string body = "<div style=\"display: block; padding: 20px; margin: 0 auto; font-family: 'Google Sans',Arial, roboto, sans-serif;\">"
                + "<p>Kính gửi <b>" + cn.Ten + "</b>,</p>"
                + "<p>Hệ thống đào tạo Superbrain Việt Nam trân trọng thông báo phí tháng " + dateTinhphi.ToString("MM/yyyy") + " của cơ sở " + cn.Ten + " như sau:</p>"
                + "<table style='border-spacing: 0;'>"
                + "    <tr style='background: #a6ce39;'>"
                + "        <td style='width:5%;text-align: center;border: 0.5px solid #888;padding: 7px;'>STT</td>"
                + "        <td style='width:37%;text-align: center;border: 0.5px solid #888;padding: 7px;'>Nội dung</td>"
                + "        <td style='width:15%;text-align: center;border: 0.5px solid #888;padding: 7px;'>Số lượng</td>"
                + "        <td style='width:15%;text-align: center;border: 0.5px solid #888;padding: 7px;'>Đơn giá</td>"
                + "        <td style='width:20%;text-align: center;border: 0.5px solid #888;padding: 7px;'>Thành tiên</td>"
                + "    </tr>"
                + "    <tr>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>01</td>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>Phí sử dụng thương hiệu hàng tháng</td>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>1</td>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>5,000,000</td>"
                + "        <td style='text-align: right;border: 0.5px solid #888;padding: 7px;'>5,000,000</td>"
                + "    </tr>"
                + "    <tr>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>02</td>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>Phí tài khoản online học viên (*)</td>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>" + sotaikhoan + "</td>"
                + "        <td style='text-align: center;border: 0.5px solid #888;padding: 7px;'>" + string.Format("{0:N00}",dongiataikhoan) + "</td>"
                + "        <td style='text-align: right;border: 0.5px solid #888;padding: 7px;'>" + string.Format("{0:N00}", thanhtienphitaikhoan) + "</td>"
                + "    </tr>"
                + "    <tr>"
                + "        <td style='text-align: left;border: 0.5px solid #888;padding: 7px;' colspan='4'>Tổng tiền</td>"
                + "        <td style='text-align: right;border: 0.5px solid #888;padding: 7px;'>" + string.Format("{0:N00}", tongtien) + "</td>"
                + "    </tr>"
                + "    <tr>"
                + "        <td style='text-align: left;border: 0.5px solid #888;padding: 7px;' colspan='4'>Thuế VAT</td>"
                + "        <td style='text-align: right;border: 0.5px solid #888;padding: 7px;'>VAT</td>"
                + "   </tr>"
                + "    <tr>"
                + "        <td style='text-align: left;border: 0.5px solid #888;padding: 7px;' colspan='4'>Tổng cộng thanh toán</td>"
                + "        <td style='text-align: right;border: 0.5px solid #888;padding: 7px;'>TONG</td>"
                + "    </tr>"
                + "</table>"
                + "<i>(*) Phí tài khoản Online học viên được tính từ " + fr.ToString("dd/MM/yyyy") + " - " + to.ToString("dd/MM/yyyy") + ".</i>"
                + "<p>Cảm ơn Quý cơ sở,</p>"
                + "<p><i>Lưu ý: Thư điện tử này được gửi ra từ hệ thống tự động. Quý Cơ sở vui lòng không trả lời thư điện tử này.></p>"
                + "<p><i>Trong trường hợp Quý Cơ sở có bất kỳ thắc mắc hoặc yêu cầu nào liên quan đến Bảng phí, vui lòng liên hệ với Bộ phận Kế toán qua số Zalo 090 662 1800 để được hỗ trợ.</p>"
                + "<p>Trân trọng,</p>"
                + "<p>Superbrain Việt Nam</p>"
                + "<img src='https://superbrain.edu.vn/wp-content/uploads/2021/10/bpkt.png' alt='' width='100%' height='auto'/>"
                + "</div>";
            return body;
        }
        public int Calc_SoluongTKTruoc(int id)
        {
            var conf = db.Configs.OrderByDescending(m => m.id);
            DateTime frdate = conf.First().Thoigiantinhphi.Value.AddMonths(-2);
            DateTime todate = conf.First().Thoigiantinhphi.Value.AddMonths(-1);

            var linq = from hs in db.Hocsinhs
                       join lhj in db.Lophoc_join on hs.id equals lhj.idhocvien
                       where lhj.fromdate >= frdate && lhj.fromdate < todate && lhj.updatetime > todate && hs.idChiNhanh == id
                       select hs;

            return linq.Count();
        }
        public double Calc_phiTKPhatsinhtruoc(int id)
        {
            var conf = db.Configs.OrderByDescending(m => m.id);
            DateTime frdate = conf.First().Thoigiantinhphi.Value.AddMonths(-2);
            DateTime todate = conf.First().Thoigiantinhphi.Value.AddMonths(-1);

            var linq = from hs in db.Hocsinhs
                       join lhj in db.Lophoc_join on hs.id equals lhj.idhocvien
                       where lhj.fromdate >= frdate && lhj.fromdate < todate && lhj.updatetime > todate  && hs.idChiNhanh == id
                       select hs;
            double tong = (linq.Count() * 60000) + (linq.Count() * 60000 * 0.08);
            return tong;
        }
        public int Calc_SoluongTK(int id) {
            var conf = db.Configs.OrderByDescending(m => m.id);
            DateTime frdate = conf.First().Thoigiantinhphi.Value.AddMonths(-1);
            DateTime todate = conf.First().Thoigiantinhphi.Value;

            var linq = from hs in db.Hocsinhs
                       join lhj in db.Lophoc_join on hs.id equals lhj.idhocvien
                       where lhj.fromdate >= frdate && lhj.fromdate < todate && lhj.updatetime >= frdate && lhj.updatetime < todate && hs.idChiNhanh == id
                       select hs;

            return linq.Count();
        }
        public double Calc_phiTK(int id) {
            var conf = db.Configs.OrderByDescending(m => m.id);
            DateTime frdate = conf.First().Thoigiantinhphi.Value.AddMonths(-1);
            DateTime todate = conf.First().Thoigiantinhphi.Value;

            var linq = from hs in db.Hocsinhs
                       join lhj in db.Lophoc_join on hs.id equals lhj.idhocvien
                       where lhj.fromdate >= frdate && lhj.fromdate < todate && lhj.updatetime >= frdate && lhj.updatetime < todate && hs.idChiNhanh == id
                       select hs;
            double tong = (linq.Count() * 60000) + (linq.Count() * 60000* 0.08);
            return tong;
        }
        public int Calc_SoluongTKPhatsinh(int id)
        {
            var conf = db.Configs.OrderByDescending(m => m.id);
            DateTime frdate = conf.First().Thoigiantinhphi.Value.AddMonths(-1);
            DateTime todate = conf.First().Thoigiantinhphi.Value;

            var linq = from hs in db.Hocsinhs
                       join lhj in db.Lophoc_join on hs.id equals lhj.idhocvien
                       where lhj.fromdate >= frdate && lhj.fromdate < todate && lhj.updatetime >= todate  && hs.idChiNhanh == id
                       select hs;

            return linq.Count();
        }
        public double Calc_PhiTkPhatsinh(int id)
        {
            var conf = db.Configs.OrderByDescending(m => m.id);
            DateTime frdate = conf.First().Thoigiantinhphi.Value.AddMonths(-1);
            DateTime todate = conf.First().Thoigiantinhphi.Value;

            var linq = from hs in db.Hocsinhs
                       join lhj in db.Lophoc_join on hs.id equals lhj.idhocvien
                       where lhj.fromdate >= frdate && lhj.fromdate < todate && lhj.updatetime >= todate && hs.idChiNhanh == id
                       select hs;
            double tong = (linq.Count() * 60000) + (linq.Count() * 60000 * 0.08);
            return tong;
        }
        public string Checktrangthai_TkOnline(int id)
        {
            var cn = db.ChiNhanhs.Find(id);
            if (cn == null)
            {
                return "Not Found";
            }
            else
            {
                if (cn.DateTKOnline > DateTime.Now)
                {
                    return "<span class='text-success text-bolder'>Đã đóng phí</span>";
                }
                else
                {
                    return "<span class='text-danger text-bolder'>Chưa đóng phí</span>";
                }
            }
        }
    }
}