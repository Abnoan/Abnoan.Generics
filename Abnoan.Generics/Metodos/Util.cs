using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Metodos
{
    public static class Util
    {
        #region Métodos sem restrição de tipo

        /// <summary>
        /// Troca os valores de duas variáveis.
        /// </summary>
        /// <typeparam name="T">Tipo das variáveis.</typeparam>
        /// <param name="valor1">Primeira variável.</param>
        /// <param name="valor2">Segunda variável.</param>
        /// <returns>Novo valor da primeira variável.</returns>
        public static T Trocar<T>(T valor1, T valor2)
        {
            T temp = valor1;
            valor1 = valor2;
            valor2 = temp;
            return valor1;
        }

        /// <summary>
        /// Verifica se um valor é nulo.
        /// </summary>
        /// <param name="valor">Valor a ser verificado.</param>
        /// <returns>Verdadeiro se o valor for nulo, falso caso contrário.</returns>
        public static bool EhNulo<T>(T valor)
        {
            return valor == null;
        }

        #endregion

        #region Métodos com restrição de tipo

        /// <summary>
        /// Compara dois valores e retorna o maior.
        /// </summary>
        /// <typeparam name="T">Tipo dos valores.</typeparam>
        /// <param name="valor1">Primeiro valor.</param>
        /// <param name="valor2">Segundo valor.</param>
        /// <returns>O maior valor entre os dois.</returns>
        /// <exception cref="ArgumentException">Se os valores não forem comparáveis.</exception>
        public static T Maior<T>(T valor1, T valor2) where T : IComparable<T>
        {
            if (valor1.CompareTo(valor2) > 0)
            {
                return valor1;
            }
            else if (valor1.CompareTo(valor2) < 0)
            {
                return valor2;
            }
            else
            {
                throw new ArgumentException("Os valores não podem ser comparados.");
            }
        }

        /// <summary>
        /// Converte um valor para uma string.
        /// </summary>
        /// <typeparam name="T">Tipo do valor.</typeparam>
        /// <param name="valor">Valor a ser convertido.</param>
        /// <returns>Representação em string do valor.</returns>
        public static string ConverterParaString<T>(T valor) where T : IConvertible
        {
            return valor.ToString();
        }

        /// <summary>
        /// Verifica se um objeto é nulo ou vazio.
        /// </summary>
        /// <typeparam name="T">Tipo do objeto.</typeparam>
        /// <param name="obj">Objeto a ser verificado.</param>
        /// <returns>Verdadeiro se o objeto for nulo ou vazio, falso caso contrário.</returns>
        public static bool EhNuloOuVazio<T>(T obj) where T : class
        {
            if (obj == null)
            {
                return true;
            }

            // Verifica se o objeto é uma string vazia
            if (obj is string str && str.Length == 0)
            {
                return true;
            }

            // Verifica se o objeto é um IEnumerable vazio
            if (obj is IEnumerable enumerable && !enumerable.Cast<object>().Any())
            {
                return true;
            }

            // Para outros tipos de classes, retorna falso
            return false;
        }

        #endregion
    }
}