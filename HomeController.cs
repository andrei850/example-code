using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//This solution has two projects Example and Exampl.Tests
// Example - MVC web application using Treelist kendo ui control
// Exampl.Tests - unit test application overruffing that 3 reason listed

namespace Example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult DisplayHomeIndex()
        {
            return View("HomeIndex");
        }
        public ActionResult CreateList()
        {
            ListData ld = new ListData();
            List<ReasonData> lst = ld.GetDataList();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }

    public class ListData 
    {
        public List<ReasonData> GetDataList()
        {
            List<ReasonData> lst = new List<ReasonData>();
            ReasonData r = new ReasonData();

            r.ID = "2";
            r.CountID = "1";
            r.ParentId = "1";
            r.Reason = "Great growth opportunities for employees";
            lst.Add(r);

            r = new ReasonData();
            r.ID = "3";
            r.CountID = "2";
            r.ParentId = "1";
            r.Reason = "Training is available if needed for your job";
            lst.Add(r);

            r = new ReasonData();
            r.ID = "5";
            r.CountID = "3";
            r.ParentId = "4";
            r.Reason = "Great employee benefits";
            lst.Add(r);
            return lst;
        }
    }
 }
