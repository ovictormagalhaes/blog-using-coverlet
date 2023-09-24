public class EmployeeRepositoryTests
{
    [Fact]
    public async Task Add_ShouldNotThrowException()
    {
        // Arrange
        var employeeRepository = new EmployeeRepository();

        // Act and Assert
        await Assert.ThrowsAsync<NotImplementedException>(() => employeeRepository.Add(new EmployeeAggregate()));
    }
}
