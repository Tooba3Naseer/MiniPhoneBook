using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using WebApplication2.Models;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.Entity.Validation;
using Microsoft.AspNet.Identity;
using System.Net;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public String constr = "Data Source=ELITEBOOKHP;Initial Catalog=PhoneBookDb;User ID=sa;Password=***********";

        string con = ConfigurationManager.ConnectionStrings["PhoneBookDbEntities1"].ConnectionString;
        public ActionResult Index()
        {

            return View();
            
        }

      

        // this is for viewing the webpages

        public ActionResult AddPerson()
        {
            return View();
        }

        public ActionResult EditPerson()
        {
            return View();
        }

        public ActionResult ViewPerson()
        {
            return View();
        }

        public ActionResult DeletePerson()
        {
            return View();
        }

        public ActionResult AddContact()
        {
            return View();
        }
        // add person into database
        [HttpPost]
        public ActionResult AddPerson(PersonViewModel collection)
        {
            try
            {
                Person person = new Person();
                person.FirstName = collection.FirstName;
                person.MiddleName = collection.MiddleName;
                person.LastName = collection.LastName;

                person.AddedOn = DateTime.Now;
                person.AddedBy = User.Identity.GetUserId();
                person.HomeAddress = collection.HomeAddress;
                person.HomeCity = collection.HomeCity;
                person.EmailId = collection.EmailId;
                person.FaceBookAccountId = collection.FacebookId;
                person.UpdateOn = DateTime.Now;
                person.LinkedInId = collection.LinkedInId;
                person.TwitterId = collection.TwitterId;

                PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
                if (ModelState.IsValid)
                {
                    db.People.Add(person);
                    db.SaveChanges();



                    return RedirectToAction("Index");
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Index"); 
            }
            return RedirectToAction("Index");
        }


      

        [HttpPost]
        public ActionResult AddContact(Contact collection)
        {
            try
            {
                Contact contact = new Contact();
                contact.ContactNumber = collection.ContactNumber;
                contact.Type = collection.Type;
                PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
                if (ModelState.IsValid)
                {
                    db.Contacts.Add(contact);
                    db.SaveChanges();



                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        
      

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}