using CS2Scout.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var faceitConfig = builder.Configuration.GetSection("Faceit");
var apiKey = faceitConfig["ApiKey"];
var baseUrl = faceitConfig["BaseUrl"];

builder.Services.AddHttpClient<IFaceitService, FaceitService>(client =>
{
    client.BaseAddress = new Uri(baseUrl!);
    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddScoped<IPlayerRoleService, PlayerRoleService>(); 


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
