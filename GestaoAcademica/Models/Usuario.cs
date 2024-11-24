using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  internal class Usuario
  {
    public void IniciarAdmin(Administrador adm)
    {
      string login = "";
      string senha = "";

      while (login != adm.Login || senha != adm.Senha)
      {
        Console.Clear();
        Console.WriteLine("Insira o login:");
        login = Console.ReadLine();
        Console.WriteLine("Insira a senha:");
        senha = Console.ReadLine();
        Console.Clear();
      }

      int opcao = 0;
      while (opcao == 0)
      {
        Console.WriteLine("Insira a opção desejada: ");
        Console.WriteLine("1 - Adicionar aluno(a).");
        Console.WriteLine("2 - Adicionar professor(a).");
        Console.WriteLine("3 - Listar alunos.");
        Console.WriteLine("4 - Listar professores.");
        Console.WriteLine("5 - Voltar ao menu anterior.");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
          case 1:
            adm.AdicionarAluno();
            opcao = 0;
            break;

          case 2:
            adm.AdicionarProfessor();
            opcao = 0;
            break;

          case 3:
            adm.ListarAlunos();
            opcao = 0;
            break;

          case 4:
            adm.ListarProfessores();
            opcao = 0;
            break;

          case 5:
            break;

          default:
            Console.WriteLine("Opção inválida.\n");
            opcao = 0;
            break;
        }
      }
    }

    public void IniciarAluno()
    {
      //TODO: Implantar método aluno.
    }

    public void IniciarProfessor()
    {
      //TODO: Implantar método professor.
    }
  }
}
