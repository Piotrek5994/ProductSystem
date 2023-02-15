using InterviewProject.Model;
using InterviewProject.Services;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetProduct()
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
            Assert.Equal(productService.GetProduct(product.Id), product);
        }
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
            Assert.Equal(productService.GetProduct(product.Id), product);
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
            Assert.Equal(productService.GetProduct(product.Id), product);
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
        [Fact]

        public void UpdateProduct()
        {
            //give
            var productService = new ProductsService();
            var productName = "Milk";
            var productDescription = "Milk";
            var productPrice = 10;
            var product = new Product(productName, productDescription, productPrice);
            //when
            productService.AddNewProduct(productName, productDescription, productPrice);
            productService.UpdateProduct(product.Id, product);
            //then
            Assert.Equal(productService.GetProduct(product.Id), product);
        }
        [Fact]
        public void UpdateProduct2()
        {

            //give
            var productService = new ProductsService();
            var productName = "Cake";
            var productDescription = "Cake";
            var productPrice = 50.20;
            var product = new Product(productName, productDescription, productPrice);
            //when
            productService.AddNewProduct(productName, productDescription, productPrice);
            productService.UpdateProduct(product.Id, product);
            //then
            Assert.Equal(productService.GetProduct(product.Id), product);

        }
        [Fact]
        public void GetProductByName()
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
            Assert.Equal(productService.GetProduct(productName), product);
        }
    }
}