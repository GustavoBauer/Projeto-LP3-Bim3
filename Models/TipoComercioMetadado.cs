using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLP3.Models
{

    [MetadataType(typeof(TipoComercioMetadado))]
    public partial class TipoComercio { }

    public class TipoComercioMetadado
    {
        [Required(ErrorMessage = "O Tipo de Comércio é obrigatório!", AllowEmptyStrings = false)]
        [Display(Name = "Identificação Tipo de Comércio")]
        public int IdComercio { get; set; }


        [Required(ErrorMessage = "A Descrição é obrigatória!", AllowEmptyStrings = false)]
        [StringLength(1000, MinimumLength = 20, ErrorMessage = "A Descrição deve ter entre 20 e 1000 Caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "O Orgão Regulador é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O Orgão Regulador deve ter entre 10 e 200 Caracteres")]
        [Display(Name = "Orgão Regulador")]
        public string OrgaoRegulador { get; set; }


        [Required(ErrorMessage = "A Permissão é obrigatória!", AllowEmptyStrings = false)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "A Permissão deve ter entre 5 e 20 Caracteres")]
        [Display(Name = "Permissão")]
        public string Permissao { get; set; }


        [Required(ErrorMessage = "O Nome do Comércio é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O Nome do Comércio deve ter entre 5 e 50 Caracteres")]
        [Display(Name = "Nome do Comércio")]
        public string Nome { get; set; }
    }
}