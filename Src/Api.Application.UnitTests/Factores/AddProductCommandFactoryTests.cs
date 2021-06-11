using System;
using System.Threading.Tasks;
using Api.Application.Factories;
using Api.Core.Common.Contracs;
using Api.Core.Common.Models;
using Microsoft.AspNetCore.Http;
using Moq;
using Xunit;

namespace Api.Application.UnitTests.Factores
{
    public class AddProductCommandFactoryTests
    {
        public AddProductCommandFactoryTests()
        {
            var productImageServise = new Mock<IProductImageServise>();
            productImageServise.Setup(m => m.SaveImageAcync(It.IsAny<IFormFile>()))
                .ReturnsAsync("UpdatedImagePath");
            AddProductCommandFactory = new(productImageServise.Object);
        }

        private AddProductCommandFactory AddProductCommandFactory { get; }

        [Fact]
        public async Task Should_UpdateImagrZPath_WhenFileIsSaves()
        {
            var addProductCommand = await AddProductCommandFactory.CreateAsync(new AddProductCommandModels()
            {
                File = Mock.Of<IFormFile>() // File Fake
                /*  new FormFile(
                      new FileStream(new SafeFileHandle(IntPtr.Zero, false),
                      FileAccess.Write),
                      0,
                      10,
                      "FileName",
                      "FileName.jpg")*/
            });

            Assert.Equal("UpdatedImagePath", addProductCommand.ImgPath);
        }
        [Fact]
        public async Task Should_ThrowAnArgumentNullException_When_FileIsProvided()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await AddProductCommandFactory.CreateAsync(new AddProductCommandModels()));
        }
    }
}
