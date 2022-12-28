namespace bytebank.Funcionarios
{
  public class Funcionario
  {
    public string? Nome { get; set; } // remover o anulavel => '?'
    public string? Cpf { get; set; } // remover o anulavel => '?'
    public double Salario { get; set; }

    public double getBonificacao()
    {
      return this.Salario * 0.10;
    }
  }
}