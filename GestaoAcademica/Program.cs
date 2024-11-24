using System;
using GestaoAcademica.Models;

namespace GestaoAcademica
{
  public class Program
  {
    public static void Main()
    {
      Administrador adm = new();
      Usuario user = new();

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
            user.IniciarAluno();
            permissao = 0;
            break;

          case 2:
            user.IniciarProfessor();
            permissao = 0;
            break;

          case 3:
            user.IniciarAdmin(adm);
            permissao = 0;
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
  }
}