using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using OficinaEF.Data;
using OficinaEF.Models;

namespace OficinaEF.Controllers;

[AutoValidateAntiforgeryToken]
public class ContaController(SignInManager<IdentityUser> signIn, UserManager<IdentityUser> users,
    ApplicationDbContext db, IEmailSender mail) : Controller
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

        ModelState.AddModelError("", "Não foi possível entrar. Confira o e-mail, a senha e a confirmação da conta.");
        return View(model);
    }

    [HttpGet]
    public IActionResult Cadastro(string? returnUrl) => View(new CadastroViewModel { ReturnUrl = Destino(returnUrl) });

    [HttpPost]
    public async Task<IActionResult> Cadastro(CadastroViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var user = new IdentityUser { UserName = model.Email, Email = model.Email };
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
        var token = await users.GenerateEmailConfirmationTokenAsync(user);
        var code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
        var link = Url.Page("/Account/ConfirmEmail", null, new { area = "Identity", userId = user.Id, code, returnUrl }, Request.Scheme)!;
        await mail.SendEmailAsync(model.Email, "Confirme seu e-mail",
            $"Para confirmar a conta, <a href=\"{HtmlEncoder.Default.Encode(link)}\">acesse este link</a>.");

        if (users.Options.SignIn.RequireConfirmedAccount)
            return RedirectToPage("/Account/RegisterConfirmation", new { area = "Identity", email = model.Email, returnUrl });
        await signIn.SignInAsync(user, isPersistent: false);
        return LocalRedirect(returnUrl);
    }
}
