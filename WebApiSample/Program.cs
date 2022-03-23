var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTrinsic(options => {
  // configure server auth token
  options.AuthToken = Environment.GetEnvironmentVariable("AUTH_TOKEN");
});

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run();
