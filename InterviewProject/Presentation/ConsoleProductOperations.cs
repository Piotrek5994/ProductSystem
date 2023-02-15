using InterviewProject.Model;
using InterviewProject.Services;

namespace InterviewProject.Presentation;

internal class ConsoleProductOperations
{
    private ProductsService _productsService = new();
    private bool _exit = false;

    public void RenderOperations()
    {
        while (!_exit)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter a command:");
            Console.WriteLine("1. Get product");
            Console.WriteLine("2. Add new product");
            Console.WriteLine("3. Update product");
            Console.WriteLine("4. Get the cheapest product");
            Console.WriteLine("5. Get the most expensive product");
            Console.WriteLine("6. Get last modified product");
            Console.WriteLine("7. Calculate product price in different currency");
            Console.WriteLine("8. All Products");
            Console.WriteLine("9. Exit");
            Console.WriteLine("---------------------------------");

            int operation = int.Parse(Console.ReadLine());
            RunOperation(operation);
        }
    }

    private void RunOperation(int operation)
    {
        switch (operation)
        {
            case 1: GetProduct(); return;
            case 2: AddProduct(); return;
            case 3: UpdateProduct(); return;
            case 4: GetCheapestProduct(); return;
            case 5: GetMostExpensiveProduct(); return;
            case 6: GetLastModifiedProduct(); return;
            case 7: CalculateProductPriceInDifferentCurrency(); return;
            case 8: GetAllProducts(); return;
            case 9: _exit = true; return;
        }
    }

    private void GetProduct()
    {
        Console.WriteLine("Get product");
        string name = Console.ReadLine();
        var product = _productsService.GetProduct(name);
        if (product != null)
        {
            RenderProductData(product);
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }

    private void AddProduct()
    {
        Console.WriteLine("Add new product");
        Console.WriteLine();
        Console.WriteLine("Enter product name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter product description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter product price:");
        double price = double.Parse(Console.ReadLine());
        var product = _productsService.AddNewProduct(name, description, price);
        RenderProductData(product);
    }
    private void UpdateProduct()
    {
        Console.WriteLine("Enter Product Name");
        string updateName = Console.ReadLine();
        Console.WriteLine("Enter Product Description");
        string updateDescription = Console.ReadLine();
        Console.WriteLine("Enter Product Price");
        double updatePrice = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Product Id");
        Guid id = Guid.Parse(Console.ReadLine());
        var product = new Product(updateName, updateDescription, updatePrice);
        _productsService.UpdateProduct(id,product);
        RenderProductData(product);
    }
    private void GetCheapestProduct()
    {
        Console.WriteLine("Get the cheapest product");
        var product = _productsService.GetCheapestProduct();
        RenderProductData(product);
    }

    private void GetAllProducts()
    {
        
        var products = _productsService.GetAllProducts();
        if(products.Count() == 0)
        {
            Console.WriteLine("No products found");
        }
        else
        {
            foreach (var product in products)
            {
                Console.WriteLine("All Products");
                RenderProductData(product);
            }
        }    
    }

    private void CalculateProductPriceInDifferentCurrency()
    {
        Console.WriteLine("Enter Product ID:");
        var id = Guid.Parse(Console.ReadLine());
        var product = _productsService.GetProduct(id);
        var plnPrice = _productsService.GetProductPriceInPln(id);
        var eurPrice = _productsService.GetProductPriceInEur(id);
        var usdPrice = _productsService.GetProductPriceInUsd(id);
        Console.WriteLine($"Product price in PLN: {plnPrice} zł");
        Console.WriteLine($"Product price in EUR: {eurPrice} UE");
        Console.WriteLine($"Product price in USD: $ {usdPrice}");

        RenderProductData(product);
    }

    private void GetLastModifiedProduct()
    {
        var product = _productsService.GetLastModifiedProduct();
        RenderProductData(product);
    }

    private void GetMostExpensiveProduct()
    {
        var product = _productsService.GetMostExpensiveProduct();
        RenderProductData(product);
    }

    private void RenderProductData(Product product)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Id: {product.Id}");
        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Price {product.Price}");
        Console.WriteLine($"Date added: {product.DateAdded}");
        Console.WriteLine("---------------------------------");
    }
}