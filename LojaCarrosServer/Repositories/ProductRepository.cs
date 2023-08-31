using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCarrosServer.Repositories;

    public class ProductRepository : IProductRepository
    {
        private readonly IMongoColletion<Product> _collection;
    }