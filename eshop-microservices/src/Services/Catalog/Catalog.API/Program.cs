var builder = WebApplication.CreateBuilder(args);

//Add Service To  the Containter
var app = builder.Build();

//Configure HTTP request pipeline

app.Run();
