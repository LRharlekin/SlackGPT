var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddControllers();
}

var app = builder.Build();

{
    app.UseAuthorization();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}