using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        //获取所有首字母以及锚点的json
        public ActionResult GetFirstLettersJson()
        {
            var allCarCategories = Database.GetAllCarCategories();
            var result = from l in allCarCategories
                group l by l.FirstLetter
                into g
                select new {firstletter = g.Key, anchor=g.ToList()[0].AnchorName};
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //获取按首字母分组后的品牌车系json
        public ActionResult GetPinPaiCheXiJson() 
        {
            var allPinPais = Database.GetAllCarCategories().Where(c => c.Level == 1).OrderBy(c => c.FirstLetter);
            var allPinPaisGroup = from p in allPinPais
                group p by new
                {
                    p.FirstLetter,
                    p.AnchorName
                };

            List<PinPaiCheXiForDisplay> result1 = new List<PinPaiCheXiForDisplay>();
            foreach (var item in allPinPaisGroup)
            {
                //品牌车系
                PinPaiCheXiForDisplay pinPaiCheXiForDisplay = new PinPaiCheXiForDisplay();
                pinPaiCheXiForDisplay.FirstLetter = item.Key.FirstLetter;
                pinPaiCheXiForDisplay.Anchor = item.Key.AnchorName;
                
                //品牌
                List<PinPaiForDisplay> pinPaiForDisplays = new List<PinPaiForDisplay>();
                foreach (var pinpai in item.ToList())
                {
                    PinPaiForDisplay pinPaiForDisplay = new PinPaiForDisplay();
                    pinPaiForDisplay.PinPaiId = pinpai.Id;
                    pinPaiForDisplay.PinPaiName = pinpai.Name;
                    
                    //车系
                    List<CheXiForDisplay> cheXiForDisplays = new List<CheXiForDisplay>();
                    var cheXis = Database.GetAllCarCategories().Where(c => c.ParentId == pinpai.Id).OrderBy(c => c.Id);
                    foreach (var chexi in cheXis)
                    {
                        CheXiForDisplay cheXiForDisplay = new CheXiForDisplay();
                        cheXiForDisplay.CheXiId = chexi.Id;
                        cheXiForDisplay.CheXiName = chexi.Name;
                        cheXiForDisplay.TotalCount = cheXis.Count();

                        cheXiForDisplays.Add(cheXiForDisplay);
                    }
                    pinPaiForDisplay.CheXis = cheXiForDisplays;

                    pinPaiForDisplays.Add(pinPaiForDisplay);
                }
                pinPaiCheXiForDisplay.PinPais = pinPaiForDisplays;

                result1.Add(pinPaiCheXiForDisplay);
            }

            return Json(result1, JsonRequestBehavior.AllowGet);
        }

        //根据品牌Id显示车型
        public ActionResult GetCheXingsByPId(int pid)
        {
            var cars = Database.GetAllCars().Where(c => c.PinPaiId == pid);
            return View(cars);
        }

        //根据车系Id显示车型
        public ActionResult GetCheXingsByChexiId(int cxid)
        {
            var cars = Database.GetAllCars().Where(c => c.CheXiId == cxid);
            return View(cars);
        }

    }
}
