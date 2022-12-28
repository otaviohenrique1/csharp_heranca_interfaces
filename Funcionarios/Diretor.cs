namespace bytebank.Funcionarios
{
  /*
    ':' => Herança e equivale ao 'extends' em outras linguagens
  */
  public class Diretor:Funcionario
  {
    public double getBonificacao()
    {
      return this.Salario;
    }
  }
}