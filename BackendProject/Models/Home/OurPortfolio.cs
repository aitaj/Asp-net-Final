using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackendProject.Models
{
    public class OurPortfolio
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Desc { get; set; }
        [MaxLength(50)]
        public string PortfolioButton { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
    }
}
