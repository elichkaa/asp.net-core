namespace RecipesWebsite.Services.Data
{
    using System.Threading.Tasks;
    using Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputViewModel input);
    }
}
