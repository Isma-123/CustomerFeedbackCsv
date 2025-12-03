
using Microsoft.EntityFrameworkCore;
using ReadClientsComments.cs.Models.Context;
using ReadClientsComments.cs.Models.Interfaces;
using ReadClientsComments.cs.Models.Repository;

namespace ReadClientsComments.cs
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
          

             builder.Services.AddDbContext<StockContext>(options
                => options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

            builder.Services.AddScoped<IClientRepository, CLientRepository>(); 
            builder.Services.AddScoped<IProductsRepository, ProductRepository>();
            builder.Services.AddScoped<ISocialCommentsRepository, SocialCommentsRepository>();  

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
