using System.ComponentModel.DataAnnotations;

namespace ProjetoLP3.Models
{

    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario { }

    public class UsuarioMetadado
    {
        [Required(ErrorMessage = "A Identificação de Usuário é obrigatória!")]
        [Display(Name = "Identificação de Usuário")]
        public int IdUsuario{ get; set; }


        [Required(ErrorMessage = "O Login de Usuário é obrigatório!")]
        [Display(Name = "Login do Usuário")]
        public int Login { get; set; }

        [Required(ErrorMessage = "A Senha do Usuário é obrigatória!")]
        [StringLength(24, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 e 24 caracteres")]
        [Display(Name = "Senha do Usuário")]
        public string Senha { get; set; }


        [Required(ErrorMessage = "O Nome do Usuário é obrigatório!")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "O nome deve ter no entre 10 e 1000 Caracteres")]
        [Display(Name = "Nome do Usuário")]
        public string Nome { get; set; }
    }
}