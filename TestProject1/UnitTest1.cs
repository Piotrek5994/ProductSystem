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


    }
}