using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public abstract class Pessoa
  {
    public Pessoa(string nome, string sobrenome, string matricula)
    {
      Nome = nome;
      Sobrenome = sobrenome;
      Matricula = matricula;
    }

    public Pessoa(string nome, string sobrenome, string matricula, int idade) : this(nome, sobrenome, matricula)
    {
      Idade = idade;
    }

    private string _nome;
    private string _sobrenome;
    private string _matricula;

    public string Nome
    {
      get => _nome;

      set
      {
        if (value == "")
        {
          throw new ArgumentException("O nome não pode ser vazio.");
        }
        _nome = value;
      }
    }

    public string Sobrenome
    {
      get => _sobrenome;

      set
      {
        if (value == "")
        {
          throw new ArgumentException("O sobrenome não pode ser vazio.");
        }
        _sobrenome = value;
      }
    }

    public string Matricula
    {
      get => _matricula;

      set
      {
        if (value == null)
        {
          throw new ArgumentException("A matricula não pode ser vazia.");
        }
        _matricula = value;
      }
    }

    public string NomeCompleto => $"{Nome} {Sobrenome}";
    public int Idade {  get; set; }

    public abstract void Apresentacao();
  }
}
