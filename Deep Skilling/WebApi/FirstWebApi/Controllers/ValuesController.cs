using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    private static List<string> products = new()
    {
        "Laptop",
        "Mouse",
        "Keyboard"
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (id < 0 || id >= products.Count)
            return NotFound();

        return Ok(products[id]);
    }

    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
        products.Add(value);
        return Ok($"{value} Added Successfully");
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
        if (id < 0 || id >= products.Count)
            return NotFound();

        products[id] = value;
        return Ok($"{value} Updated Successfully");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id < 0 || id >= products.Count)
            return NotFound();

        products.RemoveAt(id);
        return Ok("Deleted Successfully");
    }
}