﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialDataWeb.Models
{

    public class Value
    {
        public string? datetime { get; set; }
        public string? open { get; set; }
        public string? high { get; set; }
        public string? low { get; set; }
        public string? close { get; set; }
        public string volume { get; set; }
    }

}
