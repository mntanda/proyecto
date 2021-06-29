using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public interface IRepositoryContacto
    {
        IEnumerable<Contacto> GetContacto();
        Contacto GetContactoByProveedor(int id);
        Contacto GetContactoByProducto(int id);
        Contacto Save(Contacto contacto);
        void DeleteContacto(int id);
    }
}
