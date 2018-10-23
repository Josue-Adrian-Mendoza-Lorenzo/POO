using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3_3
{
    //Clase temperatura hereda de conversor
    public class Temperatura : Conversor
    {
        //Atributos
        public double Grados { get; set; }
        //ctor doble tap para constructor
        public Temperatura()
        {
                
        }
        //Metodo pblico de tipo double
        public double DefinirConversion()
        {
            return (Grados * 9 / 5) + 32;
        }
        public string DefinirConversion(string mensaje)
        {
            return mensaje="";
        }

    }
}
