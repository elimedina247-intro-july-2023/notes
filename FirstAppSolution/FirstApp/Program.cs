using FirstApp.Models;

Console.WriteLine("Starting up The API");
var builder = WebApplication.CreateBuilder(args);
//Configuration for the API will go here.


Console.WriteLine("About to Start the API");

var app = builder.Build();
//GET /sayhi
//Then return Ok 
app.MapGet("/sayhi", () =>
{
    return Results.Ok("Yep! Hello, Good To See You!");
});


app.MapGet("/status", () =>
{
    var response = new StatusResponseModel(DateTime.Now, "Looks good", "Operating Normally");
    return Results.Ok(response);
    //Ok converts to JSON
});
app.MapGet("/todo-list", () =>
{
    var response = new List<TodoItemModel>()
    {
        new TodoItemModel(Guid.NewGuid(), "Buy Beer", "Later"),
        new TodoItemModel(Guid.NewGuid(), "Buy more beer", "Waiting")

    };
    return Results.Ok(response);
    //Ok converts to JSON
});

app.Run(); //Blocking call - this will start the sever and run FOREVER (Or until we kill it)

Console.WriteLine("API is down.");