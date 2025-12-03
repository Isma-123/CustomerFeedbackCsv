using ApplicacionClientComments.cs.Interfaces;
using Damain.ClientComments.cs.Api;
using Damain.ClientComments.cs.Csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionClientComments.cs.Repository
{
    public interface FileReaderCsv : IFileReaderCsv<Social_Comments>
    {
    }
}
