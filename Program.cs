namespace BooksApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //add services
            builder.Services.AddControllers();

            var app = builder.Build();

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
