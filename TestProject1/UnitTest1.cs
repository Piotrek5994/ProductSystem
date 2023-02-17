using InterviewProject.Model;
using InterviewProject.Services;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
       public void Test1()
        {
            var productsService = new ProductsService();
            var product = productsService.AddNewProduct("Test", "Test", 10);
            Assert.Equal("Test", product.Name);
            Assert.Equal("Test", product.Description);
            Assert.Equal(10, product.Price);
        }

        [Fact]
        public void Test2()
        {
            //give 
            var productsService = new ProductsService();
            var product = productsService.AddNewProduct("Milk", "Milk", 2.50);
            //when
            var product2 = productsService.UpdateProduct(product.Id, new Product("Milk", "Milk", 5.00));
            //then
            Assert.Equal("Milk", product2.Name);
            Assert.Equal("Milk", product2.Description);
            Assert.Equal(5.00, product2.Price);
        }

        [Fact]
        public void Test3()
        {
            //give
            var productService = new ProductsService();
            var products = productService.AddNewProduct("Milk", "Milk", 5.00);
            //when 
            var product2 = productService.GetProduct(products.Id);
            //then
            Assert.Equal("Milk", product2.Name);
            Assert.Equal("Milk", product2.Description);
        }

        [Fact]
        public void Test4()
        {
            //give
            var productService = new ProductsService();
            var products = productService.AddNewProduct("Milk", "Milk", 5.00);
            var products2 = productService.AddNewProduct("Cake", "Cake", 10.00);
            //when
            var product3 = productService.GetAllProducts();
            //then
            Assert.Equal(2, product3.Count());
        }

        [Fact]
        public void Test5()
        {
            //give
            var productService = new ProductsService();
            var products = productService.AddNewProduct("Milk", "Milk", 5.00);
            var products2 = productService.AddNewProduct("Cake", "Cake", 10.00);
            //when
            var product3 = productService.GetProduct("Milk");
            //then
            Assert.Equal("Milk", product3.Name);
            Assert.Equal("Milk", product3.Description);
        }

        [Fact]
        public void Test6()
        {
            //give
            var productService = new ProductsService();
            var products = productService.AddNewProduct("Milk", "Milk", 5.00);
            var products2 = productService.AddNewProduct("Cake", "Cake", 10.00);
            //when
            var product3 = productService.GetProduct("Cake");
            //then
            Assert.Equal("Cake", product3.Name);
            Assert.Equal("Cake", product3.Description);
        }

        [Fact]
        public void Test7()
        {
          //give
            var productService = new ProductsService();
            var products = productService.AddNewProduct("Milk", "Milk", 5.00);;
            var products2 = productService.AddNewProduct("Cake", "Cake", 10.00);
            //when
            var product3 = productService.GetLastModifiedProduct();
            //then
            Assert.Equal("Cake", product3.Name);

        }

        [Fact]
        public void Test8()
        {
            //give
            var productService = new ProductsService();
            var products3 = productService.AddNewProduct("Milk", "Milk", 5.00);
            var products2 = productService.AddNewProduct("Cake", "Cake", 10.00);
            //when
            var product4 = productService.GetCheapestProduct();
            //then
            Assert.Equal("Milk", product4.Name);
        }
        [Fact]
        public void Test9()
        {
            //give
            var productService = new ProductsService();
            var products3 = productService.AddNewProduct("Milk", "Milk", 5.00);
            var products2 = productService.AddNewProduct("Cake", "Cake", 10.00);
            //when
            var product4 = productService.GetMostExpensiveProduct();
            //then
            Assert.Equal("Cake", product4.Name);
        }
    }
}