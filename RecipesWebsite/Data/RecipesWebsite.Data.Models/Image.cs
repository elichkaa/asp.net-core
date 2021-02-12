namespace RecipesWebsite.Data.Models
{
    using System;
    using System.Diagnostics.Contracts;
    using RecipesWebsite.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        public int AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public string Extension { get; set; }
    }
}
