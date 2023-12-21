using dressShop_Razor.Data;
using dressShop_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dressShop_Razor.Pages.Categories
{
    [BindProperties]
    public class editModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public editModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0) {
                Category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
               TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
