using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_3
{
    //CLase medida hereda de conversor
    public class Medida : Conversor
    {
        //Atributos
        public double Cantidad { get; set; }//convertir Metros a centimetros, nota solo se convierte a , descripcion
        public double DefinirConversion()
        {
            return (Cantidad * 100);
        }
        //Constructor
        public Medida()
        {

        }

    }
}
