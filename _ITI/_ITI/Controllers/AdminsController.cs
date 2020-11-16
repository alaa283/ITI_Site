using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _ITI.Controllers
{
    public class AdminsController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Admins
        public ActionResult Index()
        {
            return View(db.Staffs);
        }

        public ActionResult Register_Account()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register_Account(Staff staff)
        {
            if (ModelState.IsValid)
            {
                Staff staff_ = new Staff();
                if (staff_ != null)
                { 
                    staff_.Id_Staff = staff.Id_Staff;
                    staff_.Email_Staff = staff.Email_Staff;
                    staff_.Name = staff.Name;
                    staff_.Gender = staff.Gender;
                    staff_.Phone = staff.Phone;
                    staff_.Specialization = staff.Specialization;
                    db.Staffs.InsertOnSubmit(staff_);
                    db.SubmitChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(staff);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                Staff co = db.Staffs.Where(e => e.Id_Staff == id).FirstOrDefault();
                if (co != null)
                {
                    return View(co);
                }
            }
            return View("Error");

        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(Staff staff)
        {
            Staff staff_ = db.Staffs.Where(s => s.Id_Staff == staff.Id_Staff).FirstOrDefault();
            if (staff_ != null)
            {
                staff_.Id_Staff = staff.Id_Staff;
                staff_.Email_Staff = staff.Email_Staff;
                staff_.Name = staff.Name;
                staff_.Gender = staff.Gender;
                staff_.Phone = staff.Phone;
                staff_.Specialization = staff.Specialization;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View(staff);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Staff staff = db.Staffs.Where(e => e.Id_Staff == id).FirstOrDefault();
            return View(staff);
        }

        [HttpPost]
        public ActionResult Delete(int id, Staff staff)
        {
            Staff staff_ = db.Staffs.Where(e => e.Id_Staff == id).FirstOrDefault();
            db.Staffs.DeleteOnSubmit(staff_);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                Staff staff = db.Staffs.Where(s => s.Id_Staff == id).FirstOrDefault();
                if (staff != null)
                {
                    Staff staff_ = new Staff()
                    {
                    Id_Staff = staff.Id_Staff,
                    Email_Staff = staff.Email_Staff,
                    Name = staff.Name,
                    Gender = staff.Gender,
                    Phone = staff.Phone,
                    Specialization = staff.Specialization,
                };
                    return View(staff_);
                }
            }
            return View("Error");
        }
    }
}