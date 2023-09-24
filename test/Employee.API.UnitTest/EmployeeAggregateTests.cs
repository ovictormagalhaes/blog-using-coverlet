namespace Employee.API.UnitTest;

public class EmployeeAggregateTests
{
    [Fact]
    public void ShouldBeSetPropertiesCorrectly()
    {
        // Arrange
        var id = Guid.NewGuid();
        var name = "Victor";
        var document = "11122233344";

        // Act
        var employee = new EmployeeAggregate
        {
            Id = id,
            Name = name,
            Document = document
        };

        // Assert
        Assert.Equal(id, employee.Id);
        Assert.Equal(name, employee.Name);
        Assert.Equal(document, employee.Document);
    }

    [Fact]
    public void CreateEmployeeInput_RecordsAreEqual()
    {
        // Arrange
        var employeeInput1 = new CreateEmployeeInput("Victor", "11122233344");
        var employeeInput2 = new CreateEmployeeInput("Victor", "11122233344");

        // Act & Assert
        Assert.Equal(employeeInput1, employeeInput2);
    }
}

