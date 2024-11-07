using System;
using GestaoAcademica.Models;

namespace GestaoAcademica
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int permissao = 0;
      while (permissao == 0)
      {
        Console.WriteLine("Seja bem-vindo(a). \n" +
          "Digite a opção se você é aluno(a) ou professor(a): ");
        Console.WriteLine("1 - Aluno(a).");
        Console.WriteLine("2 - Professor(a).");
        Console.WriteLine("3 - Sair.");
        permissao = Convert.ToInt32(Console.ReadLine());

        switch (permissao)
        {
          case 1:
            IniciarAluno();
            break;

          case 2:
            IniciarProfessor();
            break;

          case 3:
            Console.WriteLine("Finalizando o sistema.");
            return;

          default:
            Console.WriteLine("Opção inválida.");
            permissao = 0;
            break;
        }
      }
    }

    public static void IniciarAluno()
    {
      Console.Clear();
      Console.WriteLine("Aluno.");

      //Implementar metodos permitidos aos alunos

      //Opcao voltar ao menu
    }

    public static void IniciarProfessor()
    {
      Console.Clear();
      Console.WriteLine("Professor.");

      //Implementar metodos permitidos aos professores

      //Opcao voltar ao menu
    }
  }
}