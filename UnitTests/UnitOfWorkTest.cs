using UnitOfWorkExample.Interfaces;
using UnitOfWorkExample.Models;
using UnitOfWorkExample.Repositories;

namespace UnitTests;

public class UnitOfWorkTest
{
    private readonly IUnitOfWork _unitOfWork;
    public UnitOfWorkTest()
    {
        _unitOfWork = new UnitOfWork();
    }
    
    [Fact]
    public void Repositorio_CriaNovoRepositorio_QuandoRepositorioNaoExistir()
    {
        var product = _unitOfWork.Repository<Product>();

        Assert.NotNull(product);
    }

    [Fact]
    public void Repositorio_RetornarRepositorioExistente_QuandoRepositorioJaExistir()
    {
        // arrange
        var productA = _unitOfWork.Repository<Product>();

        var productB = _unitOfWork.Repository<Product>();

        // Assert
        Assert.Same(productA, productB);
    }
}