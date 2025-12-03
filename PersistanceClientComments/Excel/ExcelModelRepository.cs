

using ApplicacionClientComments.cs.Repository;

namespace PersistanceClientComments.Excel
{
    public class ExcelModelRepository : IExcelRepository
    {
        public Task<IEnumerable<IExcelRepository>> ReadCsvAsync(string csvFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
