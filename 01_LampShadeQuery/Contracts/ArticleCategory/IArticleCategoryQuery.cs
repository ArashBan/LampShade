using System.Collections.Generic;

namespace _01_LampShadeQuery.Contracts.ArticleCategory
{
    public interface IArticleCategoryQuery
    {
        ArticleCategoryQueryModel GetArticleCategory(string slug);
        public List<ArticleCategoryQueryModel> GetArticleCategories();
    }
}
