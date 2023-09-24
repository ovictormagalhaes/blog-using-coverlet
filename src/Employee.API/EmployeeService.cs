public interface IEmployeeService
{
    Task Add(CreateEmployeeInput input);
}

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public Task Add(CreateEmployeeInput input)
    {
        //(...)
        throw new NotImplementedException();
    }
}
