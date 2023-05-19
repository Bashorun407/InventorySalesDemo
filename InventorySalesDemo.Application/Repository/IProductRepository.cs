﻿using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Repository
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
