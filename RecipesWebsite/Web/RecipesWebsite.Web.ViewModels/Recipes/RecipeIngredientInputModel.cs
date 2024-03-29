﻿namespace RecipesWebsite.Web.ViewModels.Recipes
{
    using System.ComponentModel.DataAnnotations;

    public class RecipeIngredientInputModel
    {
        [Required]
        [MinLength(3)]
        public string IngredientName { get; set; }

        [Required]
        [MinLength(3)]
        public string Quantity { get; set; }
    }
}
