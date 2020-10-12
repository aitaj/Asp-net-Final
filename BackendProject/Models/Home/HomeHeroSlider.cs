using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace BackendProject.Models
{
    public class HomeHeroSlider
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Header { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Desc { get; set; }
    }
}
