using Ejercicio3TablasMultiplicar.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3TablasMultiplicar.Controllers
{
    [Route("api/matematicas")]
    [ApiController]
    public class TablaController : ControllerBase
    {
        private readonly List<TablaEntity> _tablas;
        public TablaController()
        {
            int numero = 5, hasta = 10;
            _tablas = new List<TablaEntity>
            {
                new TablaEntity
                {
                    Numero = numero,
                    hasta = hasta,
                    tabla =
                    [
                        "{}"
                    ]
                }
            };
        }
    }
}