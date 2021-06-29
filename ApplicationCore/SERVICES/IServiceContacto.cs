using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
   public interface IServiceContacto
    {
        IEnumerable<Contacto> GetContacto();
        Contacto GetContactoByProveedor(int id);
        Contacto GetContactoByProducto(int id);    
    }
}
