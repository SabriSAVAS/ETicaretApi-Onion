using ETicaretApi.Application.Abstractions;
using ETicaretApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new() { Id= Guid.NewGuid(), Name="Elma" ,Price = 5 ,  Stock = 10 ,  CreatedDate=DateTime.Now  },
            new() { Id= Guid.NewGuid(), Name="Armut" ,Price = 8 , Stock = 18 ,  CreatedDate=DateTime.Now  },
            new() { Id= Guid.NewGuid(), Name="Kayısı" ,Price = 10 , Stock = 30 ,  CreatedDate=DateTime.Now  },
            new() { Id= Guid.NewGuid(), Name="Hıyar" ,Price = 13, Stock = 51 ,  CreatedDate=DateTime.Now  },
            new() { Id= Guid.NewGuid(), Name="Muz" ,Price = 23, Stock = 50 ,  CreatedDate=DateTime.Now  }
        };
    }
}
