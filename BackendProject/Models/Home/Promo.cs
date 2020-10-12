﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Promo
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
    }
}
