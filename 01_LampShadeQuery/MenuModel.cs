using System.Collections.Generic;
using _01_LampShadeQuery.Contracts.ArticleCategory;
using _01_LampShadeQuery.Contracts.ProductCategory;

namespace _01_LampshadeQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
