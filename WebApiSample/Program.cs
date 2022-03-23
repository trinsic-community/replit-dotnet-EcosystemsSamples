var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTrinsic(options => {
  // configure server auth token
  options.AuthToken = Environment.GetEnvironmentVariable("AUTH_TOKEN")
    ?? throw new("AuthToken not set. Please update the .replit file or set the environment variable AUTH_TOKEN");
});

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run();
