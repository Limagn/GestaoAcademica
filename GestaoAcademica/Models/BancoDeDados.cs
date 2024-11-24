using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public static class BancoDeDados
  {
    public static Dictionary<string, Aluno> DictAlunos = new Dictionary<string, Aluno>();
    public static Dictionary<string, Professor> DictProfessores = new Dictionary<string, Professor>();
  }
}
