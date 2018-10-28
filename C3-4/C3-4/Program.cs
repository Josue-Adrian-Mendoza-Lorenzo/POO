using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_4
{
    class Program
    { /* 1era Regla
        No se puede Heredar constructores ni destructores
        
        2da Regla 
        No se puede Heredar structuras

        3ra Regla No se Hereda atributos que se instancian en constructores

        4ta Regla
        Metodos con permisos que no sean publico, (todo debe ser publico)
        */
        static void Main(string[] args)
        {   //Mensaje
            Console.Title = "Bienvenido a su Entidad Bancaria";
            //Instancia
            Operaciones operacion = new Operaciones();
            //Llamada a metodo principal()
            operacion.Principal();
        }
    }
}