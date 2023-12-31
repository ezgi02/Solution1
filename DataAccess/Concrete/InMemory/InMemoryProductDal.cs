﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    internal class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql,Postgress,MongoDb
            _products= new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=15,UnitInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=15,UnitInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=15,UnitInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=15,UnitInStock=1}
            };
        }
        public void Add(Product product)
        {
           _products.Add(product);

        }

        public void Delete(Product product)
        {
            //LINQ -Language Integrated Query
            //Lambda
            Product productToDelete=null;
            foreach (var p in _products)
            {
                if(p.ProductId == product.ProductId)
                {
                    productToDelete = p;
                }
            }
            productToDelete=_products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
