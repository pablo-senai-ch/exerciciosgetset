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

class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta();
        conta.Depositar(1000);
        conta.Sacar(500);

        Console.WriteLine(conta.Saldo);
    }
}