using MauiApp1.Model;

namespace MauiApp1.Services.Interfaces;

public interface IProductService 
{
    public void AddProduct(Product product);
    public List<Product> GetAllProducts();
}