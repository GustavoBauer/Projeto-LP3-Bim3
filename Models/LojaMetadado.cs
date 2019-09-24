using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLP3.Models
{
    [MetadataType(typeof(LojaMetadado))]
    public partial class Loja { }

    public class LojaMetadado
    {
        [Required(ErrorMessage = "A Identificação da Loja é obrigatória!", AllowEmptyStrings = false)]
        [Display(Name = "Identificação Loja")]
        public int IdLoja { get; set; }


        [Required(ErrorMessage = "A Identificação de Rua é obrigatório!", AllowEmptyStrings = false)]
        [Display(Name = "Identificação Rua")]
        public int FkRua { get; set; }

        [Required(ErrorMessage = "O CNPJ é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CNPJ deve ter exatamente 14 caracteres")]
        [RegularExpression(@"^\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$",
            ErrorMessage = "Formato incorreto de CNPJ")]
        [System.Web.Mvc.Remote("ValidaCPNJ", "Loja", ErrorMessage = "Este CPF já existe no sistema")]
        public string CNPJ { get; set; }


        [Required(ErrorMessage = "O Nome Comercial é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Nome Comercial deve ter entre 5 e 100 Caracteres")]
        [Display(Name = "Nome Comercial")]
        public string NomeComercial { get; set; }


        [Required(ErrorMessage = "A Razão Social é obrigatória!", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A Razão Social deve ter entre 5 e 100 Caracteres")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }


        [Required(ErrorMessage = "O Telefone é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "O Telefone deve ter no minimo 8 caracteres e no máximo 9")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }


        [StringLength(200, MinimumLength = 10, ErrorMessage = "O Site deve ter entre 10 e 200 Caracteres")]
        [Display(Name = "Site")]
        public string Site { get; set; }
    }
}