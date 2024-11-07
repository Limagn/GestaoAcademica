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
        Console.WriteLine("3 - Administrador(a).");
        Console.WriteLine("4 - Sair.");
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
            IniciarAdministrador();
            break;

          case 4:
            Console.WriteLine("Finalizando o sistema.");
            return;

          default:
            Console.WriteLine("Opção inválida.\n");
            permissao = 0;
            break;
        }
      }
    }

    public static void IniciarAluno()
    {
      Console.Clear();
      Console.WriteLine("Aluno.");


      //TODO: Implementar metodos permitidos aos alunos
      //Console.WriteLine("Digite a opção desejada:")

      //TODO: Opcao voltar ao menu
      //Console.WriteLine("00 - Voltar ao menu inicial");
    }

    public static void IniciarProfessor()
    {
      Console.Clear();
      Console.WriteLine("Professor.");

      //TODO: Implementar metodos permitidos aos professores
      //Console.WriteLine("Digite a opção desejada:")

      //TODO: Opcao voltar ao menu
      //Console.WriteLine("00 - Voltar ao menu inicial
    }

    public static void IniciarAdministrador()
    {
      Console.Clear();
      Console.WriteLine("Adm.");

      //TODO: Implementar metodos permitidos aos administradores
      //Console.WriteLine("Digite a opção desejada:")

      //TODO: Opcao voltar ao menu
      //Console.WriteLine("00 - Voltar ao menu inicial
    }
  }
}