using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections
{
    class TryClass1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool tryField;

        public void TryMethod() { }

        public string WriteMethod() { return "Deneme"; }

        public int Calculate(int a, int b) { return a + b; }
    }
}
