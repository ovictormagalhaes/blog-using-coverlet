public interface IEmployeeRepository
{
    Task Add(EmployeeAggregate employee);
}

public class EmployeeRepository : IEmployeeRepository
{
    public Task Add(EmployeeAggregate employee)
    {
        //(...)   
        throw new NotImplementedException();
    }
}
