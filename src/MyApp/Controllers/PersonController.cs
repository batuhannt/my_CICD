using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController:ControllerBase
{
    private AppDbContext _appDbContext;

    public PersonController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContexts;
    }

    [HttpGet()]
    public ActionResult<IEnumerable<Person>> Get()
    {
        return _appDbContext.Persons.ToList();
    }
    
    [HttpPost()]
    public ActionResult Post([FromBody] Person person)
    { 
        _appDbContext.Persons.Add(person);
        return Ok();
    }
}