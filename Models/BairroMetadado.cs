using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLP3.Models
{
    [MetadataType(typeof(BairroMetadado))]
    public partial class Bairro { }

    public class BairroMetadado
    {
        [Required(ErrorMessage = "A Identificação do Bairro é obrigatória!", AllowEmptyStrings = false)]
        [Display(Name = "Identificação Bairro")]
        public int IdBairro{get; set;}


        [Required(ErrorMessage = "A Cidade é obrigatória!", AllowEmptyStrings =  false)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A Cidade deve ter entre 5 e 50 Caracteres")]
        public string Cidade {get; set;}


        [Required(ErrorMessage = "A UF é obrigatória!", AllowEmptyStrings = false)]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "A UF deve ter exatamente 2 Caracteres")]
        [RegularExpression(@"^[A-Z]{2}$", 
            ErrorMessage = "A UF deve conter apenas dois digito maiúsculos")]
        public string UF { get; set; }


        [Required(ErrorMessage = "A Zona é obrigatória!", AllowEmptyStrings = false)]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "A Zona deve ter entre 3 e 10 Caracteres")]
        [Display(Name = "Zona da Cidade")]
        public string Zona { get; set; }


        [Required(ErrorMessage = "O Nome do Bairro é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A Nome do Bairro deve ter entre 5 e 50 Caracteres")]
        [Display(Name = "Nome do Bairro")]
        public string Nome { get; set; }
    }
}