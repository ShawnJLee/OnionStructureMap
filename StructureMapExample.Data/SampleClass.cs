﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMapExample.Core;

namespace StructureMapExample.Data
{
    public class SampleClass : ISampleClass
    {
        public string GetAString()
        {
            return "Hey look it's a string from the data layer!";
        }
    }
}