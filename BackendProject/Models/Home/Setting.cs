using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Logo { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string ContactPhone { get; set; }
        [MaxLength(50)]
        public string HeaderPhone { get; set; }
    
    }
}
