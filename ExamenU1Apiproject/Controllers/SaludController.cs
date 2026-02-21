
using ExamenU1Apiproject.Entities;
using Microsoft.AspNetCore.Mvc;
using ExamenU1Apiproject.Clases;

namespace ExamenU1Apiproject.Controllers
{
    
    [Route("api/salud")]
    [ApiController]
    
    public class SaludController :ControllerBase
    {
        ImcCalculator CalcularImc = new ImcCalculator();
        private readonly List<SaludEntity> _healts;
        public SaludController()
        {
            double Peso = 150.0;
             double altura = 1.75;
            _healts = new List<SaludEntity>
            {
                new SaludEntity
                {
                Peso = Peso,
                altura = altura, 
                imc =  CalcularImc.CalcularImc (altura, Peso),
                clasificacion = CalcularImc.ClasificacionImc()
                }
            };
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_healts);   
        }
    }
}