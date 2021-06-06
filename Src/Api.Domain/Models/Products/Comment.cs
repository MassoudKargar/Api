using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace Api.Domain.Models.Products
{
    public class Comment
    {
        public Comment()
        {

        }
        public Comment(
            int id,
            int productId,
            int userId, 
            string body,
            DateTime createdAt,
            bool isVerified,
            int? parentId)
        : this(){
            Id = id;
            ProductId = productId;
            UserId = userId;
            Body = body ?? throw new ArgumentNullException(nameof(body));
            CreatedAt = createdAt;
            IsVerified = isVerified;
            ParentId = parentId;
        }

        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int UserId { get; private set; }
        public string Body { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsVerified { get; private set; }
        public int? ParentId { get; private set; }

    }
}
