using Core;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<Middleware>();

//-------------------------------------------
// Custom middleware directly on this file
//-------------------------------------------
// app.Use(async(context, next) => 
// {
//     if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
//     {
//         context.Response.ContentType = "text/plain";
//         await context.Response.WriteAsync("Custom Middleware\n");
//     }
//     await next();
// });

app.MapGet("/", () => "Hello World!");

app.Run();
