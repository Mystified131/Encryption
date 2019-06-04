﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class ResultViewModel
    {
        public string messin { get; set; }
        public string messout { get; set; }
        public String Error { get; set; }
    }
}
