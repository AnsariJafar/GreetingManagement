using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreetingManagement.BusinessLogic.Repositories.Impl;
using GreetingManagement.BusinessLogic.Repositories.Interface;
using GreetingManagement.Models;
using GreetingManagement.WebUI.Models;

namespace GreetingManagement.WebUI.Controllers
{
    public class GreetingController : Controller
    {
        private readonly IGreetingRepository greetingRepository;
        public GreetingController()
        {
            greetingRepository = new GreetingRepository() as IGreetingRepository;
        }
        // GET: Greeting
        public ActionResult Index()
        {
            var greetingList = greetingRepository.GetAll().Where(x => x.IsActive == true);
            var greetingVMList = greetingList.Select(x => new GreetingViewModel()
            {
                Contact=x.Contact,
                DOB=x.DOB.ToString("dd-MMM-yyyy"),
                DOJ=x.DOJ.ToString("dd-MMM-yyyy"),
                Email=x.Email,
                Id=x.Id,
                Name=$"{x.FirstName}   {x.LastName}"


            });
            return View(greetingVMList);
        }

        // GET: Greeting/Details/5
        public ActionResult Details(int id)
        {
            var greetingObject = greetingRepository.GetById(id);
            return View(greetingObject);
        }

        // GET: Greeting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Greeting/Create
        [HttpPost]
        public ActionResult Create(Greeting greeting )
        {
            try
            {
                greeting.IsActive = true;
                greeting.IsProcessed = false;

                greetingRepository.Insert(greeting);
                greetingRepository.Save();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Greeting/Edit/5
        public ActionResult Edit(int id)
        {
           var greetingObject = greetingRepository.GetById(id);
            return View(greetingObject);
        }

        // POST: Greeting/Edit/5
        [HttpPost]
        public ActionResult Edit( Greeting greeting  )
        {
            try
            {
                greetingRepository.Update(greeting);
                greetingRepository.Save();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Greeting/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(greetingRepository.GetAll().FirstOrDefault(x => x.Id == id));
        }

        // POST: Greeting/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var greetingObject = greetingRepository.GetAll().FirstOrDefault(x => x.Id == id);

                greetingObject.IsActive = false;

                greetingRepository.Update(greetingObject);
                greetingRepository.Save();
                return RedirectToAction("Index");
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
