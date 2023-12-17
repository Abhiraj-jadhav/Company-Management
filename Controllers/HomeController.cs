//using DempApp2.Data;
// using AspNetCore;
using DempApp2.Model;
//using.DempApp2.Model.Dept;
using Microsoft.AspNetCore.Mvc;
namespace DempApp2.Controllers;

public class HomeController : Controller
{
    // [HttpPost]
    public IActionResult HomeLion()
    {
        return View();
    }

    public IActionResult OnPost()
    {
        return View();
    }

    
    public IActionResult Employee([FromServices] SiteDbContext site)
    {
        var selection = from e in site.Employee_03
                        select new EmpInfo 
                        {
                            EmpNo= e.Id,
                            EmpName= e.ename,
                             Empsal=e.esal,
                             Empdept =e.deptId
                           
                        };
        return View(selection.ToList()); //~/Views/<current-controller-name>/<current-action-name>.cshtml
    }

    public IActionResult Register()
    {
        return View(new Emp());
    }

    [HttpPost]
    public IActionResult Register([FromServices] SiteDbContext site, Emp input)
    {
        if(ModelState.IsValid)
        {
           
            site.Employee_03.Add(input);
            site.SaveChanges();
            return RedirectToAction("Employee");
        }
        return Register();
    }


    public IActionResult Depart([FromServices] SiteDbContext site)
    {
        var selection = from e in site.Department_03
                        select new DeptInfo 
                        {
                            DEPTID= e.Id,
                            Dname= e.dname,
                            Dloc=e.dloc
                           
                        };
        return View(selection.ToList()); //~/Views/<current-controller-name>/<current-action-name>.cshtml
    }

    public IActionResult DRegister()
    {
        return View(new Dept());
    }

    [HttpPost]
    public IActionResult DRegister([FromServices] SiteDbContext site, Dept input)
    {
        if(ModelState.IsValid)
        {
           
            site.Department_03.Add(input);
            site.SaveChanges();
            return RedirectToAction("Depart");
        }
        return RedirectToAction("Depart");
    }



public IActionResult asd()
    {
        return View(new Emp());
    }


[HttpPost]
public IActionResult asd([FromServices] SiteDbContext site, Emp delete)
    {
        var emp1=site.Employee_03.Find(delete.Id);
        if(emp1 is not null)
        {
           
            site.Employee_03.Remove(emp1);
            site.SaveChanges();
            return RedirectToAction("Employee");
        }
        return RedirectToAction("Employee");
    }

public IActionResult Salchange()
    {
        return View(new Emp());
    }


[HttpPost]
public IActionResult Salchange([FromServices] SiteDbContext site, Emp up)
    {
        var emp2=site.Employee_03.Find(up.Id);
        if(emp2 is not null )
        {
            //  emp2.esal += up.esal;
             emp2.esal = up.esal;
            // site.Employee_02.Update(emp2);
            site.SaveChanges();
            return RedirectToAction("Employee");
        }
       // return NotFound();
      return RedirectToAction("Employee");
    }


    public IActionResult Dupdate()
    {
        return View(new Dept());
    }


[HttpPost]
public IActionResult Dupdate([FromServices] SiteDbContext site, Dept d)
    {
        var dep=site.Department_03.Find(d.Id);
        if(dep is not null )
        {
            //  emp2.esal += up.esal;
             dep.dloc = d.dloc;
            // site.Employee_02.Update(emp2);
            site.SaveChanges();
            return RedirectToAction("Depart");
        }
       // return NotFound();
    return RedirectToAction("Depart");
    }

    
 }

