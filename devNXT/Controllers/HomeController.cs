using devNXT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace devNXT.Controllers
{
    public class HomeController : Controller
    {
        
      
		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		[HttpGet]
        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

		[HttpGet]
        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public IActionResult Index(UserProfile model)
        {

            // var s = cbe.GetCBLoginInfo(model.UserName, model.Password);
	    //test
            string item = string.Empty;
            if (model.UserName == "admin" && model.Password == "admin")
                item = "Success";
            else
                item = "User Does not Exists";
            if (item == "Success")
            {

                return RedirectToAction("CreateUser","Home");
            }
            else if (item == "User Does not Exists")

            {
                ViewBag.NotValidUser = item;

            }
            else
            {
                ViewBag.Failedcount = item;
            }

            return View("Index");
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
           
            DataTable dt5 = new DataTable();
            dt5.Clear();
            dt5.Columns.Add("EmailId");
            dt5.Columns.Add("ProjectName");
            dt5.Columns.Add("FirstName");
            dt5.Columns.Add("LastName");
            dt5.Columns.Add("Contactsdetails");
            DataRow _obj1 = dt5.NewRow();
            _obj1["EmailId"] = "rashmi@wipro.com";
            _obj1["ProjectName"] = "devNxt";
            _obj1["FirstName"] = "Rashmi";            
            _obj1["LastName"] = "Yadav";
            _obj1["Contactsdetails"] = "9878978977";
            dt5.Rows.Add(_obj1);
            DataRow _obj2 = dt5.NewRow();
            _obj2["EmailId"] = "rasmita@wipro.com";
            _obj2["ProjectName"] = "devNxt";
            _obj2["FirstName"] = "Rasmita";
            _obj2["LastName"] = "Jena";
            _obj2["Contactsdetails"] = "9977678674";
            dt5.Rows.Add(_obj2);
            DataRow _obj3 = dt5.NewRow();
            _obj3["EmailId"] = "abhishek@wipro.com";
            _obj3["ProjectName"] = "devNxt";
            _obj3["FirstName"] = "Abhishek";
            _obj3["LastName"] = "Vats";
            _obj3["Contactsdetails"] = "8976567832";
            dt5.Rows.Add(_obj3);
          
            DataRow _obj4 = dt5.NewRow();
            _obj4["EmailId"] = "abhilasha@wipro.com";
            _obj4["ProjectName"] = "devNxt";
            _obj4["FirstName"] = "Abhilasha";
            _obj4["LastName"] = "Ghosh";
            _obj4["Contactsdetails"] = "8665566789";
            dt5.Rows.Add(_obj4);


            List<User> lstUsers = new List<User>();
            for (int i = 0; i < dt5.Rows.Count; i++)
            {
                User objUser = new User
                {
                    
                    EmailId = dt5.Rows[i]["EmailId"].ToString(),
                    ProjectName = dt5.Rows[i]["ProjectName"].ToString(),
                    FirstName = dt5.Rows[i]["FirstName"].ToString(),
                    LastName = dt5.Rows[i]["LastName"].ToString(),
                    Contactsdetails = dt5.Rows[i]["Contactsdetails"].ToString(),
                   
                };
                lstUsers.Add(objUser);
            }

          

            
            return View(lstUsers);
        }
    }
}
