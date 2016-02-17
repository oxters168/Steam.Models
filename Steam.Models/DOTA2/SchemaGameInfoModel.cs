﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class SchemaGameInfoModel
    {
        public string FirstValidClass { get; set; }
        
        public string LastValidClass { get; set; }
        
        public string FirstValidItemSlot { get; set; }
        
        public string LastValidItemSlot { get; set; }
        
        public string ItemPresetCount { get; set; }
    }
}
