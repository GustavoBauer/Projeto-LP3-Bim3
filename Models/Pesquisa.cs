using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLP3.Models
{
    public class Pesquisa1 //Ruas a partir de Bairro e Tipo de Comércio
    {
        public int IdBairro { get; set; }
        public int IdComercio { get; set; }
    }

    public class Pesquisa2 //Lojas a partir de Rua
    {
        public int IdRua { get; set; }
    }

    public class Pesquisa3 //Ruas a partir de Tipo de Comércio
    {
        public int IdComercio { get; set; }
    }
}