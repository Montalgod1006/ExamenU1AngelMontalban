
namespace Ejercicio3TablasMultiplicar.Clases
{
    public class TablaMultiplicar
    {
        public string [] tablaMultiplicar ( int numero, int hasta)
        {
            string [] tabla = new string [hasta];
            for (int i = 1; i <= hasta; i++)
            {
                int multiplicacion = numero * i;
                string[i] = $"{hasta}x{numero} = {multiplicacion}";
            }
            return tabla;
        }
    }
}