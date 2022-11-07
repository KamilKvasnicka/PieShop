using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecFirstScratch.Controllers;
using SecFirstScratch.ViewModels;
using SecFirstScratchTest.Mocks.SecFirstScratchTest.Mocks;

namespace SecFirstScratchTest.Controllers
{
    [ExcludeFromCodeCoverage]
    public class PieControllerTests
    {
        [Fact]
        public void List_EmptyCategoryReturnsAllPies()
        {
            //Arrange
            var mockPieRepository = RepositoryMocks.GetPieRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

            var pieController = new PieController(mockPieRepository.Object, mockCategoryRepository.Object);

            //Act
            var result = pieController.List("");

            //Assert
            Assert.NotNull(result);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
            Assert.Equal(10,pieListViewModel.Pies.Count());
            
        }
    }
}
