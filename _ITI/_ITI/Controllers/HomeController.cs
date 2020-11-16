using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _ITI.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(Questions_Answer question)
        {
            Questions_Answer questions_ = new Questions_Answer();
            questions_.Id_Ask = question.Id_Ask;
            questions_.Ask = question.Ask;
            db.Questions_Answers.InsertOnSubmit(questions_);
            db.SubmitChanges();
            return View("Index");
        }
    }
}