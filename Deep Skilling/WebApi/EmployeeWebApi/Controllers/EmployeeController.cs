using EmployeeWebApi.Filters;
using EmployeeWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = GetStandardEmployeeList();

    private static List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
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
                DateOfBirth = new DateTime(1998, 5, 10)
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
                DateOfBirth = new DateTime(1999, 8, 15)
            }
        };
    }

    // GET ALL
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> Get()
    {
        // Uncomment this line only while testing CustomExceptionFilter
        // throw new Exception("Employee Exception Generated");

        return Ok(employees);
    }

    // GET BY ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Employee> Get(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        return Ok(employee);
    }

    // POST
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        employees.Add(employee);
        return Ok(employee);
    }

    // PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
    {
        var existing = employees.FirstOrDefault(e => e.Id == id);

        if (existing == null)
            return NotFound();

        existing.Name = employee.Name;
        existing.Salary = employee.Salary;
        existing.Permanent = employee.Permanent;
        existing.Department = employee.Department;
        existing.Skills = employee.Skills;
        existing.DateOfBirth = employee.DateOfBirth;

        return Ok(existing);
    }
}