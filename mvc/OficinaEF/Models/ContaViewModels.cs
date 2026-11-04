using System.ComponentModel.DataAnnotations;

namespace OficinaEF.Models;

public abstract class ContaViewModel
{
    [Required(ErrorMessage = "Informe seu e-mail.")]
    [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
    public string Email { get; set; } = "";

    public string? ReturnUrl { get; set; }
}

public class LoginViewModel : ContaViewModel
{
    [Required(ErrorMessage = "Informe sua senha.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; } = "";

    public bool Lembrar { get; set; }
}

public class CadastroViewModel : ContaViewModel
{
    [Required(ErrorMessage = "Informe seu nome.")]
    [StringLength(120, ErrorMessage = "Use até 120 caracteres no nome.")]
    public string Nome { get; set; } = "";

    [Required(ErrorMessage = "Informe uma senha.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Use de 6 a 100 caracteres na senha.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; } = "";

    [Required(ErrorMessage = "Confirme sua senha.")]
    [DataType(DataType.Password)]
    [Compare(nameof(Senha), ErrorMessage = "As senhas precisam ser iguais.")]
    public string Confirmacao { get; set; } = "";
}
