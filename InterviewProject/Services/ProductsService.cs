﻿using InterviewProject.Model;
using InterviewProject.Persistence;

namespace InterviewProject.Services;

internal class ProductsService
{
    private const double USD_PRICE = 1.1d;
    private const double EUR_PRICE = 4.5d;
    private const double PLN_PRICE = 1d;

    private readonly IProductsDatabase _productsDatabase;

    public ProductsService()
    {
        _productsDatabase = new ProductsDatabase();
    }

    public Product AddNewProduct(string productName, string opisProduktu, double plnPrice)
    {
        var product = new Product(productName, opisProduktu, plnPrice);
        _productsDatabase.Add(product);
        return product;
    }

    public void DeleteProduct(Guid id) => _productsDatabase.Delete(id);

    public void UpdateProduct(Guid id, Product product)
    {
        _productsDatabase.Update(id,product);
    }

    public Product GetCheapestProduct()
    {
        var products = _productsDatabase.GetAll();
        return products.OrderBy(p => p.Price).First();
    }

    public Product? GetProduct(Guid id) => _productsDatabase.Get(id);
    public Product? GetProduct(string name) => _productsDatabase.GetByName(name);

    public IEnumerable<Product> GetAllProducts() => _productsDatabase.GetAll();

    public double GetProductPriceInPln(Guid id) => _productsDatabase.Get(id).PlnPrice * PLN_PRICE;

    public double GetProductPriceInEur(Guid id) => _productsDatabase.Get(id).PlnPrice * EUR_PRICE;

    public double GetProductPriceInUsd(Guid id) => _productsDatabase.Get(id).PlnPrice * USD_PRICE;

    public Product? GetLastModifiedProduct()
    {
        var products = _productsDatabase.GetAll();
        return products.OrderByDescending(p => p.DateAdded).First();
    }

    public Product? GetMostExpensiveProduct()
    {
        var products = _productsDatabase.GetAll();
        return products.OrderBy(p => p.Price).First();
    }

    public Product? CalculateProductPriceInDifferentCurrency()
    {
       throw new NotImplementedException();
        
    }




}