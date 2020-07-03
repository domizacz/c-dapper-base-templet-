using Data_Connection.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data_Connection
{
    public interface ITask_sql
    {
        Task AddPeople(Task_Model Taskadd);
        Task DeletePeople(int id);
        Task EditPeople(Task_Model task_edit);
        Task<List<Task_Model>> GetPeople();
    }
}