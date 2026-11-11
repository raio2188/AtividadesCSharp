using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OficinaEF.Areas.Identity.Pages.Account;

public class RegisterConfirmationModel : PageModel
{
    public IActionResult OnGet() => RedirectToAction("Login", "Conta", new { area = "" });

    public IActionResult OnPost() => RedirectToAction("Login", "Conta", new { area = "" });
}
