using AGC.Core.ModelEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AGC.Core.Interfaces
{
    public interface IUsuario
    {
        Task<IEnumerable<Usuario>> GetUsuario();
    }
}
