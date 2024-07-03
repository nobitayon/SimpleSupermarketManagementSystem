using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Views.Categories;

namespace WebApp.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Index()
    {
        var categories = CategoriesRepository.GetCategories();
        return View(categories);
    }

    public IActionResult Edit([FromRoute]int? id)
    {
        var category = CategoriesRepository.GetCategoryById(id ?? 0);

        return View(category);
    }
}
