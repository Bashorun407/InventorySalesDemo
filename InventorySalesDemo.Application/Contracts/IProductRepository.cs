﻿using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductAsync(bool trackChanges);
        Task<Product> GetProductById(int Id, bool trackChanges);
        void UpdateProduct(Product entity);
        void CreateProduct(Product entity);
        void DeleteProduct(Product entity);
    }
}
