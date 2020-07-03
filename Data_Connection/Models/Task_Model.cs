using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Connection.Models
{
   public class Task_Model
    {
        public int Id { get; set; }
        public string Task { get; set; }

        public DateTime Data { get; set; }

        public int Id_user { get; set; }

    }
}
