using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exercicios.Ex1
{
    public class ProdutoEletronico : ProdutoBase
    {     
        public string Especificacoes { get; set; }
        public DateTime DataFabricacao { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Preço: {Preco:C}, Especificações: {Especificacoes}, Fabricado em: {DataFabricacao.ToShortDateString()}";
        }
    }

}