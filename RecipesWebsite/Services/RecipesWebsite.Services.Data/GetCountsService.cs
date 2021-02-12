namespace RecipesWebsite.Services.Data
{
    using System.Linq;
    using RecipesWebsite.Data.Common.Repositories;
    using RecipesWebsite.Data.Models;
    using ViewModels;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;
        private readonly IRepository<Image> imagesRepository;

        public GetCountsService(
            IDeletableEntityRepository<Recipe> recipesRepository,
            IDeletableEntityRepository<Category> categoriesRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository,
            IRepository<Image> imagesRepository)
        {
            this.recipesRepository = recipesRepository;
            this.categoriesRepository = categoriesRepository;
            this.ingredientsRepository = ingredientsRepository;
            this.imagesRepository = imagesRepository;
        }

        public CountsViewModel GetCounts()
        {
            var viewModel = new CountsViewModel
            {
                RecipesCount = this.recipesRepository.All().Count(),
                CategoriesCount = this.categoriesRepository.All().Count(),
                IngredientsCount = this.ingredientsRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
            };
            return viewModel;
        }
    }
}
