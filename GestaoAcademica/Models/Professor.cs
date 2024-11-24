using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public class Professor : Pessoa, IAvaliacao
  {
    public Professor(string nome, string sobrenome, string matricula) : base(nome, sobrenome, matricula)
    {
    }

    public override void Apresentacao()
    {
      if (Idade != 0)
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos. Sou professor na UniFOA e dou aula de: ");
      }
      else
      {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto}. Sou professor na UniFOA e dou aula de: ");
      }
    }
    public void Avaliar(string aluno, int nota)
    {
      var alunos = BancoDeDados.DictAlunos.Values;
      Console.WriteLine($"O professor {NomeCompleto} avaliou o {aluno} com a nota {nota}.");
    }
    public override string ToString()
    {
      return $"Nome: {Nome} {Sobrenome}, Matrícula: {Matricula}";
    }
  }
}
