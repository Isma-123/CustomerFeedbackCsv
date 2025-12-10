using ApplicacionClientComments.cs.Interfaces;
using ApplicacionClientComments.cs.Repository;
using Microsoft.EntityFrameworkCore;
using PersistanceClientComments.Csv;
using PersistanceClientComments.Db.Context;
using PersistanceClientComments.Db.Repository.cs;

namespace WorkClientCommenetcsv
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);


            // add dependency injection      



            builder.Services.AddDbContext<DwbhContext>(option => 
            option.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

            builder.Services.AddScoped<FileReaderCsv, FileReaderCsv>();
            builder.Services.AddScoped<IDwhServices, DwbRepository>();
            builder.Services.AddScoped<IHandlerServices, ApplicacionClientComments.cs.Services.HandlerServices>();



            builder.Services.AddHostedService<Worker>();

            var host = builder.Build();
            host.Run();
        }
    }
}