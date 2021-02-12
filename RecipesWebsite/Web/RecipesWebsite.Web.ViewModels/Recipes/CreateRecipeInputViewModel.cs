namespace RecipesWebsite.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.WebPages.Html;

    public class CreateRecipeInputViewModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(100)]
        public string Instructions { get; set; }

        [Range(0, 24 * 60)]
        [DisplayName("Preparation time int minutes")]
        public int PreparationTime { get; set; }

        [Range(0, 24 * 60)]
        [DisplayName("Cooking time int minutes")]
        public int CookingTime { get; set; }

        [Range(1, 100)]
        public int PortionCount { get; set; }

        public string CreatedByUserId { get; set; }

        public int CategoryId { get; set; }

        public ICollection<RecipeIngredientInputModel> Ingredients { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Categories { get; set; } 
    }
}
