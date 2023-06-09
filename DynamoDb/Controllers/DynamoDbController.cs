using Microsoft.AspNetCore.Mvc;

namespace DynamoDb.Controllers;

[ApiController]
[Route("[controller]")]
public class DynamoDbController : ControllerBase
{
    
    [HttpGet(Name = "GetData")]
    public string Get()
    {
        return "Test Data";
    }
}