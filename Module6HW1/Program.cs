using Module6HW1.Service;
using Module6HW1.Store;
using Module6HW1.Interface.Service;
using Module6HW1.Interface.Store;
namespace Module6HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<MovieContext>();
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddSingleton<IMovieStore, MovieStore>();
            
         //   builder.Services.AddControllers();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{id?}");
            app.MapControllers();

            app.Run();
        }
    }
}