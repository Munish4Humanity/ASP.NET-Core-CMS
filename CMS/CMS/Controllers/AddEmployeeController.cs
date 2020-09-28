using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CMS.Models;
using CMS.Models.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
namespace CMS.Controllers
{
    public class AddEmployeeController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View(Employee);
        }
    }
}