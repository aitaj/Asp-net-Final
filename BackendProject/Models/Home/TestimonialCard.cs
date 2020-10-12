using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackendProject.Models
{
    public class TestimonialCard
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Blockquote { get; set; }
        [MaxLength(50)]
        public string ClientName { get; set; }
        [MaxLength(50)]
        public string ClientPosition { get; set; }
    }
}
