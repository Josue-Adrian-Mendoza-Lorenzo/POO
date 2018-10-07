using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion
{
    public class Calculo
    { 
        public double Base { get; set; }
        public double Altura { get; set; }

        //Metodo para calcularArea
        public double CalcularArea(double _base, double altura)
        {
            double area = (_base * altura)/2;
            return area;
        }

        //Metodo con 2 parametros
        public double CalcularHipotenusa(double _base, double altura)
        {
            double hipotenusa = Math.Sqrt((_base)*(_base) + (altura)*(altura));
            return hipotenusa;//Hipotenusa
        }

        public double CalcularPerimetro(double _base, double altura)
        {
            //Instanciamos una variable, 
            //double hipotenusa = CalcularHipotenusa(_base , altura);

            double perimetro = CalcularHipotenusa(_base, altura) + _base + altura;

            //Todo metodo con tipo de dato, debe devolver un valor
            return perimetro;
        }
    }

}
