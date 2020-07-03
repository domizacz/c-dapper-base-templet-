using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data_Connection
{
    public interface IDB_Connection
    {
        string ConnectionStringName { get; set; }

        Task DeleteData<T>(string sql, T parameters);
        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
        Task UpdateData<T>(string sql, T parameters);
    }
}