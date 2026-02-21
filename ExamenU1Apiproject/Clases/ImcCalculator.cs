
namespace ExamenU1Apiproject.Clases
{
    public class ImcCalculator
    {
        public double imc { get; set; }
        public double CalcularImc (double altura, double Peso)
        {
            imc = Peso /(altura * altura);
            return imc;
        }   
        public string ClasificacionImc ()
        {
            string clasificacion;
            if (imc<18.5)
                clasificacion = "Peso Bajo";
            else if (imc >18.5 && imc<25.0)
                clasificacion = "Peso Normal";
            else if ( imc >=25.0 && imc <30)
                clasificacion = "Sobre Peso";
            else
                clasificacion = "Obesidad";
            
            return clasificacion;
        }
    }
}