using Moq;

public class EmployeeServiceTests
{
    [Fact]
    public async Task Add_ShouldNotThrowException()
    {
        // Arrange
        var input = new CreateEmployeeInput("", "");
        var employeeRepository = new Mock<IEmployeeRepository>();
        var employeeService = new EmployeeService(employeeRepository.Object);

        // Act and Assert
        await Assert.ThrowsAsync<NotImplementedException>(() => employeeService.Add(input));
    }
}
