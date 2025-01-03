namespace BooksApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //add services
            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyCors", builder =>
                {
                    builder
                    .WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            var app = builder.Build();

            app.UseCors("MyCors");


            //add mappings

            //app.MapGet("/", () => "Hello World!");

            app.MapControllers();
            
            //default mapping to /api/books
            app.MapGet("/", () =>
            {
                return Results.Redirect("/api/books");
            });
            app.Run();
        }
    }
}
