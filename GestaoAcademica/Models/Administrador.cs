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
    public void AdicionarAluno()
    {
      Console.WriteLine("Matrícula do(a) aluno(a):");
      string matricula = Console.ReadLine();
      Console.WriteLine("Nome do(a) aluno(a):");
      string nome = Console.ReadLine();
      Console.WriteLine("Sobrenome do(a) aluno(a):");
      string sobrenome = Console.ReadLine();
      Console.WriteLine("Curso do(a) aluno(a):");
      string curso = Console.ReadLine();

      Aluno aluno = new Aluno(nome, sobrenome, matricula, curso);
      bool sucesso = BancoDeDados.DictAlunos.TryAdd(matricula, aluno);
      if (sucesso)
      {
        Console.Clear();
        Console.WriteLine("Aluno(a) cadastrado(a) com sucesso.");
        Console.WriteLine();
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Esta matrícula já existe!");
        Console.WriteLine();
      }
    }
    public void AdicionarProfessor()
    {
      Console.WriteLine("Matrícula do(a) professor(a):");
      string matricula = Console.ReadLine();
      Console.WriteLine("Nome do(a) professor(a):");
      string nome = Console.ReadLine();
      Console.WriteLine("Sobrenome do(a) professor(a):");
      string sobrenome = Console.ReadLine();
      Console.WriteLine("Disciplina do(a) professor(a):");
      string disciplina = Console.ReadLine();

      Professor professor = new Professor(nome, sobrenome, matricula, disciplina);
      bool sucesso = BancoDeDados.DictProfessores.TryAdd(matricula, professor);
      if (sucesso)
      {
        Console.Clear();
        Console.WriteLine("Professor(a) cadastrado(a) com sucesso.");
        Console.WriteLine();
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Esta matrícula já existe!");
        Console.WriteLine();
      }
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
