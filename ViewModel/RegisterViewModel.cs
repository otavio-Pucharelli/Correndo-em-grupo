using System.ComponentModel.DataAnnotations;

namespace CorrendoEmGrupo.ViewModel
{
    public class RegisterViewModel
    {
        [Display(Name = "Endereço de Email")]
        [Required(ErrorMessage = "O email é Obrigatório")]
        public string EmailAddress { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "A senha é Obrigatória")]
        public string Password { get; set; }
        [Display(Name = "Confirma Senha")]
        [Required(ErrorMessage = "A Confimação da senha é Obrigatória")]
        [Compare("Password", ErrorMessage = "As senhas não são Iguais")]
        public string ConfirmPassword { get; set; }
    }
}
