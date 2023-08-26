using FacebookClone.API;

var builder = WebApplication.CreateBuilder(args);

var app = builder
    .ConfigureServices()
    .ConfigureRequestPipeline();



app.Run();
