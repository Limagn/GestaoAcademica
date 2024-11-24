using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public class Administrador
  {
    public string Login => "admin";
    public string Senha => "admin";

    //public static Dictionary<string, Aluno> DictAlunos = new Dictionary<string, Aluno>();
    //public static Dictionary<string, Professor> DictProfessores = new Dictionary<string, Professor>();

    public void AdicionarAluno()
    {
      Console.WriteLine("Matrícula do(a) aluno(a):");
      string matricula = Console.ReadLine();
      Console.WriteLine("Nome do(a) aluno(a):");
      string nome = Console.ReadLine();
      Console.WriteLine("Sobrenome do(a) aluno(a):");
      string sobrenome = Console.ReadLine();

      Aluno aluno = new Aluno(nome, sobrenome, matricula);
      BancoDeDados.DictAlunos[matricula] = aluno;

      Console.Clear();
      Console.WriteLine("Aluno(a) cadastrado(a) com sucesso.");
      Console.WriteLine();
    }

    public void AdicionarProfessor()
    {
      Console.WriteLine("Matrícula do(a) professor(a):");
      string matricula = Console.ReadLine();
      Console.WriteLine("Nome do(a) professor(a):");
      string nome = Console.ReadLine();
      Console.WriteLine("Sobrenome do(a) professor(a):");
      string sobrenome = Console.ReadLine();

      Professor professor = new Professor(nome, sobrenome, matricula);
      BancoDeDados.DictProfessores[matricula] = professor;

      Console.Clear();
      Console.WriteLine("Professor(a) cadastrado(a) com sucesso.");
      Console.WriteLine();
    }

    public void ListarAlunos()
    {
      Console.WriteLine("Lista de alunos:");
      foreach (var item in BancoDeDados.DictAlunos)
      {
        Console.WriteLine($"{item.Value}");
      }
      Console.WriteLine();
    }
    public void ListarProfessores()
    {
      Console.WriteLine("Lista de professores:");
      foreach (var item in BancoDeDados.DictProfessores)
      {
        Console.WriteLine($"{item.Value}");
      }
      Console.WriteLine();
    }
  }
}
