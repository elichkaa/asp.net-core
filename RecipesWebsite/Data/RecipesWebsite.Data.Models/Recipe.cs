namespace RecipesWebsite.Data.Models
{
    using System;
    using System.Collections.Generic;
    using RecipesWebsite.Data.Common.Models;

    public class Recipe : BaseDeletableModel<int>
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<RecipeIngredient>();
            this.Images = new HashSet<Image>();
        }

        public string Name { get; set; }

        public string Instructions { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionCount { get; set; }

        public string CreatedByUserId { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ApplicationUser CreatedByUser { get; set; }

        public ICollection<RecipeIngredient> Ingredients { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
