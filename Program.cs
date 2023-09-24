var builder = WebApplication.CreateBuilder(args);

// add services to the container
builder.Services.AddControllers();

var app = builder.Build();

// configure the http request pipeline
app.UseHttpsRedirection();

app.MapControllers();


// app.MapGet("/shirts", () =>
// {
//     return "Reading all shirts";
// });

// app.MapGet("/shirts/{id}", (int id) =>
// {
//     return $"Reading shirt with ID : {id}";
// });

// app.MapPost("/shirts", () =>
// {
//     return "Creating a shirt";
// });

// app.MapPut("/shirts/{id}", (int id) =>
// {
//     return $"Updating shirt with ID : {id}";
// });

// app.MapDelete("/shirts/{id}", (int id) =>
// {
//     return $"Deleating shirt with ID : {id}";
// });

app.Run();
