using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute : Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
