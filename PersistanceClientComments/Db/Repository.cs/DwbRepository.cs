using ApplicacionClientComments.cs.Dto;
using ApplicacionClientComments.cs.Repository;
using ApplicacionClientComments.cs.Results;
using Damain.ClientComments.cs.Dwbh.Dimensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PersistanceClientComments.Db.Context;
using System.Globalization;


namespace PersistanceClientComments.Db.Repository.cs
{
    public class DwbRepository : IDwhServices
    {
     
        private readonly DwbhContext _context; 
        private readonly ILogger<DwbRepository> _logger;    
        private readonly FileReaderCsv _fileClientCsv;

        public DwbRepository(
            DwbhContext context,
            ILogger<DwbRepository> logger,
            FileReaderCsv fileClientCsv)
        {
            _context = context;
            _logger = logger;
            this._fileClientCsv = fileClientCsv;
        }
        public async Task<ServicesResult> LoadServicesAsync(DimDto didto)
        {
            var result = new ServicesResult(); 

            _logger.LogInformation("Loading services into DWB database."); 
            try
            {


                result = await LimpiarDimension();

                var reader = await _fileClientCsv.ReadCsvAsync(didto.Filepath!);
                // leo archivo csv 

                // validaciones 

                if(reader is null) {

                    result.IsSuccess = false;
                    result.Message = "No data found in the CSV file.";
                    return result;
                } 

                var date = reader.Select(x => x.Fuente.Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct()
                .Select(x => new DimFuente
                {
                    TipoFuente = x,
                }).ToList();

                await _context.DimFuentes.AddRangeAsync(date);
                await _context.SaveChangesAsync();


                var client = reader.Select(x => new DimClientes
                {
                    IdCliente = x.IdCliente,
                    Nombre = "Abdias".Trim(),
                    Email = "felizseguraabdias@gmail.com".Trim(),

                }).ToList();

                await _context.DimClientes.AddRangeAsync(client);
                await _context.SaveChangesAsync();


                // guardar la fecha 
                var fecha = reader.Select(x => x.Fecha).Distinct()
                    .Select(x => new DimTiempo
                    {
                        Anio = x.Year,
                        Dia = x.Day,
                        Fecha = x.Date,
                        Mes = x.Month,
                        NombreMes = x.ToString("dddd", new CultureInfo("es-ES")),
                        Trimestre = (x.Month - 1) / 3 + 1,
                       
                    }).ToArray();



                await _context.DimTiempos.AddRangeAsync(fecha);
                await _context.SaveChangesAsync();

                // Guardo comenetario 

                var comment = reader.Select(a => a.Comentario.Trim())
                    .Where(a => !string.IsNullOrEmpty(a))
                    .Distinct()
                    .Select(a => new DimSocialComment
                    {
                        Comentario = a, // comentario debido

                    }).ToArray();  


                await _context.DimSocialComments.AddRangeAsync(comment);
                await _context.SaveChangesAsync();


                var products = reader.Select(x => new DimProducto
                {
                    IdProducto = x.IdProducto,
                    Nombre = "Product_1",
                    Categoria = x.Comentario.Trim(),
                }).ToArray();
                

                await _context.DimProductos.AddRangeAsync(products);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Dimenesion cargadas Satifactoriamente ");
            }   
            catch (Exception ex)
            {
                _logger.LogError($"Error loading services: {ex.Message}");
                result.IsSuccess = false;
                result.Message = "An error occurred while loading services.";   

            }   

            return result;
        }

     

        private async Task<ServicesResult> LimpiarDimension()
        {
            var result = new ServicesResult();

            try
            {
                await _context.DimClientes.ExecuteDeleteAsync();
                await _context.DimFuentes.ExecuteDeleteAsync();
                await _context.DimTiempos.ExecuteDeleteAsync();
                await _context.DimProductos.ExecuteDeleteAsync();
                await _context.DimSurveys.ExecuteDeleteAsync();
                await _context.DimSocialComments.ExecuteDeleteAsync();
                await _context.DimWebReviuws.ExecuteDeleteAsync();


                await _context.SaveChangesAsync();

               result.Message = "Date Csv has been removed sucefully!";

            } 
            catch(Exception ex)
            {
               _logger.LogError($"Error cleaning dimension: {ex.Message}");
                result.IsSuccess = false;
                result.Message = "An error occurred while cleaning dimension.";
            }   

            return result;

        }
    }
}
