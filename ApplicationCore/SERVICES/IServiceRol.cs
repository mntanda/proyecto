using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceRol
    {
        IEnumerable<Rol> GetRol();
        Rol GetRolByNombre(String nombre);
        Rol GetRolById(int id);
    }
}
