using System;
using System.Linq;

namespace Linq.Linq101
{
    public class SelectAnonymousType
    {
        public SelectAnonymousType()
        {
            var anonymousModels = BaseClass.ModelList.Select(
                n => new
                {
                    id = n.ID,
                    name = n.Name == "Model1"
                });

            foreach (var item in anonymousModels)
            {
                Console.WriteLine("The digit {0} is {1}.", item.id, item.name ? "Model 1" : "Dont Read");
            }
        }
    }
}
