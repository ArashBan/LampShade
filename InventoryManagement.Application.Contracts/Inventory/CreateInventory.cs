using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;

namespace InventoryManagement.Application.Contracts.Inventory
{
    public class CreateInventory
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequierd)]
        public long ProductId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = ValidationMessages.IsRequierd)]
        public double UnitPrice { get; set; }

        public List<ProductViewModel> Products { get; set; }
    }
}