using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Plumberz.BL.Exceptions.Deparment;
using Plumberz.BL.Services.Abstracts;
using Plumberz.BL.ViewModels.DepartmentVMs;
using Plumberz.BL.ViewModels.EmployeeVMs;
using Plumberz.Core.Models;
using Plumberz.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Services.Implements;

public class DepartmentService(PlumberzDbContext _context,IMapper _mapper): IDepartmentService
{

    public async Task CreateDepartment(DepartmentCreateVM dto)
    {
        if (dto == null) throw new DepartmentNotFound();
        Department department = _mapper.Map<Department>(dto);
        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteDepartment(int id)
    {
        Department? department = await _context.Departments.FindAsync(id);
        if (department == null) throw new DepartmentNotFound();
        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();
    }

    public async Task<DepartmentVM> GetDepartment(int id)
    {
        Department? department = await _context.Departments.FindAsync(id);
        if (department == null) throw new DepartmentNotFound();
        DepartmentVM departmentVM = _mapper.Map<DepartmentVM>(department);
        return departmentVM;
    }

    public async Task<ICollection<DepartmentVM>> GetDepartments()
    {
        ICollection<Department> departments = await _context.Departments.ToListAsync();
        if (departments == null) throw new DepartmentNotFound();
        ICollection<DepartmentVM> departmentsVM = _mapper.Map<ICollection<DepartmentVM>>(departments);
        return departmentsVM;
    }

    public async Task UpdateDepartment(int id, DepartmentUpdateVM dto)
    {
        Department? department = await _context.Departments.FindAsync(id);
        if (department == null) throw new DepartmentNotFound();
        _mapper.Map(dto, department);
        await _context.SaveChangesAsync();
    }
}
