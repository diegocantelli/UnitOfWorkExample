using UnitOfWorkExample.Models;
using UnitOfWorkExample.Repositories;

namespace UnitTests
{
    public class RepositoryTest 
    {
        private readonly UnitOfWork _unitOfWork;

        public RepositoryTest()
        {
            _unitOfWork = new UnitOfWork();
        }

        [Fact]
        public void Repository_QuandoCriarRepositorio_RepositorioDeveEstarVazio()
        {
            // Arrange
            var productRepo = _unitOfWork.Repository<Product>();


            Assert.Empty(productRepo.GetAll());
        }

        [Fact]
        public void Repository_QuandoAddItemRepositorioVazio_RepositorioDeveConterApenasUmItem()
        {
            // Arrange
            var productRepo = _unitOfWork.Repository<Product>();

            // Act
            productRepo.Add(new Product { Id= 1, Name = "Product 1", Price = 15.99m });

            // Assert
            Assert.True(productRepo.GetAll().Count == 1);
        }

        [Fact]
        public void Repository_QuandoBuscarItemPorId_DeveRetornarItemCorreto()
        {
            // Arrange
            var productRepo = _unitOfWork.Repository<Product>();

            // Act
            productRepo.Add(new Product { Id= 1, Name = "Product 1", Price = 15.99m });
            var item = productRepo.Get(1);

            // Assert
            Assert.True(productRepo.Get(1).Id == item.Id);
        }
    }
}