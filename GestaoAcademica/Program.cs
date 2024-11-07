using System;
using GestaoAcademica.Models;

namespace GestaoAcademica
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Seja bem-vindo(a). \n" +
        "Digite se você é aluno(a) ou professor(a): \n" +
        "1 - Aluno(a). \n" +
        "2 - Professor(a). ");
      int permissao = Convert.ToInt32(Console.ReadLine());
      
    }

    public static void IniciarAluno()
    {

    }

    public static void IniciarProfessor()
    {

    }
  }
}