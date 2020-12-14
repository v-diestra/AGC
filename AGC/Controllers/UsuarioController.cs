using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGC.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AGC.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuarioRepository;
        public UsuarioController(IUsuario usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [Route("api/usuarios")]
        [HttpGet]

        public async Task<IActionResult> GetUsuario()
        {
            var usuario = await _usuarioRepository.GetUsuario();
            return Ok(usuario);
        }

    }
}
