using UnitOfWorkExample.Models;
using UnitOfWorkExample.Services;

var product = new Product { Id =1, Name="Product 1", Price=10 };

var ProductService = new ProductService();
ProductService.SaveProduct(product);

Console.WriteLine("Produto Adicionado com sucesso");