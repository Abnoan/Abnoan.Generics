using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exercicios.Ex1.Ex2
{
    public class ProdutoAlimenticio : ProdutoBase
    {   
        public DateTime DataValidade { get; set; }
        public int PesoGramas { get; set; }
        public List<string> Ingredientes { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Preço: {Preco:C}, Validade: {DataValidade.ToShortDateString()}, Peso: {PesoGramas}g, Ingredientes: {string.Join(", ", Ingredientes)}";
        }
    }
}