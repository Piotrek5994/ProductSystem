using Xunit;
using InterviewProject.Services;
using InterviewProject.Model;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddNewProduct()
        {
           //give
           var productService = new ProductsService();
            var productName = "Milk";
            var productDescription = "Milk";
            var productPrice = 10;
            var product = new Product(productName, productDescription, productPrice);
            //when
            productService.AddNewProduct(productName, productDescription, productPrice);
            //then
            Assert.Equal(product, productService.GetProduct(product.Id));
        }
        [Fact]
        
        public void AddNewProduct2()
        {
            //give
            var productService = new ProductsService();
            var productName = "Cake";
            var productDescription = "Cake";
            var productPrice = 50.20;
            var product = new Product(productName, productDescription, productPrice);
            //when
            productService.AddNewProduct(productName, productDescription, productPrice);
            //then
            Assert.Equal(product, productService.GetProduct(product.Id));
        }

        [Fact]
        public void DeleteProduct()
        {
            //give
            var productService = new ProductsService();
            var productName = "Milk";
            var productDescription = "Milk";
            var productPrice = 10;
            var product = new Product(productName, productDescription, productPrice);
            //when
            productService.AddNewProduct(productName, productDescription, productPrice);
            productService.DeleteProduct(product.Id);
            //then
            Assert.Null(productService.GetProduct(product.Id));
        }

        [Fact]
        public void DeleteProduct2()
        {
            //give
            var productService = new ProductsService();
            var productName = "Cake";
            var productDescription = "Cake";
            var productPrice = 50.20;
            var product = new Product(productName, productDescription, productPrice);
            //when
            productService.AddNewProduct(productName, productDescription, productPrice);
            productService.DeleteProduct(product.Id);
            //then
            Assert.Null(productService.GetProduct(product.Id));
            
        }
    }
}