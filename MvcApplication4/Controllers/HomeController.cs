using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            //byte[] data = null;
            //using (MemoryStream oMemoryStream = new MemoryStream())
            //{
               

            //    using (Bitmap oBitmap = new Bitmap(Server.MapPath("~/App_Data/Image/image001.jpg")))
            //    {
                    

            //        //儲存圖片到 MemoryStream 物件，並且指定儲存影像之格式
            //        oBitmap.Save(oMemoryStream,ImageFormat.Jpeg);

            //        //設定資料流位置
            //        oMemoryStream.Position = 0;

            //        //設定 buffer 長度
            //        data = new byte[oMemoryStream.Length];

            //        //將資料寫入 buffer
            //        oMemoryStream.Read(data, 0, Convert.ToInt32(oMemoryStream.Length));

            //        //將所有緩衝區的資料寫入資料流
            //        oMemoryStream.Flush();

            //    }
            //}
            //return File(data, "image/png","Test.jpg");   
            //return JavaScript("alert('更新成功')");

            return View();
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowJS()
        {
            return JavaScript("alert('成功')");
        }

        //[HttpPost]
        public ActionResult GetJSON()
        {
            return Json(new { id = 111, name = "Jane", createdOn = DateTime.Now, GUID = new Guid() },JsonRequestBehavior.AllowGet);
        }

        public ActionResult Test()
        {
            ViewBag.Test = "Test Page";
            return View();
        }

        public ActionResult Test2()
        {

            return View();
        }
    }
}
