using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace _ITI.Controllers
{
    public class StaffController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        // GET: Staff
        public ActionResult Index()
        {
            return View(db.Courses);
        }

        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(Staff log)
        {
            Staff log_ = db.Staffs.Where(s => s.Id_Staff == log.Id_Staff && s.Email_Staff == log.Email_Staff).FirstOrDefault();
            if (log_.Email_Staff != null)
            {
                return View("Index");
            }
                return View("Error");
        }

        public ActionResult Create_Course()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create_Course(Course course)
        {
            if (ModelState.IsValid)
            {

                Course course_ = new Course();
                if (course_ != null)
                {
                    course_.Id_Courses = course.Id_Courses;
                    course_.Name = course.Name;
                    course_.Concept = course.Concept;
                    course_.Date = course.Date;
                    db.Courses.InsertOnSubmit(course_);
                    db.SubmitChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(course);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                Course co = db.Courses.Where(e => e.Id_Courses == id).FirstOrDefault();
                if (co != null)
                {
                    return View(co);
                }
            }
            return View("Error");

        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(Course course)
        {
            Course course_ = db.Courses.Where(s => s.Id_Courses == course.Id_Courses).FirstOrDefault();
            if (course_ != null)
            {
                course_.Name = course.Name;
                course_.Date = course.Date;
                course_.Concept = course.Concept;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var emp = db.Courses.Where(e => e.Id_Courses == id).FirstOrDefault();
            return View(emp);
            //if (id != null)
            //{
            //    Course course = db.Courses.Where(s => s.Id_Courses == id).FirstOrDefault();
            //    if (course != null)
            //    {
            //        return View(course);
            //    }
            //}
            //return View("Error");
        }

        [HttpPost]
        public ActionResult Delete(int id, Course course)
        {
            //Course course_ = db.Courses.Where(s => s.Id_Courses == course.Id_Courses).FirstOrDefault();
            //if(course_!=null)
            //{
            //    db.Courses.DeleteOnSubmit(course_);
            //    db.SubmitChanges();
            //    return RedirectToAction("Index");
            //}
            Course emp = db.Courses.Where(e => e.Id_Courses == id).FirstOrDefault();
            db.Courses.DeleteOnSubmit(emp);
            db.SubmitChanges();
            return RedirectToAction("Index");
            //return View("Error");
        }

        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                Course course = db.Courses.Where(s => s.Id_Courses == id).FirstOrDefault();
                if (course != null)
                {
                    Course course_ = new Course()
                    {
                        Name = course.Name,
                        Concept = course.Concept,
                        Date = course.Date
                    };
                    return View(course_);
                }
            }
            return View("Error");
        }

        public ActionResult Questions()
        {
            return View(db.Questions_Answers);
        }
        
        [HttpGet]
        public ActionResult Answer(int? id)
        {
            if (id != null)
            {
                Questions_Answer co = db.Questions_Answers.Where(e => e.Id_Ask == id).FirstOrDefault();
                if (co != null)
                {
                    return View(co);
                }
            }
            return View("Error");

        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Answer(Questions_Answer Answer)
        {
            Questions_Answer Answer_ = db.Questions_Answers.Where(s => s.Id_Ask == Answer.Id_Ask).FirstOrDefault();
            if (Answer_ != null)
            {
                Answer_.Ask = Answer.Ask;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View(Answer);
        }

        [HttpGet]
        public ActionResult Files()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Files(HttpPostedFileBase file)
        {
            //string path = Server.MapPath("~/App_Data/File");
            //string fileName =Path.GetFileName(file.FileName);
            //string fullPath = Path.Combine(path, fileName);
            //file.SaveAs(fullPath);

            return View();
        }
    }
}