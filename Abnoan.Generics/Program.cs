using System.Diagnostics;
using Abnoan.Generics;
using Abnoan.Generics.Exemplos.TAbstract;
using Abnoan.Generics.Exemplos.TClass;
using Abnoan.Generics.Exemplos.TInterface;
using Abnoan.Generics.Exemplos.TNew;
using Abnoan.Generics.Interface;
using Abnoan.Generics.Performace;
using Abnoan.Generics.Restricao;
using Abnoan.Generics.Metodos;
using Utilidades;
using Abnoan.Generics.Exercicios.Ex1;
using Abnoan.Generics.Exercicios.Ex1.Ex2;
using Abnoan.Generics.Exercicios.Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Box
        Box<int> minhaCaixaInt = new Box<int>();
        minhaCaixaInt.Adicionar(123);

        Box<string> minhaCaixaString = new Box<string>();
        minhaCaixaString.Adicionar("Olá, mundo!");

        Box<Peixe> minhaCaixaDePeixes = new Box<Peixe>();
        minhaCaixaDePeixes.Adicionar(new Peixe("Nemo"));

        Box<Gato> minhaCaixaDeGatos = new Box<Gato>();
        minhaCaixaDeGatos.Adicionar(new Gato("Frajola"));

        #endregion

        #region Restrição de Tipo
        // Cria um Armazem de produtos
        Armazem<ProdutoArmazenavel> armazemProdutos = new Armazem<ProdutoArmazenavel>();

        // Cria um produto
        ProdutoArmazenavel produto = new ProdutoArmazenavel();
        produto.Nome = "Camisa";
        produto.Preco = 59.90m;

        // Adiciona o produto ao Armazem
        armazemProdutos.AdicionarItem(produto);

        // Cria um usuário
        Usuario usuario = new Usuario();
        usuario.Nome = "João";
        usuario.Email = "joao@email.com";

        // Tenta adicionar o usuário ao Armazem.
        //armazemProdutos.AdicionarItem(usuario);
        //Armazem<Usuario> armazemUsuarios = new Armazem<Usuario>();

        // Salva todos os produtos no Armazem
        armazemProdutos.SalvarTodos();
        #endregion

        #region Ex 1 - TClass
        var carro = new Carro();
        var storage = new Storage<Carro>(carro);
        storage.Display();
        #endregion

        #region Ex 2 - TAbstract
        var carroEsportivo = new CarroEsportivo();
        var veiculoStorage = new VeiculoStorage<CarroEsportivo>(carroEsportivo);
        veiculoStorage.AceleraVeiculo();
        #endregion

        #region Ex 3 - TInterface
        var caminhao = new Caminhao();
        var transporteManager = new TransporteManager<Caminhao>(caminhao);
        transporteManager.IniciarTransporte();
        #endregion

        #region Ex 4 - TNew        
        var creator = new Creator<Produto>();
        Produto novoProduto = creator.CreateInstance();
        Console.WriteLine(novoProduto.ToString());
        #endregion

        #region Interface Generica
        // Criando repositórios para produtos e clientes
        RepositorioProduto repositorioProduto = new RepositorioProduto();
        RepositorioCliente repositorioCliente = new RepositorioCliente();

        // Adicionando produtos e clientes
        Produto produto1 = new Produto { Id = 1, Nome = "Produto 1" };
        Produto produto2 = new Produto { Id = 2, Nome = "Produto 2" };

        Usuario cliente1 = new Usuario { Id = 1, Nome = "Cliente 1" };
        Usuario cliente2 = new Usuario { Id = 2, Nome = "Cliente 2" };

        repositorioProduto.Adicionar(produto1);
        repositorioProduto.Adicionar(produto2);

        repositorioCliente.Adicionar(cliente1);
        repositorioCliente.Adicionar(cliente2);

        // Obtendo produtos e clientes por ID
        Produto produtoObtido = repositorioProduto.ObterPorId(1);
        Usuario clienteObtido = repositorioCliente.ObterPorId(2);

        // Removendo produtos e clientes
        repositorioProduto.Remover(produto2);
        repositorioCliente.Remover(cliente1);
        #endregion

        #region Metodos
        // Exemplo para ConverterParaString
        int numero = 123;
        Console.WriteLine("Converter inteiro para string: " + Util.ConverterParaString(numero));

        // Exemplo para Maior
        int valor1 = 10;
        int valor2 = 20;
        Console.WriteLine("Maior valor entre 10 e 20: " + Util.Maior(valor1, valor2));

        // Exemplo para EhNulo
        string textoNulo = null;
        string texto = "Olá, Mundo!";
        Console.WriteLine("O texto é nulo? " + Util.EhNulo(texto));
        Console.WriteLine("O textoNulo é nulo? " + Util.EhNulo(textoNulo));

        // Exemplo para Trocar
        string a = "primeiro";
        string b = "segundo";
        Console.WriteLine("Antes da troca: a = " + a + ", b = " + b);
        a = Util.Trocar(a, b);
        Console.WriteLine("Depois da troca: a = " + a + ", b = " + b);

        string stringVazia = "";
        string stringNula = null;
        string stringPreenchida = "Olá, mundo!";

        List<int> listaVazia = new List<int>();
        List<int> listaPreenchida = new List<int> { 1, 2, 3 };

        // Testando com strings
        Console.WriteLine("A string vazia é nula ou vazia? " + Util.EhNuloOuVazio(stringVazia)); // Deve retornar verdadeiro
        Console.WriteLine("A string nula é nula ou vazia? " + Util.EhNuloOuVazio(stringNula)); // Deve retornar verdadeiro
        Console.WriteLine("A string preenchida é nula ou vazia? " + Util.EhNuloOuVazio(stringPreenchida)); // Deve retornar falso

        // Testando com listas
        Console.WriteLine("A lista vazia é nula ou vazia? " + Util.EhNuloOuVazio(listaVazia)); // Deve retornar verdadeiro
        Console.WriteLine("A lista preenchida é nula ou vazia? " + Util.EhNuloOuVazio(listaPreenchida)); // Deve retornar falso
        #endregion


        #region Performace
        Stopwatch cronometro = new Stopwatch();
        long tempoAdicaoNaoGenerico, tempoRecuperacaoNaoGenerico, tempoAdicaoGenerico, tempoRecuperacaoGenerico;

        ListaSimples listaSimples = new ListaSimples(10000);
        cronometro.Start();

        for (int i = 0; i < 10000; i++)
        {
            listaSimples.AdicionarItem(i);
        }

        cronometro.Stop();
        tempoAdicaoNaoGenerico = cronometro.ElapsedTicks;

        cronometro.Restart();

        for (int i = 0; i < 10000; i++)
        {
            var item = listaSimples.ObterItem(i);
        }

        cronometro.Stop();
        tempoRecuperacaoNaoGenerico = cronometro.ElapsedTicks;

        ListaGenerica<int> listaGenerica = new ListaGenerica<int>(10000);
        cronometro.Restart();

        for (int i = 0; i < 10000; i++)
        {
            listaGenerica.AdicionarItem(i);
        }

        cronometro.Stop();
        tempoAdicaoGenerico = cronometro.ElapsedTicks;

        cronometro.Restart();

        for (int i = 0; i < 10000; i++)
        {
            var item = listaGenerica.ObterItem(i);
        }

        cronometro.Stop();
        tempoRecuperacaoGenerico = cronometro.ElapsedTicks;

        double tickTime = 1000000000.0 / Stopwatch.Frequency;

        // Os tempos são medidos em ticks e convertidos para milesegundos para uma maior precisão.
        Console.WriteLine("Adição de 10.000 itens - Não Genérico: " + tempoAdicaoNaoGenerico + " ms");
        Console.WriteLine("Adição de 10.000 itens - Genérico: " + tempoAdicaoGenerico + " ms");
        Console.WriteLine("Recuperação de 10.000 itens - Não Genérico: " + tempoRecuperacaoNaoGenerico + " ms");
        Console.WriteLine("Recuperação de 10.000 itens - Genérico: " + tempoRecuperacaoGenerico + " ms");

        #endregion

        #region Ex1
        // Inventário de produtos eletrônicos
        Inventario<ProdutoEletronico> inventarioEletronicos = new Inventario<ProdutoEletronico>();

        // Criar e adicionar produtos eletrônicos
        ProdutoEletronico produtoEletronico1 = new ProdutoEletronico
        {
            Id = 1,
            Nome = "Smartphone",
            Preco = 2500.00M,
            Especificacoes = "Processador Snapdragon 8 Gen 1, 8GB RAM, 256GB armazenamento",
            DataFabricacao = new DateTime(2024, 04, 28)
        };

        ProdutoEletronico produtoEletronico2 = new ProdutoEletronico
        {
            Id = 2,
            Nome = "Notebook",
            Preco = 4500.00M,
            Especificacoes = "Intel Core i7-12700H, 16GB RAM, 512GB SSD",
            DataFabricacao = new DateTime(2024, 04, 28)
        };

        inventarioEletronicos.AdicionarItem(produtoEletronico1);
        inventarioEletronicos.AdicionarItem(produtoEletronico2);

        // Listar produtos eletrônicos
        inventarioEletronicos.ListarItens();

        // Inventário de produtos alimentícios
        Inventario<ProdutoAlimenticio> inventarioAlimentos = new Inventario<ProdutoAlimenticio>();

        // Criar e adicionar produtos alimentícios
        ProdutoAlimenticio produtoAlimento1 = new ProdutoAlimenticio
        {
            Id = 1,
            Nome = "Arroz",
            Preco = 5.00M,
            DataValidade = new DateTime(2025, 04, 28),
            PesoGramas = 1000,
            Ingredientes = new List<string> { "Arroz branco" }
        };

        ProdutoAlimenticio produtoAlimento2 = new ProdutoAlimenticio
        {
            Id = 2,
            Nome = "Feijão",
            Preco = 8.00M,
            DataValidade = new DateTime(2025, 05, 28),
            PesoGramas = 500,
            Ingredientes = new List<string> { "Feijão preto" }
        };

        inventarioAlimentos.AdicionarItem(produtoAlimento1);
        inventarioAlimentos.AdicionarItem(produtoAlimento2);

        inventarioAlimentos.ListarItens();
        #endregion

        #region Ex 2
        // Criação de um produto eletrônico
        var smartphone = new ProdutoEletronico
        {
            Id = 1,
            Nome = "Smartphone X",
            Preco = 90050.00m,
            Especificacoes = "128GB, 6GB RAM",
            DataFabricacao = new DateTime(2022, 1, 1)
        };

        // Criação de um produto alimentício
        var biscoito = new ProdutoAlimenticio
        {
            Id = 2,
            Nome = "Biscoito Integral",
            Preco = 3.50m,
            DataValidade = new DateTime(2024, 12, 31),
            PesoGramas = 100,
            Ingredientes = new List<string> { "Trigo integral", "Açúcar", "Sal" }
        };

        // Teste de validação de preço
        Console.WriteLine("Validação de preço do Smartphone: " + (Utilidade.ValidarPreco(smartphone) ? "Válido" : "Inválido"));
        Console.WriteLine("Validação de preço do Biscoito: " + (Utilidade.ValidarPreco(biscoito) ? "Válido" : "Inválido"));

        // Teste de validação de data de validade
        Console.WriteLine("Validação da data de validade do Biscoito: " + (Utilidade.ValidarDataValidade(biscoito) ? "Válido" : "Expirado"));
        #endregion

    }
}