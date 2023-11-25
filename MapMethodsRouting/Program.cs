var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//It's only work for Get methods
//app.MapGet("/Home", () => "Hello World! -- GET");
//app.MapPost("/Home", () => "Hello this is -- Post");
//app.MapPut("/Home", () => "Hello this is -- Put");
//app.MapDelete("/Home", () => "Hello this is -- Delete");

/* Routing inside & middleware */

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // Only one method is running at one times

    endpoints.MapGet("/Home", async (context) =>
     {
            await context.Response.WriteAsync("This is Home Page....Get ");


     });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page....Post ");


    });

    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page....Put ");


    });

    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page....Delete ");
    });
});
// For defult routing exmp [ https://localhost:7094/]
app.Run(async (HttpContext Context) =>
{
    await Context.Response.WriteAsync("Page Not Found.");

});



app.Run();
