using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class BaseClass
    {
        public static List<ModelClass> ModelList { get; set; }

        public BaseClass()
        {
            ModelList = new List<ModelClass>()
            {
                new ModelClass(){ ID = 1, Name = "Model1" },
                new ModelClass(){ ID = 2, Name = "Model2" },
                new ModelClass(){ ID = 3, Name = "Model3" },
                new ModelClass(){ ID = 4, Name = "Model4" },
                new ModelClass(){ ID = 5, Name = "Model5" },
                new ModelClass(){ ID = 6, Name = "Model6" },
                new ModelClass(){ ID = 7, Name = "Model7" },
                new ModelClass(){ ID = 8, Name = "Model8" },
                new ModelClass(){ ID = 9, Name = "Model9" }
            };
        }
    }
}
