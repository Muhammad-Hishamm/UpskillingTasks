using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal static class CollectionPagination
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page, int pageSize)
        {
            decimal itemIndex = 1;
            decimal size = source.Count();
            List<T> collection = new List<T>();
            foreach (var item in source)
            {
                if (collection.Count == pageSize)
                {
                    break;
                }

                else if (Math.Ceiling(itemIndex / pageSize) >=page )
                {
                    collection.Add(item);   
                }
                itemIndex++;
            }
            return collection;
        }

    }
}
