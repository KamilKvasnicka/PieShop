using Microsoft.AspNetCore.Mvc;
using SecFirstScratch.Models;

namespace SecFirstScratch.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
        {
            PiesOfTheWeek = piesOfTheWeek;
        }
        
    }
}
