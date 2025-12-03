

using ApplicacionClientComments.cs.Dto;
using ApplicacionClientComments.cs.Interfaces;
using ApplicacionClientComments.cs.Repository;
using ApplicacionClientComments.cs.Results;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ApplicacionClientComments.cs.Services
{
    public class HandlerServices : IHandlerServices
    {

        private readonly IDwhServices _dwhservices;
        private readonly IConfiguration _configuaration;
        private readonly ILogger<HandlerServices> _logger; 


        public HandlerServices(IDwhServices dwhservices, 
            IConfiguration configuaration, 
            ILogger<HandlerServices> logger)
        {
            _dwhservices = dwhservices;
            _configuaration = configuaration;
            _logger = logger;
        }

        public async Task<ServicesResult> ProcessDataAsync()
        {
            ServicesResult result = new ServicesResult();

            try
            {
                DimDto dto = new DimDto();
                dto.Filepath = _configuaration["FileSettings:ClientCsvPath"];

                result = await _dwhservices.LoadServicesAsync(dto);

            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message.ToString()}");
                 result.IsSuccess = false;

            }   
            


            return result;
        }
    }
}
