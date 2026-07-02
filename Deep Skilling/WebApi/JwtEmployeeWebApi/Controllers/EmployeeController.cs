using JwtEmployeeWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtEmployeeWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "POC")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "John",
            Salary = 50000,
            Permanent = true,
            Department = new Department
            {
                Id = 1,
                Name = "IT"
            },
            Skills = new List<Skill>
            {
                new Skill { Name = "C#" },
                new Skill { Name = "SQL" }
            },
            DateOfBirth = new DateTime(1998,5,10)
        },

        new Employee
        {
            Id = 2,
            Name = "David",
            Salary = 45000,
            Permanent = false,
            Department = new Department
            {
                Id = 2,
                Name = "HR"
            },
            Skills = new List<Skill>
            {
                new Skill { Name = "Communication" }
            },
            DateOfBirth = new DateTime(1999,8,15)
        }
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(employees);
    }
}