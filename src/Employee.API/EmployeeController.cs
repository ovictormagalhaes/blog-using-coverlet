using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/employees")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateEmployeeInput input)
    {
        //(...)
        throw new NotImplementedException();
    }
}
