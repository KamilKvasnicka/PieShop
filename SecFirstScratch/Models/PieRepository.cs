using Microsoft.EntityFrameworkCore;

namespace SecFirstScratch.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContex;
        public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContex)
        {
            _bethanysPieShopDbContex = bethanysPieShopDbContex;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _bethanysPieShopDbContex.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _bethanysPieShopDbContex.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);
            }
        }
        public Pie? GetPieById(int pieId)
        {
            return _bethanysPieShopDbContex.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            return _bethanysPieShopDbContex.Pies.Where(p => p.Name.Contains(searchQuery));
        }
    }
}
