using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationSchelduExam.Model;
using WebApplicationSchelduExam.Model.Entities;


namespace WebApplicationSchelduExam.Controllers
{
    public class ScheduleExamController : Controller
    {
        private DbManager db = DbManager.GetInstance();
        // GET: ScheduleExam
        public ActionResult Index()
        {
            List<Scheldue> scheldues = db.TableScheldue.GetAllScheldues();
            return View(scheldues);
        }
        public ActionResult OpenInsertForm()
        {
            return View("InsertForm");
        }
        [HttpPost]
        public ActionResult Insert(Scheldue scheldue)
        {
            bool result = db.TableScheldue.InsertNewScheldue(scheldue);
            ViewBag.Message = result == true ? "Success insert" : "Error insert";
            return View("InsertResult");
        }
        public void Delete(int id)
        {
            db.TableScheldue.DeleteScheldueById(id);
            Response.Redirect(Url.Action("Index", "Scheduleexam"));
        }
    }
}