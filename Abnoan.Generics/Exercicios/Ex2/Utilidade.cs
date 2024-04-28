using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abnoan.Generics.Exercicios.Ex1;
using Abnoan.Generics.Exercicios.Ex1.Ex2;

namespace Abnoan.Generics.Exercicios.Ex2
{
    public static class Utilidade
    {
        public static bool ValidarPreco<T>(T produto) where T : ProdutoBase
        {
            return produto.Preco >= 0 && produto.Preco <= 10000; // Exemplo de validação de preço
        }

        public static bool ValidarDataValidade<T>(T produto) where T : ProdutoAlimenticio
        {
            return produto.DataValidade >= DateTime.Now; // Validar que o produto não está expirado
        }
    }

}