using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_4
{   //rdenar el codigo, crear metodos para facilitar el proceso
    public class Transaccion : Persona //Heredara las propiedades de persona
    {   //Atributos de Transaccion
        public decimal Deposito { get; set; } //
        public decimal Retiro { get; set; } //
        public DateTime FechaTransaccion { get; set; } //
        public decimal Total { get; set; }

        //Constructor vacio
        public Transaccion()
        {

        }

        //metodo void, no regresa un valor retornable
        //Cambiamos el valor del metodo a decimal, para retornar suma return suma;
        public decimal Depositar(decimal Deposito)
        {
            decimal suma = Total + Deposito;
            Console.WriteLine("Usted ha depositado: " + Deposito);
            //Console.WriteLine("Su saldo acutal es: " + suma);
            return Total = suma;
        }
        //Modificamos el metodo para poder retornar el valor de la resta
        public decimal Retirar(decimal Retiro)
        {
            decimal resta = Total - Retiro;
            Console.WriteLine("Usted ha retirado: " + Retiro);
            //Console.WriteLine("Su saldo acutal es: " + resta);

            return Total = resta;
        }
        //metodo CalcularBlance
        public decimal CalcularBalance()
        {
            return Total;
        }
    }//Fin clase Transaccion
}
