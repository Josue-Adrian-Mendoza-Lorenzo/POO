using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeEstudiante
{
    class Estudiante
    {
        /* nombre
         * apellido
         * id
         * semestre
         * carrera
         * edad
         * sexo
         * 
         */
        private int id;
        private int edad;

        private string nombre;
        private string apellido;
        private string semestre;
        private string carrera;
        private char sexo;


        //se hacen publicas las variables, (como buena practica en programacion) 
        //sirve para la seguridad en el programa
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public void VerInformacion(Estudiante student) //Pasando un atributo de tipo objeto
        {
            Console.WriteLine("Nombre Completo: " + student.Nombre +""+ student.Apellido);
            Console.WriteLine("Numero de Control: " + student.Id);
            Console.ReadLine();
        }

        public void VerInformacion(Estudiante student, string info) //sobrecarga de meto, Pasando un atributo de tipo objeto
        {
            Console.WriteLine("Nombre Completo: " + student.Nombre + "" + student.Apellido);
            Console.WriteLine("Numero de Control: " + student.Id);
            Console.WriteLine(info);
            Console.ReadLine();
        }




    }
}
