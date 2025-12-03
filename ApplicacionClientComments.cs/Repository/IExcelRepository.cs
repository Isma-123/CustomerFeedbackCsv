using ApplicacionClientComments.cs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionClientComments.cs.Repository
{
    public interface IExcelRepository :  IFileReaderCsv<IExcelRepository>   
    {
    }
}
