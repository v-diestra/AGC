using AGC.Core.Interfaces;
using AGC.Core.ModelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        public async Task<IEnumerable<Usuario>> GetUsuario()
        {
            var usuario = Enumerable.Range(1, 10).Select(x => new Usuario
            {
                IdUsuario = x,
                Nombre = $"Victor {x}",
                FecRegistro = DateTime.Now,
                Correo = $"diestraespiritu {x}",
                Contraseña = $"Contraseña {x}"

            });
            await Task.Delay(10);
            return usuario;
        }

    }

}
