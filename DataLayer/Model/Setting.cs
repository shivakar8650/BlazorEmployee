﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
     public class Setting :ISetting
    {
        public string Connectionstring { get; set; }
        public string DatabaseName { get; set; }
    }
}
