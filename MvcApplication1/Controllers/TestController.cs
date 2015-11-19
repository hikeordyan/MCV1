using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
         [HttpPost]
        public ActionResult Data()
        {
            /*var data = new Test[9]
            {
              new Test(1,"hayk","Yerevan"),
              new Test(2,"aram","Gyumry"),
              new Test(3,"ashot","Idjevan"),
              new Test(4,"ani","Hrazdan"),
              new Test(5,"vahe","Kapan"),
              new Test(6,"shushan","Ararat"),
              new Test(7,"anna","Vanadzor"),
              new Test(8,"suren","Yerevan"),
              new Test(9,"hayk","Yerevan"),
            };

            return View(data);*/
            
            return View();
        }




        public ActionResult Index()
        {

            IEnumerable<Test>  data = new Test[9]
            {
              new Test(1,"hayk","Yerevan"),
              new Test(2,"aram","Gyumry"),
              new Test(3,"ashot","Idjevan"),
              new Test(4,"ani","Hrazdan"),
              new Test(5,"vahe","Kapan"),
              new Test(6,"shushan","Ararat"),
              new Test(7,"anna","Vanadzor"),
              new Test(8,"suren","Yerevan"),
              new Test(9,"hayk","Yerevan"),
            };


           /* var model = Enumerable.Range(1,5)
               .Select(i => data);*/

            return View(data);
          
        }

    }
}
