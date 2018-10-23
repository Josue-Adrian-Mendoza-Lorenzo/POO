using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_3
{
    public class Conversor
    {
        public string Tipo { get; set; }
        public decimal Descripcion { get; set; }
        //constructor vacio
        public Conversor()
        {
        }
        //Metodo, que nos diga lo que esta convirtiendo, 
        public string DefinirOperacion()
        {
            return "Usted está Convirtiendo " + Descripcion;
        } 
    }
}
