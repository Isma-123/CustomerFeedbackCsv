namespace ReadClientsComments.cs.Actions.cs
{
    public interface IGeneralActions<Tclass> where Tclass : class
    {
        public Task<IEnumerable<Tclass>> GetAllAsync();
        public Task<Tclass> GetValueById(int id);
        public Task<Tclass> PostValuesAsnyc(Tclass value);  

    }
}
