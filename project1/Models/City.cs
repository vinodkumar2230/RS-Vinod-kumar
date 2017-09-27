﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project1.Models
{
    public class City
    {
        [Key]
        public int cityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}