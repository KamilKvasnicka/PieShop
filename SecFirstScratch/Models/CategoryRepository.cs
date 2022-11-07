namespace SecFirstScratch.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContex;

        public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContex)
        {
            _bethanysPieShopDbContex = bethanysPieShopDbContex;
        }

        public IEnumerable<Category>AllCategories =>_bethanysPieShopDbContex.Categories.OrderBy(p=>p.CategoryName);
    }
}
