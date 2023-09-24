using Microsoft.AspNetCore.Mvc;
using Moq;

public class EmployeeControllerTests
{
    [Fact]
    public async Task Create_ShouldReturnNotImplementedResult()
    {
        // Arrange
        var input = new CreateEmployeeInput("", "");
        var mockEmployeeService = new Mock<IEmployeeService>();
        var controller = new EmployeeController(mockEmployeeService.Object);

        // Act and assert
        await Assert.ThrowsAsync<NotImplementedException>(() => controller.Create(input));
    }
}
