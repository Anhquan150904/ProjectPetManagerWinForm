using PetManagerData.DataAccess;
using PetManagerData.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetManagerData.Controllers
{
    public class ProductController2
    {
        private ProductRepository _repo;

        public ProductController2(string connectionString)
        {
            _repo = new ProductRepository(connectionString);
        }

        // Trả về List<Product> để dễ xử lý trên UI thay vì DataTable (tùy chọn)
        // Ở đây mình trả về DataTable cho đồng bộ với code cũ của Repo
        public DataTable GetAllProducts()
        {
            return _repo.GetAll();
        }

        public bool AddProduct(Product product)
        {
            // Kiểm tra logic nghiệp vụ ở đây nếu cần (ví dụ: giá > 0)
            if (product.Price < 0) return false;
            return _repo.Add(product);
        }

        public bool UpdateProduct(Product product)
        {
            return _repo.Update(product);
        }

        public bool DeleteProduct(int id)
        {
            return _repo.Delete(id);
        }

        public DataTable SearchProducts(string keyword)
        {
            return _repo.Search(keyword);
        }
    }
}