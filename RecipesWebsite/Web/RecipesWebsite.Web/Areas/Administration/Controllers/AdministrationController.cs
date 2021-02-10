namespace RecipesWebsite.Web.Areas.Administration.Controllers
{
    using RecipesWebsite.Common;
    using RecipesWebsite.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
