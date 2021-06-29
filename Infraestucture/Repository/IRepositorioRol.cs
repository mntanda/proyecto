using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public interface IRepositorioRol
    {
        IEnumerable<Rol> GetRol();
        Rol GetRolByNombre(String nombre);
        Rol GetRolById(int id);
    }
}
