using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Data_Connection.Models;
using Microsoft.Extensions.Configuration;

namespace Data_Connection
{
    public class Task_sql : ITask_sql
    {
        private readonly IDB_Connection _db;
        public Task_sql(IDB_Connection db)
        {
            _db = db;
        }

        public string baseDB = "devdomdo_demo.Task";
        public Task<List<Task_Model>> GetPeople()
        {
            string sql = @"SELECT * FROM " + baseDB;
            return _db.LoadData<Task_Model, dynamic>(sql, new { });
        }
        public Task EditPeople(Task_Model task_edit)
        {
            string sql = @"Select * from " + baseDB;
            return _db.UpdateData(sql, task_edit);
        }
        public Task DeletePeople(int id)
        {
            string sql = @"Delete from " + baseDB + " where id = @id ;";
            return _db.DeleteData(sql, new { ID = id });
        }

        public Task AddPeople(Task_Model Taskadd)
        {
            string sql = @"Insert Into " + baseDB + " values (@Task, @Data, @Id_user);";
            return _db.SaveData(sql, Taskadd);
        }
    }
}
