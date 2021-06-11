using System;
using Api.Domain.Commands.Products;
using Api.Domain.Exceptions;
using Api.Domain.Models.Products;
using Xunit;

namespace Api.Domain.UnitTest.Models
{
    public class ProductTest
    {
        private Product _product;

        public ProductTest()
        {
        }

        [Fact]
        public void Should_ThrowAnException_When_ProductIsVisible()
        {
            _product = new Product(0, "", "", DateTime.Now, 10, "", "", 1, true, false, true);
            Assert.Throws<VisibelProductCannotbeDeletedExcrption>(() => _product.Deleted());
        }

        [Fact]
        public void Should_Delete_When_ProductIsNotVisible()
        {
            _product = new Product(0, "", "", DateTime.Now, 10, "", "", 1, false, false, true);
            _product.Deleted();
            Assert.True(_product.IsDeleted);
        }
        [Fact]
        public void Should_ThrowException_When_UpdateProductMoreThentenPercent()
        {
            //Arrange
            _product = new Product(0, "", "", DateTime.Now, 10, "", "", 1, false, false, true);
            UpdateProductCommand updateProductCommand = new()
            {
                Price = 15
            };
            //Act //Assert
            Assert.Throws<UpdatePriceCannotBeMoreThenTenPercentException>(() => _product.Update(updateProductCommand));
        }
        [Fact]
        public void Should_UpdateThenProduct_When_NewPriceIsLessThentenPercent()
        {
            //Arrange
            _product = new Product(0, "", "", DateTime.Now, 15, "", "", 1, false, false, true);
            UpdateProductCommand updateProductCommand = new()
            {
                Price = 16
            };

            //Act
            _product.Update(updateProductCommand);

            //Assert
            Assert.Equal(_product.Price, updateProductCommand.Price);
        }
    }
}
