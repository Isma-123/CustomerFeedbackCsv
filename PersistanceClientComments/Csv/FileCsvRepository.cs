

using ApplicacionClientComments.cs.Repository;
using Damain.ClientComments.cs.Csv;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PersistanceClientComments.Csv
{
    public class FileCsvRepository : FileReaderCsv
    {
        private readonly string? _filePath = string.Empty;
        private readonly IConfiguration _configuration;
        private readonly ILogger<FileCsvRepository> _logger;    
        public FileCsvRepository(
            IConfiguration configuration,
            ILogger<FileCsvRepository> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _filePath = _configuration.GetValue<string>("FileSettings:SocialCommentsCsvPath")!;
        }
        public async Task<IEnumerable<Social_Comments>> ReadCsvAsync(string csvFilePath)
        {
            List<Social_Comments> ls = null!;
            _logger.LogInformation($"Starting to read the CSV file. {_filePath} ");   

            try
            {
                using var reader = new StreamReader(csvFilePath);
                using var csv = new CsvHelper.CsvReader
                    (reader, System.Globalization.CultureInfo.InvariantCulture);

                await foreach(var record in csv.GetRecordsAsync<Social_Comments>())
                {
                   if(record is null)
                    {
                        _logger.LogWarning("No records found in the CSV file.");
                        continue;
                    }

                    ls.Add(record);
                    
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error trying to read the CSV file: {ex.Message.ToLower()}");
                 ls = null!; 
            }


            return ls!;

        } 
    }
}
