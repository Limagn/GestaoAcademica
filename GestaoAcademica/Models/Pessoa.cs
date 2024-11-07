using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public class Pessoa
  {
    public Pessoa (string nome, string sobrenome, string cpf) 
    {
      Nome = nome;
      Sobrenome = sobrenome;
      Cpf = cpf;
    }

    public Pessoa(string nome, string sobrenome, string cpf, int idade)
    {
      Nome = nome;
      Sobrenome = sobrenome;
      Cpf = cpf;
      Idade = idade;
    }

    private string _nome;
    private string _sobrenome;
    private string _cpf;

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
    
    public string Cpf
    {
      get => _cpf;

      set
      {
        if (value == null)
        {
          throw new ArgumentException("O cpf não pode ser vazio.");
        }
        _cpf = value;
      }
    }

    public int Idade {  get; set; }

    public void Informacoes()
    {
      if (Idade != 0)
      {
        Console.WriteLine("\n--------Dados--------\n" +
          $"\nNome: {Nome} {Sobrenome}" +
          $"\nCPF: {Cpf}" +
          $"\nIdade: {Idade}"
        );
      } 
      else
      {
        Console.WriteLine("\n--------Dados--------\n" +
          $"\nNome: {Nome} {Sobrenome}" +
          $"\nCPF: {Cpf}"
        );
      }
    }
  }
}
