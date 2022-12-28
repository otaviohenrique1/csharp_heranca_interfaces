namespace bytebank.Funcionarios
{
  /*
    ':' => Herança e equivale ao 'extends' em outras linguagens
  */
  public class Diretor:Funcionario
  {
    // 'override' => Indica que é um metodo sobrescrito
    // 'base' => Acessar o metodo da superclasse(classe que foi herdada) e equivale ao 'super' em outras linguagens
    public override double getBonificacao()
    {
      return this.Salario + base.getBonificacao();
    }
  }
}