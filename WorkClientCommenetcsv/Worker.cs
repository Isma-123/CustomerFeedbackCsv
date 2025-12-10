using ApplicacionClientComments.cs.Interfaces;
using ApplicacionClientComments.cs.Repository;
using PersistanceClientComments.Db.Context;

namespace WorkClientCommenetcsv
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                   using(var scope = _serviceProvider.CreateScope())
                   {
                        var handlerServices = scope.ServiceProvider.GetRequiredService<ApplicacionClientComments.cs.Interfaces.IHandlerServices>();
                        var result = await handlerServices.ProcessDataAsync();
                        if(result.IsSuccess)
                        {
                            _logger.LogInformation("Data processing completed successfully.");
                        }
                        else
                        {
                            _logger.LogError("Data processing failed: {Message}", result.Message);
                        }
                    }   
                }
                await Task.Delay(TimeSpan.FromSeconds(2), stoppingToken) ;
            }
        } 

        private static IHandlerServices GetServices(IServiceScope serviceScope)
        {
         
            var csvrrepo = serviceScope.ServiceProvider.GetRequiredService<FileReaderCsv>();
            var dwt = serviceScope.ServiceProvider.GetRequiredService<IDwhServices>();
            var date = serviceScope.ServiceProvider.GetRequiredService<DwbhContext>();
            var handlerepo = serviceScope.ServiceProvider.GetRequiredService<IHandlerServices>();

            return handlerepo;

        }
    }
}
