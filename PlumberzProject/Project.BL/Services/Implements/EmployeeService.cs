using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Plumberz.BL.Exceptions.Employee;
using Plumberz.BL.Extensions;
using Plumberz.BL.Services.Abstracts;
using Plumberz.BL.ViewModels.EmployeeVMs;
using Plumberz.Core.Enums;
using Plumberz.Core.Models;
using Plumberz.DAL.Context;

namespace Plumberz.BL.Services.Implements;

public class EmployeeService(PlumberzDbContext _context,IMapper _mapper) : IEmployeeService
{
    public async Task CreateEmployee(EmployeeCreateVM dto,string destination)
    {
       if (dto == null) throw new EmployeeNotFound();
       Employee employee = _mapper.Map<Employee>(dto);
       employee.Role = (int)Roles.Doctor;
       employee.ImageUrl = await dto.Image.UploadAsync(destination,"imgs","employees");
       await _context.Employees.AddAsync(employee);
       await _context.SaveChangesAsync();
    }

    public async Task DeleteEmployee(int id)
    {
        Employee? employee = await  _context.Employees.FindAsync(id);
        if (employee == null) throw new EmployeeNotFound();
        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
    }

    public async Task<EmployeeVM> GetEmployee(int id)
    {
        Employee? employee = await _context.Employees.FindAsync(id);
        if (employee == null) throw new EmployeeNotFound();
        EmployeeVM employeeDto = _mapper.Map<EmployeeVM>(employee);
        return employeeDto;
    }

    public async Task<ICollection<EmployeeVM>> GetEmployees()
    {
        ICollection<Employee> employees =await _context.Employees.ToListAsync();
        if (employees == null) throw new EmployeeNotFound();
        ICollection<EmployeeVM> employeesDto = _mapper.Map<ICollection<EmployeeVM>>(employees);
        return employeesDto;
    }

    public async Task UpdateEmployee(int id, EmployeeUpdateVM dto,string? destination)
    {
        Employee? employee = await _context.Employees.FindAsync(id);
        if (employee == null) throw new EmployeeNotFound();
        if (dto.Image != null && destination != null) 
        {
            employee.ImageUrl = await dto.Image.UploadAsync(destination, "imgs", "employees");
        }
        _mapper.Map(dto,employee);
        await _context.SaveChangesAsync();
    }
}
