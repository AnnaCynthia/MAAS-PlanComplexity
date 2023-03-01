﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulationComplexity.Models
{
    internal class SettingsClass
    {
        public bool Debug { get; set; }
        public bool Validated { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool EULAAgreed { get; set; }
    }
}
