using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLP3.Models
{
    public class ResultadoPesquisa1 //Ruas a partir de Bairro e Tipo de Comércio
    {
        public string Nome { get; set; }
        public string CEP { get; set; }
    }

    public class ResultadoPesquisa2 //Lojas a partir de Rua
    {
        public string NomeComercial { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
    }

    public class ResultadoPesquisa3 //Ruas a partir de Tipo de Comércio
    {
        public string Nome { get; set; }
        public string CEP { get; set; }
    }
}