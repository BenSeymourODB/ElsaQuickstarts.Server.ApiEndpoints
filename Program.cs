//var builder = WebApplication.CreateBuilder(args);
var builder = CreateHostBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();


static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<ElsaQuickstarts.Server.ApiEndpoints.Startup>();
                });