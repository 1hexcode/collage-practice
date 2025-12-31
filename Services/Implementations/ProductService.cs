using MauiApp1.Components.Layout;
using MauiApp1.Model;
using MauiApp1.Services.Interfaces;

namespace MauiApp1.Services;

public class ProductService : IProductService
{
    public void AddProduct(Product product)
    {
        ProductStore.ProductList.Add(product);
    }

    public List<Product> GetAllProducts()
    {
        return ProductStore.ProductList;
    }
}