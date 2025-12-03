

using ApplicacionClientComments.cs.Dto;
using ApplicacionClientComments.cs.Results;

namespace ApplicacionClientComments.cs.Interfaces
{
    public interface IHandlerServices
    { 

        public Task<ServicesResult> ProcessDataAsync();

    }
}
