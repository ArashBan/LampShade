using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.Product
{
    public class CreateProduct
    {
        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string Code { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public double UnitPrice { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }

        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequierd)]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string Slug { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string MetaDescription { get; set; }
        public List<ProductCategoryViewModel> Categories { get; set; }
    }
}
