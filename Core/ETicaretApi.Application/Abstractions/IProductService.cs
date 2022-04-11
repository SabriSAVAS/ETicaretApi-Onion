using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApi.Domain.Entities;

namespace ETicaretApi.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
