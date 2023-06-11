using UnitOfWorkExample.Models;
using UnitOfWorkExample.Repositories;

namespace UnitOfWorkExample.Services
{
    public class ProductService
    {
        public void SaveProduct(Product product)
        {
            using var unitOfWork = new UnitOfWork();
            var productRepository = unitOfWork.Repository<Product>();
            productRepository.Add(product);
            unitOfWork.Save();
        }
    }
}