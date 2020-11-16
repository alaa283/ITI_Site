using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _ITI.Views
{
    public class AdmisController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Admis
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register_Account()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register_Account(Staff staff)
        {
            Staff staff_ = new Staff();
            staff_.Id_Staff = staff.Id_Staff;
            staff_.Name = staff.Name;
            staff_.Email_Staff = staff.Email_Staff;
            staff_.Specialization = staff.Specialization;
            staff_.Gender = staff.Gender;
            staff_.Phone = staff.Phone;
            db.Staffs.InsertOnSubmit(staff_);
            db.SubmitChanges();
            return View("Index");
        }
    }
}