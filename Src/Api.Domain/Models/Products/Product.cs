using System;
using System.Collections.Generic;
using Api.Domain.Commands.Products;
using Api.Domain.Exceptions;

namespace Api.Domain.Models.Products
{
    public class Product
    {
        public Product(
            int id,
            string title,
            string body,
            DateTime createdAt,
            decimal price,
            string imgPath,
            string filePhat,
            short productCategoryId,
            bool isVisible,
            bool isDeleted,
            bool isSalleble) : this()
        {
            Id = id;
            Title = title;
            Body = body;
            CreatedAt = createdAt;
            Price = price;
            ImgPath = imgPath;
            FilePhat = filePhat;
            ProductCategoryId = productCategoryId;
            IsVisible = isVisible;
            IsDeleted = isDeleted;
            IsSalleble = isSalleble;
        }


        public void Update(UpdateProductCommand cmd)
        {
            Title = cmd.Title;
            Body = cmd.Body;
            Price = cmd.Price;
            ImgPath = cmd.ImgPath;
            FilePhat = cmd.FilePhat;
            ProductCategoryId = cmd.ProductCategoryId;
            IsVisible = cmd.IsVisible;
            IsDeleted = cmd.IsDeleted;
            IsSalleble = cmd.IsSalleble;
        }

        public void Deleted()
        {
            if (IsVisible)
            {
                throw new VisibelProductCannotbeDeletedExcrption($"Visible Product cannot be deletedId Is {Id} ");
            }
            IsDeleted = true;
        }
        public Product()
        {
            _comments = new List<Comment>();
            _productRates = new List<ProductRate>();
            _productTags = new List<ProductTag>();
        }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Body { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public decimal Price { get; private set; }
        public string ImgPath { get; private set; }
        public string FilePhat { get; private set; }
        public short ProductCategoryId { get; private set; }
        public bool IsVisible { get; private set; }
        public bool IsDeleted { get; private set; }
        public bool IsSalleble { get; private set; }


        private readonly List<Comment> _comments;
        public IReadOnlyCollection<Comment> Comments => _comments;

        private readonly List<ProductRate> _productRates;
        public IReadOnlyCollection<ProductRate> ProductRates => _productRates;

        private readonly List<ProductTag> _productTags;
        public IReadOnlyCollection<ProductTag> ProductTags => _productTags;

    }
}
