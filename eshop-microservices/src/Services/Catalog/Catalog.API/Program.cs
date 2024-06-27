var builder = WebApplication.CreateBuilder(args);

//Add Service To  the Containter
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
config.RegisterServicesFromAssemblies(typeof(Program).Assembly)
    );
builder.Services.AddMarten(opts =>
opts.Connection(builder.Configuration.GetConnectionString("Database")!)
    ).UseLightweightSessions();
var app = builder.Build();

//Configure HTTP request pipeline
app.MapCarter();
app.Run();
