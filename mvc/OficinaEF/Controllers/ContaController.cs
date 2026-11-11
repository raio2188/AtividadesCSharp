using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OficinaEF.Data;
using OficinaEF.Models;

namespace OficinaEF.Controllers;

[AutoValidateAntiforgeryToken]
public class ContaController(SignInManager<IdentityUser> signIn, UserManager<IdentityUser> users,
    ApplicationDbContext db) : Controller
{
    private string Destino(string? url) => Url.IsLocalUrl(url) ? url! : Url.Content("~/");

    [HttpGet]
    public async Task<IActionResult> Login(string? returnUrl)
    {
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
        if (TempData["ErrorMessage"] is string error)
            ModelState.AddModelError("", error);
        return View(new LoginViewModel { ReturnUrl = Destino(returnUrl) });
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid) return View(model);
        var result = await signIn.PasswordSignInAsync(model.Email, model.Senha, model.Lembrar, lockoutOnFailure: false);
        var returnUrl = Destino(model.ReturnUrl);
        if (result.Succeeded) return LocalRedirect(returnUrl);
        if (result.RequiresTwoFactor)
            return RedirectToPage("/Account/LoginWith2fa", new { area = "Identity", returnUrl, rememberMe = model.Lembrar });
        if (result.IsLockedOut) return RedirectToPage("/Account/Lockout", new { area = "Identity" });

        ModelState.AddModelError("", "Não foi possível entrar. Confira o e-mail e a senha.");
        return View(model);
    }

    [HttpGet]
    public IActionResult Cadastro(string? returnUrl) => View(new CadastroViewModel { ReturnUrl = Destino(returnUrl) });

    [HttpPost]
    public async Task<IActionResult> Cadastro(CadastroViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
        await using (var transaction = await db.Database.BeginTransactionAsync())
        {
            var result = await users.CreateAsync(user, model.Senha);
            if (result.Succeeded)
                result = await users.AddClaimAsync(user, new Claim(ClaimTypes.GivenName, model.Nome.Trim()));
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error.Description);
                return View(model);
            }
            await transaction.CommitAsync();
        }

        var returnUrl = Destino(model.ReturnUrl);
        await signIn.SignInAsync(user, isPersistent: false);
        return LocalRedirect(returnUrl);
    }
}
