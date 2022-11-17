using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;

namespace MvcWebApp.Controllers
{
    public class StudentController : Controller
    {

        private static List<Student> products = new List<Student>();

        public StudentController()
        {
            if (products.Count == 0)
            {
                products.Add(new Student() { Id = "111", Name = "Duy", Age = 18, Email = "student@tdtu.edu.vn" });
                products.Add(new Student() { Id = "222", Name = "Loan", Age = 18, Email = "student@tdtu.edu.vn" });
                products.Add(new Student() { Id = "333", Name = "Anh", Age = 18, Email = "student@tdtu.edu.vn" });
                products.Add(new Student() { Id = "444", Name = "Minh", Age = 18, Email = "student@tdtu.edu.vn" });

            }
        }

        
        public ActionResult Index()
        {
            return View(products);
        }

       

        // GET: ProductManagement/Edit/5
        public ActionResult Edit(string id)
        {
            Student p = products.FirstOrDefault(p => p.Id == id);
            if (p == null)
            {
                return RedirectToAction("Index");
            }
            else return View(p);
        }

        // POST: ProductManagement/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Student s)
        {
            Student p = products.FirstOrDefault(p => p.Id == id);
            if (p != null)
            {
                p.Name = s.Name;
                p.Age = s.Age;
                p.Email = s.Email;
            }
            

            return RedirectToAction("Index");
        }
    }
}
