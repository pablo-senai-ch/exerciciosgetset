using dia_1506;
 //// exemplos ////
// ContaBancaria conta = new ContaBancaria();
// conta.Saldo = 2000;

// Pessoa pessoa = new Pessoa();
// pessoa.Nome = "Flexa";


///// 1 //////
// Aluno aluno = new Aluno();
// aluno.Nota = 9;
// Console.WriteLine(aluno.Nota);


///// 2 ////////
// Produto produto = new Produto();
// produto.Preco = 10.99;
// Console.WriteLine(produto.Preco);

//// 3 ////////
// Livro livro = new Livro();
// livro.Titulo = "o nome do livro é: Poltergeist";
// livro.Autor = "o autor é: James Kah";
// livro.numeroPaginas = 272;

// Console.WriteLine(livro.Titulo);
// Console.WriteLine(livro.Autor);
// Console.WriteLine(livro.numeroPaginas);

///// 4 /////

// class Program
// {
//     static void Main(string[] args)
//     {
//         Conta conta = new Conta();
//         conta.Depositar(1000);
//         conta.Sacar(500);

//         Console.WriteLine(conta.Saldo);
//     }
// }

//// 5 ////
// Carro carro = new Carro();
// carro.Ano = 1900;
// Console.WriteLine(carro.Ano);

///// 6 ///////
// Pessoas pessoas = new Pessoas();
// pessoas.Idade = 19;
// Console.WriteLine (pessoas.Idade);

//// 7 //////
// Retangulo retangulo = new Retangulo();
// retangulo.CalcularArea();
// Console.WriteLine(retangulo.CalcularArea());

// //// 8 ///
// Funcionario funcionario = new Funcionario();
// funcionario.Salario = 1209;
// Console.WriteLine(funcionario.Salario);


///////////////// INTERMEDIARIOS ////////////////   

/// 1 /////
// Circulo circulo = new Circulo();
// circulo.Raio = 20;
// Console.WriteLine(circulo.Area);
// Console.WriteLine(circulo.Diametro);

//// 2 /////
Data d = new Data();

d.Ano = 2024;
d.Mes = 2;
d.Dia = 29;

Console.WriteLine(d.Dia);
//// 3 ////

Temperatura t = new Temperatura();

t.Celsius = 25;

Console.WriteLine("Temperatura em Celsius: " + t.Celsius);
Console.WriteLine("Temperatura em Fahrenheit: " + t.Fahrenheit);

/// 4 ///
        Voo v = new Voo();

        v.NumeroVoo = 123;
        v.Origem = "São Paulo";
        v.Destino = "Rio de Janeiro";

        Console.WriteLine("Voo:");
        Console.WriteLine(v.NumeroVoo);
        Console.WriteLine(v.Origem);
        Console.WriteLine(v.Destino);

        Console.WriteLine("----------------");

////// 5 ////
// Paciente p = new Paciente();
//  p.Nome = "João";
// p.Peso = 70;

// Console.WriteLine("Paciente:");
// Console.WriteLine(p.Nome);
// Console.WriteLine(p.Peso);

/////// 6 //////
static void Main(string[] args)
    {

        Triangulo t = new Triangulo();

        t.LadoA = 3;
        t.LadoB = 4;
        t.LadoC = 5;

        Console.WriteLine("Triângulo:");
        Console.WriteLine($"Lado A: {t.LadoA}");
        Console.WriteLine($"Lado B: {t.LadoB}");
        Console.WriteLine($"Lado C: {t.LadoC}");

        Console.WriteLine("----------------");
    }

/////// 7 /////
  Imovel im = new Imovel();

        im.Endereco = "Rua Central";
        im.Valor = 100000;

        Console.WriteLine("Imóvel:");
        Console.WriteLine(im.Endereco);
        Console.WriteLine(im.Valor);

        im.AplicarDesconto(10);

        Console.WriteLine("Após desconto:");
        Console.WriteLine(im.Valor);
    
