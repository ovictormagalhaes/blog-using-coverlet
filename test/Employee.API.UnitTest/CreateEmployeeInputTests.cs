namespace Employee.API.UnitTest;

public class CreateEmployeeInputTests
{
    [Fact]
    public void ShouldBeSetPropertiesCorrectly()
    {
        var name = "Victor";
        var document = "111222333";

        var createEmployeeeInput = new global::CreateEmployeeInput(name, document);

        Assert.Equal(name, createEmployeeeInput.Name);
        Assert.Equal(document, createEmployeeeInput.Document);
    }
}