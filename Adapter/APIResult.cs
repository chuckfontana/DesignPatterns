using System.Collections.Generic;

namespace Adapter
{
    public class APIResult<T>
    {
        public int Count { get; set; }
        public List<T> Results { get; set; }
    }
}
