using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace PracaInz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Data()
        {
            string[] filePaths = Directory.GetFiles(@"C:\Projects\PracaInz2\PracaInz\Data\");
            string[,] filesInfo = new string[filePaths.Length,3];
            double tmp = 0;

            for (int i = 0; i < filePaths.Length; i++)
            {
                filesInfo[i, 0] = new FileInfo(filePaths[i]).Name;
                tmp = Convert.ToDouble(new FileInfo(filePaths[i]).Length.ToString())/1048576;
                filesInfo[i, 1] = String.Format("{0:F3}", tmp);
                filesInfo[i, 2] = new FileInfo(filePaths[i]).CreationTime.ToString();

            }

            ViewBag.Collection = filesInfo;

            return View();
        }
    }
}