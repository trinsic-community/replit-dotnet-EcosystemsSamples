var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTrinsic(options => options.AuthToken = "<insert auth token>");

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run();
