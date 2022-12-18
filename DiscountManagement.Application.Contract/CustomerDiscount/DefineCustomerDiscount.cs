using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;

namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public class DefineCustomerDiscount
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequierd)]
        public long ProductId { get; set; }

        [Range(1, 100, ErrorMessage = ValidationMessages.IsRequierd)]
        public int DiscountRate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string StartDate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequierd)]
        public string EndDate { get; set; }

        public string Reason { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
