namespace RecipesWebsite.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using AutoMapper;
    using Data;
    using Data.Common.Repositories;
    using Data.Models;
    using RecipesWebsite.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using Services.Data;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService getCountsService;

        public HomeController(IGetCountsService getCountsService)
        {
            this.getCountsService = getCountsService;
        }

        public IActionResult Index()
        {
            var dto = this.getCountsService.GetCounts();
            var viewModel = new IndexViewModel
            {
                RecipesCount = dto.RecipesCount,
                CategoriesCount = dto.CategoriesCount,
                IngredientsCount = dto.IngredientsCount,
                ImagesCount = dto.ImagesCount,
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
