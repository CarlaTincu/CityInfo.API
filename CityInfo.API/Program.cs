var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting(); // marks the position in the middleware pipeline where a routing decision is made
app.UseAuthorization(); // injected??
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
}); // mark the position in the middleware pipeline where the selected endpoint is executed
app.Run();
