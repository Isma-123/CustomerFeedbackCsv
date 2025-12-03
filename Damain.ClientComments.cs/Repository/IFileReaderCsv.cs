using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionClientComments.cs.Interfaces
{
    public interface IFileReaderCsv<TClass> where TClass : class
    {   
        Task<IEnumerable<TClass>> ReadCsvAsync(string csvFilePath); 


    }
}
