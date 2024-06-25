var builder = WebApplication.CreateBuilder(args);

//Add Service To  the Containter
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
config.RegisterServicesFromAssemblies(typeof(Program).Assembly)
    );
var app = builder.Build();

//Configure HTTP request pipeline
app.MapCarter();
app.Run();
