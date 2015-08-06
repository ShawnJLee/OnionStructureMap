using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StructureMapExample.Core
{
    public interface ISampleClass
    {
        string GetAString();
    }
    public class SampleClass : ISampleClass
    {
        public string GetAString()
        {
            return "Hey look it's a string!";
        }
    }
}