using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_U2Ex
{
    class Auto
    {
        //Atributos
        private string marca;
        private string modelo;
        private string compañia;
        private int cilindro;
        private double distancia;
        private double velocidad;

        //Acceso a los atributos
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Compañia
        {
            get { return compañia; }
            set { compañia = value; }
        }
        public int Cilindro
        {
            get { return cilindro; }
            set { cilindro = value; }
        }
        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }
        public double Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        //Metodo calcular tiempo
        public double VelFinal(double distancia, double velocidad)
        {
            //vel = distancia / 60;
            double tiempo = distancia / velocidad;
            return tiempo;
            //t=d/v
        }

        public void Menu()
        {
            //Variable auxiliar
            int opcion;
            //Instancias
            Auto car1 = new Auto();
            Auto car2 = new Auto();
            Auto auto1 = new Auto();
            
            //menu
            do
            {
                Console.Clear();
                Console.WriteLine("\nMenu de la Agencia");
                Console.WriteLine("1.- Capturar autos.");
                Console.WriteLine("2.- Capturar distancia.");
                Console.WriteLine("3.- Mostrar auto.");
                Console.WriteLine("4.- Calcular tiempo en recorrer la distancia.");
                Console.WriteLine("5.- Salir.");
                Console.Write("\nSeleccione una opcion: ");
                opcion = Int16.Parse(Console.ReadLine());

                switch (opcion)
                { 
                    case 1://Captura de datos
                        Console.Clear();
                        Console.WriteLine("\nAuto1");
                        car1.CapturaDat();
                        Console.WriteLine("\nAuto2");
                        car2.CapturaDat();
                        Console.WriteLine("\nPresione <Enter> para regresar al menu.");
                        Console.ReadKey();
                        break;

                    case 2://Captura de datos de distancia
                        Console.Clear();
                        Console.Write("\nCapturar distancia \n\n¿Que auto quiere 1 o 2?: ");
                        int decidir = Convert.ToInt32(Console.ReadLine());
                        if (decidir == 1)
                        {
                            Console.Write("\nIngresar la distancia que desea calcular del auto 1 (km): ");
                            car1.Distancia = Convert.ToDouble(Console.ReadLine());
                        }
                        else if((decidir == 2))
                            {
                            Console.Write("\nIngresar la distancia que desea calcular del auto 2 (km): ");
                            car2.Distancia = Convert.ToDouble(Console.ReadLine());
                        }

                        Console.WriteLine("\nPresione <Enter> para regresar al menu.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("\nDatos del auto \n\n¿Que auto quiere 1 o 2?: ");
                        int deci = Convert.ToInt32(Console.ReadLine());
                        if (deci == 1)
                        {
                            auto1.InformacionAuto(car1);
                        }
                        else if ((deci == 2))
                        {
                            auto1.InformacionAuto(car2);
                        }
                        // auto1.InformacionAuto();

                        Console.WriteLine("\nPresione <Enter> para regresar al menu.");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("\nDatos del auto, con tiempo. \n\n¿Que auto quiere el 1 o 2?: ");
                        int dec = Convert.ToInt32(Console.ReadLine());
                        if (dec == 1)
                        {
                            //Imprimir datos con metodo sobrecargado
                            double vf1 = auto1.VelFinal(car1.Distancia, car1.Velocidad);

                            auto1.InformacionAuto(car1, vf1);
                        }
                        else if ((dec == 2))
                        {
                            //Imprimir datos con metodo sobrecargado
                            double vf2 = auto1.VelFinal(car2.Distancia, car2.Velocidad);

                            auto1.InformacionAuto(car2, vf2);
                        }

                        Console.WriteLine("\nPresione <Enter> para regresar al menu.");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("\nPresione <Enter> para salir del programa.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("\nOpcion no existente, Presione <Enter> para continuar...");
                        Console.ReadKey();
                        break;

                }//Fin switch
            } while (opcion != 5);
        }

        public void CapturaDat()
        {
            Console.WriteLine("\nIngrese los datos del automovil");
            Console.Write("Marca: ");
            Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            Modelo = Console.ReadLine();
            Console.Write("Compañia: ");
            Compañia = Console.ReadLine();
            Console.Write("Numero de cilindros: ");
            Cilindro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Velocidad Max que alcanza el auto (km/h): ");
            Velocidad = Convert.ToDouble(Console.ReadLine()); //k/m            
        }

        //Metodo
        public void InformacionAuto(Auto Au)
        {
            Console.WriteLine("\nDatos del automovil \n");
            Console.WriteLine("Marca: " + Au.Marca);
            Console.WriteLine("Modelo: " + Au.Modelo);
            Console.WriteLine("Compañia: " + Au.Compañia);
            Console.WriteLine("Numero de Cilindros: " + Au.Cilindro);
            Console.WriteLine("Velocidad Max del auto (km/h): " + Au.Velocidad);
            //Console.ReadLine();
        }

        //Metodo sobrecargado
        public void InformacionAuto(Auto Au, double di)
        {
            Console.WriteLine("\nDatos del automovil \n");
            Console.WriteLine("Marca: " + Au.Marca);
            Console.WriteLine("Modelo: " + Au.Modelo);
            Console.WriteLine("Compañia: " + Au.Compañia);
            Console.WriteLine("Numero de Cilindros: " + Au.Cilindro);
            Console.WriteLine("Velocidad Max del auto (km/h): " + Au.Velocidad);

            Console.WriteLine("\nEl tiempo en que recorre {0} km, es de : {1} h",Au.Distancia, Math.Round(di,3));
        }
    }
}