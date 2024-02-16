using Microsoft.AspNetCore.Mvc.RazorPages;
using StanimalisThriftShopRazor_Temp.Data;
using StanimalisThriftShopRazor_Temp.Models;

namespace StanimalisThriftShopRazor_Temp.Pages.Categories;

public class IndexModel : PageModel
{
	private readonly ApplicationDbContext _db;
    public List<Category> CategoryList { get; set; }
    public IndexModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet()
	{
        CategoryList = _db.Categories.ToList();
	}
}
