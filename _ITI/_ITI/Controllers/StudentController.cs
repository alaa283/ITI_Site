using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _ITI.Controllers
{
    public class StudentController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Courses);
        }

        public ActionResult Register_Account()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register_Account(Student student)
        {
            if (ModelState.IsValid)
            {
                Student student_ = new Student();
                if (student_ != null)
                {
                    student_.Id_Student = student.Id_Student;
                    student_.Name = student.Name;
                    student_.Email_Student = student.Email_Student;
                    student_.Gender = student.Gender;
                    db.Students.InsertOnSubmit(student_);
                    db.SubmitChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(student);
        }


        public ActionResult Register_Course()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register_Course(Register student)
        {
            Register student_ = new Register();
            student_.Id = student.Id;
            student_.Name = student.Name;
            student_.Email_Student = student.Email_Student;
            student_.Phone = student.Phone;
            student_.city = student.city;
            student_.faculty = student.faculty;
            student_.specialization = student.specialization;
            student_.graduation_year = student.graduation_year;
            db.Registers.InsertOnSubmit(student_);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login( Student log)
        {

            //var Getlogin = select * from Register where log.Name=_n
            //    return View("Index");
            var det = db.Students.Where(s => s.Name == log.Name && s.Id_Student == log.Id_Student).FirstOrDefault();
            if (det.Name== null)
            {
                return View("Error");
            }
            return RedirectToAction("Index");
        }
    }
}