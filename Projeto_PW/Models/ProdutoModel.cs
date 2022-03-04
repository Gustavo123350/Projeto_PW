using System;
using System.Collections.Generic;

namespace Projeto_PW.Models
{
    public class ProdutoModel
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataVencimento { get; set; }
        public CategoriaModel Categoria { get; set; }
        public List<CategoriaModel> ListaCategoriaDisponiveis { get; set; }
    }
}
