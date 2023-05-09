namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sqlStatement, U parameters, string connectionString);
        Task<int> SaveData<T>(string sqlStatement, T parameters, string connectionString);
    }
}