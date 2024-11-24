using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademica.Models
{
  public interface IAvaliacao
  {
    void Avaliar(string nome, int nota);
  }
}
