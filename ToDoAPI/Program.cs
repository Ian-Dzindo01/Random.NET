using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;
using ToDoAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => 
    opt.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

var app = builder.Build();

// app.UseHttpsRedirection();

// GET Endpoint. Return all todo's
app.MapGet("api/todo", async (AppDbContext context) =>
{
    var items = await context.ToDos.ToListAsync();

    return Results.Ok(items);
});

// POST Enpoint
app.MapPost("api/todo", async(AppDbContext context, ToDo toDo) => 
{   // Add checking to make it prod level
    await context.ToDos.AddAsync(toDo);

    await context.SaveChangesAsync();

    return Results.Created($"api/todo{toDo.Id}", toDo);

});

// UPDATE Endpoint
app.MapPut("api/todo/{id}", async (AppDbContext context, int id, ToDo toDo) => {

    var toDoModel = await context.ToDos.FirstOrDefaultAsync(t => t.Id == id);

    if (toDoModel == null)
    {
        return Results.NotFound();
    }

    toDoModel.ToDoName = toDo.ToDoName;

    await context.SaveChangesAsync();

    return Results.NoContent();

});

// DELETE endpoint
app.MapDelete("api/todo/{id}", async (AppDbContext context, int id, ToDo toDo) => {

    var toDoModel = await context.ToDos.FirstOrDefaultAsync(t => t.Id == id);

    if (toDoModel == null)
    {
        return Results.NotFound();
    }

    context.ToDos.Remove(toDoModel);

    await context.SaveChangesAsync();

    return Results.NoContent();
});




app.Run();
