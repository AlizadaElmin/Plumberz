using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Plumberz.BL.Services.Abstracts;
using Plumberz.BL.ViewModels.EmployeeVMs;

namespace PlumberzProject.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles ="Admin")]
public class EmployeeController(IEmployeeService _service,IWebHostEnvironment _env):Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await _service.GetEmployees());
    }
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(EmployeeCreateVM vm)
    {
        string destination = _env.WebRootPath;
        await _service.CreateEmployee(vm,destination);
        return RedirectToAction("Index");
    }

    public IActionResult Update(int id) 
    { 
        if(id == 0)
        {
            throw new Exception();
        }
        }
    [HttpPost]
    public async Task<IActionResult> Update(int id,EmployeeUpdateVM vm)
    {
        string destination = null;
        if (vm.Image != null) 
            destination = _env.WebRootPath;
        await _service.UpdateEmployee(id, vm, destination);
        return RedirectToAction("Index");
    }
}
