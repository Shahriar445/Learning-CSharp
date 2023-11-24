var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//Defult middleware
/*app.MapGet("/", () => "Hello World!");*/


// first middleware Use function have two parameter  one is context and next function
app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("Hy it's beginne middleware - 1 \n");
   await next(context);
});

// second middleware 
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hy it's  middleware - 2 \n");
    await next(context);
});

//after run method we can't create any middleware 
// Run method have only one parameter only context 
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hy it's end of middleware");
});

app.Run(); // this run method is used for run the server then run all the middle ware 
