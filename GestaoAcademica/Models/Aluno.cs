using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public class Aluno : Pessoa, IAvaliacao
  {
    public Aluno(string nome, string sobrenome, string matricula) : base(nome, sobrenome, matricula)
    {
    }

    public List<Professor> Professores { get; set; }

    public override void Apresentacao()
    {
      if (Idade != 0)
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos. Sou aluno na UniFOA e tenho aula de:");
      }
      else
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto}. Sou professor na UniFOA e tenho aula de:");
      }
    }
    public void Avaliar(string professor, int nota)
    {
      Console.WriteLine($"O aluno {NomeCompleto} avaliou o {professor} com a nota {nota}.");
    }
    public override string ToString()
    {
      return $"Nome: {Nome} {Sobrenome}, Matrícula: {Matricula}";
    }

  }
}
