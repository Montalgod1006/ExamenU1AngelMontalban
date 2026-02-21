
namespace Ejercicio2ValidarContraseña.Clases
{
    public class ValidarContraseña
    {
        public bool Validar { get; set; }
        public bool ValidarContra(string contraseña)
        {
            string permitidos = "!@#$%^&*";
            if (contraseña.Length<8)
            {
               // La contraseña es muy pequeña, añada mas caracteres"
                Validar = false;
            }
                
            else if(!contraseña.Any(char.IsLower)|| !contraseña.Any(char.IsUpper))
            {
                //la contraseña debe llevar mayúsculas y minúsculas
                Validar = false;
            }
                
            else if(!contraseña.Any(char.IsNumber))
            {
               //la contraseña debe llevar al menos un numero
                Validar = false;
            }
            else if(!contraseña.Any(ch => permitidos.Contains(ch)))
            {
                //la contraseña debe llevar al menos un dígito especial
                Validar = false;
            }
            else
                Validar = true;

            return Validar;
        }
        public string segura ()
        {
            string seguro;
            if(Validar == true)
            seguro = "Contraseña Segura";
            else
            seguro = "Contraseña Insegura";
            return seguro;

        }
    }
}