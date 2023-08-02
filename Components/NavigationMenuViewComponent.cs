using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components;

public class NavigationMenuViewComponent : ViewComponent
{
    public IStoreRepository repository;
    public NavigationMenuViewComponent(IStoreRepository repository)
    {
        this.repository = repository;
    }
    public IViewComponentResult Invoke()
    {
        ViewBag.SelectedCategory = HttpContext.Request.Query["category"];
        return View(repository.Products
        .Select(x => x.Category)
        .Distinct()
        .OrderBy(x => x)
        );
    }
}
