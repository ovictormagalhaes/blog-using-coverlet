var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddControllers();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
