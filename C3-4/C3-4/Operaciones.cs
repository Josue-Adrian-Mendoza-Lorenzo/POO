using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_4
{
    public class Operaciones
    {
        //Globalmente declaramos una lista null, no mejor se inicializa new List<Transaccion>()
        List<Transaccion> Historial = new List<Transaccion>();
        //Metodo Principal()
        public void Principal()
        {
            Console.WriteLine("Bienvenido a su Entidad Bancaria");
            Console.Write("\nDigite su Nombre y su numero de cuenta.");
            Console.Write("\nNombre: ");
            //Console.Write("Digite su numero Nombre: ");
            var nombre = Console.ReadLine();
            //instancia cliente
            Persona cliente = new Persona(nombre);
            Console.Write("\nDigite su numero de cuenta: ");
            cliente.NumCuenta = int.Parse(Console.ReadLine());

            Console.Write("\nPresione e para continuar y s para salir: ");
            //Variables axuliliares
            string entrar = Console.ReadLine();
           
            //while
            while (entrar == "e" || entrar == "E")
            {
                Console.Clear();
                //Cortamos la seccion del menu
                Console.WriteLine("\n¿Desea hacer una transacción o mirar su balance? " + "\n 0- Transaccion \n 1- Balance \n");
                Console.Write("Opcion: "); var operacion = Console.ReadLine();
                //Variable global
                Transaccion transaccion;

                if (operacion == "0")
                {
                    Console.WriteLine("\nTransaccion a realizar");

                    transaccion = new Transaccion();
                    HacerTransaccion(transaccion);//Metodo donde guardamos el proceso de transaccion
                }

                else if (operacion == "1")
                {
                    //Console.Write("\nBalance: ");
                    transaccion = new Transaccion();

                    Console.WriteLine("\nUsted tiene un Balance de: $" + transaccion.CalcularBalance());
                    Console.WriteLine("------------------------------------------------- ");
                    Console.WriteLine("Sus ultimos Movimientos son: ");
                    Console.WriteLine("Tipo \t Cantidad  Saldo\tFecha  ");

                    decimal total = 0m;
                    //Foreach para mostra la lista
                    foreach (var item in Historial)
                    {
                        //Definimos que tipo de transaccion estamos haciendo
                        var tipo = string.Empty;
                        var cantidad = 0m;
                        //Preguntamos si el primer objeto es mayor a 0, si no es mayor a 0 sera retiro
                        if (item.Deposito > 0)
                        {
                            tipo = "Deposito";
                            cantidad = item.Deposito;
                            total += cantidad;
                        }
                        else
                        {
                            tipo = "Retiro\t";
                            cantidad = item.Retiro;
                            total -= cantidad;
                        }
                        Console.WriteLine(tipo + " " + cantidad + " \t   " + total + "\t" + item.FechaTransaccion);
                        
                    }//Fin foreach
                    Console.WriteLine("------------------------------------------------- ");
                }
                else
                {
                    Console.WriteLine("\nSolo son validas dos opciones, Gracias por su preferencia.");
                }

                Console.Write("\nPresione e para continuar y s para salir: ");
                //Variables axuliliares
                entrar = Console.ReadLine();

            }//Fin while

            Console.ReadKey();
        }
        //Este metodo recibe un objeto llamado transaccion, con la variable tipo transaccion
        public void HacerTransaccion(Transaccion transaccion)
        {   //Hora actual
            //transaccion.FechaTransaccion = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //ToshortTostring, o al revez

            Console.WriteLine("1. Deposito \n2. Retiro \n");
            Console.Write("Opcion: "); var oper = Console.ReadLine();

            DateTime Hoy = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (oper == "1")
            {
                
                Console.Write("\nDigite la cantidad a depositar: ");
                transaccion.Deposito = decimal.Parse(Console.ReadLine());
                transaccion.Depositar(transaccion.Deposito); //se envia el depostito a depositar
                transaccion.FechaTransaccion = Hoy;

                Historial.Add(transaccion);//Para guardar el retiro
            }
            else if (oper == "2")
            {
                Console.Write("\nDigite la cantidad a retirar: ");
                transaccion.Retiro = decimal.Parse(Console.ReadLine());
                transaccion.Retirar(transaccion.Retiro);//se envia el retiro a retirar
                transaccion.FechaTransaccion = Hoy;
                Historial.Add(transaccion);

            }
            else
            {
                Console.WriteLine("Opcion no valida");
                Console.ReadKey();
                return;
            }
        }//Fin Metodo HacerTransaccion
    }//Fin clase Operaciones
}
