using ApplicacionClientComments.cs.Dto;
using ApplicacionClientComments.cs.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionClientComments.cs.Repository
{
    public interface IDwhServices
    {
        public Task<ServicesResult> LoadServicesAsync(DimDto didto);

    }
}
