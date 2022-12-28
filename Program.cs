using bytebank.Funcionarios;
using bytebank.Utilitario;

class Program
{
  public static void Main(string[] args)
  {
    Funcionario pedro = new Funcionario();
    pedro.Nome = "Pedro malazartes";
    pedro.Cpf = "123456789";
    pedro.Salario = 2000;
    Console.WriteLine(pedro.Nome);
    Console.WriteLine(pedro.Cpf);
    Console.WriteLine(pedro.Salario);

    Diretor roberta = new Diretor();
    roberta.Nome = "Roberta Silva";
    roberta.Cpf = "987654321";
    roberta.Salario = 5000;
    Console.WriteLine(roberta.Nome);
    Console.WriteLine(roberta.Cpf);
    Console.WriteLine(roberta.Salario);

    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    gerenciador.Registrar(pedro);
    gerenciador.Registrar(roberta);

    Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
  }
}