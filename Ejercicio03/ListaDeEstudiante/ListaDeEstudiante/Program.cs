using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeEstudiante
{
    class Program
    {


        static void Main(string[] args)
        {
            ///*
            //Console.WriteLine("Hola Mundo");
            //Console.ReadLine();

            //Estudiante student = new Estudiante();
            //student.Id = 2675;
            //student.Nombre = "Javier";
            //student.Apellido = "Rosas";

            //Console.WriteLine(student.Nombre +" "+student.Apellido);
            //Console.ReadKey();
            //*/

            //Console.Clear();
            //Console.WriteLine("##### Bienvenidos a la lista de estudiantes #####");


            //Console.WriteLine("Agrega un estudiante");
            //Console.WriteLine("Cuando desee salir presione -1");

            ////  string exit = Console.ReadLine();

            //Console.Write("Defina su numero de estudiante: ");
            //int studentNumber = Convert.ToInt32(Console.ReadLine());

            //Estudiante[] studentArray = new Estudiante[studentNumber]; //Arreglo, debemos tener un valor predefinido en el arreglo

            //// int count = 0;

            //for (int i = 0; i < studentArray.Length; i++)
            //{

            //    //count++;
            //    //Inicializamos el objeto

            //    Estudiante student = new Estudiante(); //instanciar estudiante
            //    //Pedimos datos
            //    Console.Write("Escriba el Nombre el estudiante: ");
            //    student.Nombre = Console.ReadLine();

            //    Console.Write("Escriba el Apellido el estudiante: ");
            //    student.Apellido = Console.ReadLine();

            //    Console.Write("Escriba el Id:");
            //    student.Id = Convert.ToInt32(Console.ReadLine());
            //    //Se convierte el dato capturado para que la variable Id pueda guardarlo

            //    Console.Write("Escriba la Edad:");
            //    student.Edad = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Escriba el Semestre:");
            //    student.Semestre = Console.ReadLine();

            //    Console.Write("Escriba el Sexo:");
            //    student.Sexo = Convert.ToChar(Console.ReadLine());

            //    studentArray[i] = student; //meter el estudiante en el arreglo


            //    //studentArray[count] = student;
            //    //Muestra el numero de estuiantes capturados, si se cierra el programa se borra

            //    //Console.WriteLine("¿Desea agregar otro estudiante? ");
            //    // exit = Console.ReadLine();
            //}

            //Console.WriteLine("Los estudiantes son: \n ");
            //Console.WriteLine("Nombre \t Apellido \t Semestre \t Numero de Control");
            //for (int i = 0; i < studentArray.Length; i++)
            //{
            //    Console.WriteLine(studentArray[i].Nombre + "\t" + studentArray[i].Apellido + "\t" + studentArray[i].Semestre + "\t" + studentArray[i].Id);
            //    //studenyyArray[i].Nombre
            //    //Arreglo [posicion].Atributo
            //}
            //Console.ReadKey();

         

            //Creamos un objeto
            Estudiante student = new Estudiante();
            student.Nombre = "Juan";
            student.Apellido = "Vargas";
            student.Id = 25;

            //Debemos poner la lcase estudiante a publica para este ejercicio

            Estudiante perfil = new Estudiante(); //Sobrecarga de metodo
            perfil.VerInformacion(student);
            perfil.VerInformacion(student, "Informacion presentada");

        }
    }
}

