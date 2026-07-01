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
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

        if (existingEmployee == null)
        {
            return BadRequest("Invalid employee id");
        }

        existingEmployee.Name = employee.Name;
        existingEmployee.Salary = employee.Salary;
        existingEmployee.Permanent = employee.Permanent;
        existingEmployee.Department = employee.Department;
        existingEmployee.Skills = employee.Skills;
        existingEmployee.DateOfBirth = employee.DateOfBirth;

        return Ok(existingEmployee);
    }

    // DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult Delete(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return BadRequest("Invalid employee id");
        }

        employees.Remove(employee);

        return Ok("Employee deleted successfully");
    }
}