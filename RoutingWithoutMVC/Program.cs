var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // first add this service for routing 
var app = builder.Build();

////Defult routing 
//app.MapGet("/", () => "Hello World!");


/*
           Convention Routing 
 
// app.MapDefaultControllerRoute();  Defult convention routing 

 
app.MapControllerRoute(

    name: "defult",
    pattern: "{controller=Home}/{action=About}/{id?}"


    );

*/


// for Attribute Based routing i need to add middleware route first

app.MapControllers();


app.Run();
