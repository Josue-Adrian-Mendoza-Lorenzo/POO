using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_4
{
    public class Persona
    {   //Atributos de Persona
        public int NumCuenta { get; set; }
        public string Nombre { get; set; }

        //Constructor cargado con un atributo
        public Persona(string Nombre)
        {
            Console.WriteLine("\nBienvenido: " + Nombre);
            //Console.ReadKey();
        }
        //Para que la herencia funcione pusimos un constructor vacio
        public Persona()
        {

        }


    }//Fin clase Persona
}
