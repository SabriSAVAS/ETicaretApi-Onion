using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApi.Domain.Entities.Common;

namespace ETicaretApi.Domain.Entities
{
    public class Product : BaseEntitiy
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
    }
}
