using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_3
{
    //Clase modena hereda de la clase conversor
    public class Moneda : Conversor
    {
        //Atributos
        public double Cantidad { get; set; }//pesos a dolares,  divisas utilizaremos lblSecundario, el resultado se mostrara en lblSecundario = tipo de cambio
        //Constuctor, se le pueden pasar los parametros y los metodos, inicializan los eventos antes que otra propiedad de la clase
        public Moneda()
        {
            Cantidad = 1000; // se inicializa mucho antes que cargue   
        }
        public double DefinirConversion()
        {
            return (Cantidad * 19.4);//Precio por dollar 22/10/18
        }

    }
}
