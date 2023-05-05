using Microsoft.EntityFrameworkCore;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductMicroservice.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext) 
        {
            _dbContext = dbContext; 
        }

        public void DeleteProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public object GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public object GetProducts()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            //throw new NotImplementedException();
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }

    }
}
