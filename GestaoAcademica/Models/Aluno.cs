using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public class Aluno : Pessoa, IAvaliacao
  {
    public Aluno(string nome, string sobrenome, string matricula, string curso) : base(nome, sobrenome, matricula)
    {
      Curso = curso;
    }
    public string Curso { get; set; }

    public override void Apresentacao()
    {
      if (Idade != 0)
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos. Sou aluno na UniFOA e estudo {Curso}");
        Console.WriteLine();
      }
      else
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto}. Sou aluno na UniFOA e estudo {Curso}");
        Console.WriteLine();
      }
    }
    public void Avaliar(string matricProfessor, int nota)
    {
      BancoDeDados.DictProfessores.TryGetValue(matricProfessor, out Professor professor);
      Console.Clear();
      Console.WriteLine($"O aluno {NomeCompleto} avaliou o professor {professor.NomeCompleto} com a nota {nota}.");
      Console.WriteLine();
    }
    public override string ToString()
    {
      return $"Nome: {Nome} {Sobrenome}, Matrícula: {Matricula}, Curso: {Curso}";
    }

  }
}
