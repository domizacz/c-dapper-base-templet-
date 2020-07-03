using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Task_ADDModel
    {
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public int Id_user { get; set; }
    }

}
