using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackendProject.Models
{
    public class TeamTwoCard
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }

        public string SocialLinks { get; set; }

      
    }
}
