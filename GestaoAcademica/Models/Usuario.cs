using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
      string matricula = "";

      while (matricula == "")
      {
        Console.Clear();
        Console.WriteLine("Insira sua matrícula:");
        matricula = Console.ReadLine();
        Console.Clear();
      }

      bool sucesso = BancoDeDados.DictAlunos.TryGetValue(matricula, out Aluno aluno);

      if (!sucesso)
      {
        Console.WriteLine("Matrícula Inválida.");
        Console.WriteLine();
        return;
      }

      int opcao = 0;
      while (opcao == 0)
      {
        Console.WriteLine("Insira a opção desejada: ");
        Console.WriteLine("1 - Apresentação.");
        Console.WriteLine("2 - Avaliar professor(a).");
        Console.WriteLine("3 - Voltar ao menu anterior.");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
          case 1:
            aluno.Apresentacao();
            opcao = 0;
            break;

          case 2:
            Console.WriteLine("Insira a matricula do Professor: ");
            string matricProfessor = Console.ReadLine();
            Console.WriteLine("Insira a nota do Professor: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            aluno.Avaliar(matricProfessor, nota);

            opcao = 0;
            break;

          case 3:
            break;

          default:
            Console.WriteLine("Opção inválida.\n");
            opcao = 0;
            break;
        }
      }
    }

    public void IniciarProfessor()
    {
      string matricula = "";

      while (matricula == "")
      {
        Console.Clear();
        Console.WriteLine("Insira sua matrícula:");
        matricula = Console.ReadLine();
        Console.Clear();
      }

      bool sucesso = BancoDeDados.DictProfessores.TryGetValue(matricula, out Professor professor);

      if (!sucesso) 
      {
        Console.WriteLine("Matrícula Inválida.");
        Console.WriteLine();
        return;
      }

      int opcao = 0;
      while (opcao == 0)
      {
        Console.WriteLine("Insira a opção desejada: ");
        Console.WriteLine("1 - Apresentação.");
        Console.WriteLine("2 - Avaliar aluno(a).");
        Console.WriteLine("3 - Voltar ao menu anterior.");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
          case 1:
            professor.Apresentacao();
            opcao = 0;
            break;

          case 2:
            Console.WriteLine("Insira a matricula do Aluno: ");
            string matricAluno = Console.ReadLine();
            Console.WriteLine("Insira a nota do Aluno: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            professor.Avaliar(matricAluno, nota);

            opcao = 0;
            break;

          case 3:
            break;

          default:
            Console.WriteLine("Opção inválida.\n");
            opcao = 0;
            break;
        }
      }
    }
  }
}
