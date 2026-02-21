using Ejercicio2ValidarContraseña.Entities;
using Microsoft.AspNetCore.Mvc;
using Ejercicio2ValidarContraseña.Clases;

namespace Ejercicio2ValidarContraseña.Controllers
{
        [Route("api/seguridad")]
    [ApiController]

    public class PasswordController : ControllerBase
    {
        ValidarContraseña validar = new ValidarContraseña();
        private readonly List<PasswordEntity> _security;
        public PasswordController()
        {
            _security = new List<PasswordEntity>
            {
                
            };
        }
        [HttpGet("{password}")]
        public IActionResult GetOne(string password)
        {
                new PasswordEntity
                {
                    Valida = validar.ValidarContra(password),
                    Mensaje = validar.segura(),
                };
                return Ok(_security);
        }
}
    }
    