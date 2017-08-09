using ES.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ES.UI.Controllers
{
    public class ExamController : Controller
    {
        IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        // GET: Exam
        public ActionResult Index()
        {
            var exam = _examService.GetExamById(1);

            return View(exam);
        }

        // GET: Exam/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exam/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exam/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Exam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
