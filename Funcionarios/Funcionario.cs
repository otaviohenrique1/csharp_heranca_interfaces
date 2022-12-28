namespace bytebank.Funcionarios
{
  public class Funcionario
  {
    public string? Nome { get; set; } // remover o anulavel => '?'
    public string? Cpf { get; set; } // remover o anulavel => '?'
    public double Salario { get; set; }

    // 'virtual' => Indica que o metodo pode ser sobrescrito
    public virtual double getBonificacao()
    {
      return this.Salario * 0.10;
    }
  }
}