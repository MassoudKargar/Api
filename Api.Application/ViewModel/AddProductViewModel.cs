using System;

namespace Api.Application.ViewModel
{
    public class AddProductViewModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public string FilePhat { get; set; }
        public short ProductCategoryId { get; set; }
        public bool IsVisible { get; set; }
        public bool IsSalleble { get; set; }

    }
}
