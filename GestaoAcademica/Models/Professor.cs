using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public class Professor : Pessoa, IAvaliacao
  {
    public Professor(string nome, string sobrenome, string matricula, string disciplina) : base(nome, sobrenome, matricula)
    {
    Disciplina = disciplina;
    }
    public string Disciplina { get; set; }

    public override void Apresentacao()
    {
      if (Idade != 0)
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos. Sou professor na UniFOA e dou aula de {Disciplina} ");
        Console.WriteLine();
      }
      else
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto}. Sou professor na UniFOA e dou aula de {Disciplina} ");
        Console.WriteLine();
      }
    }
    public void Avaliar(string matricAluno, int nota)
    {
      BancoDeDados.DictAlunos.TryGetValue(matricAluno, out Aluno aluno);
      Console.Clear();
      Console.WriteLine($"O professor {NomeCompleto} avaliou o aluno {aluno.NomeCompleto} com a nota {nota}.");
      Console.WriteLine();
    }
    public override string ToString()
    {
      return $"Nome: {Nome} {Sobrenome}, Matrícula: {Matricula}, Disciplina: {Disciplina}";
    }
  }
}
